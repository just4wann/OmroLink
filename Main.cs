using System.Net;
using System.Net.NetworkInformation;
using PLCCommLib;
using System.Text;
using Timer = System.Timers.Timer;

namespace OmroLink
{
    public partial class Main : Form
    {
        private PLCComm? _PLC = null;
        private readonly Timer _pulseRead = new();
        private bool _plcConnectionStatus = false;

        public Main()
        {
            InitializeComponent();

            _pulseRead.Interval = 1000;
            _pulseRead.Elapsed += ReadAddressPulseEvent;
        }

        private static void ShowPopupMessage(string title, string detail, int timeout = 1000)
        {
            Thread thread = new(() =>
            {
                var msgBox = new Form{
                   Width = 0,
                   Height = 0,
                   ShowInTaskbar = false,
                   StartPosition = FormStartPosition.CenterScreen,
                };

                Timer timer = new();
                timer.Interval = timeout;
                timer.Elapsed += (s, e) =>
                {
                    timer.Stop();
                };
                timer.Start();
                MessageBox.Show(msgBox, detail, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            });
            thread.Start();
        }

        private static PLCComm? IsPlcAndProtocolValid(PLCComm.VenderNames plc, PLCComm.ProtocolNames protocol)
        {
            PLCComm? PLC = null;
            if (plc == PLCComm.VenderNames.MITSUBISHI && protocol == PLCComm.ProtocolNames.MC3E) PLC = new PLC_MC();
            else if (plc == PLCComm.VenderNames.OMRON && protocol == PLCComm.ProtocolNames.FINS) PLC = new PLC_Fins();
            else if (plc == PLCComm.VenderNames.KEYENCE && protocol == PLCComm.ProtocolNames.MC3E) PLC = new PLC_MCKV();
            return PLC;
        }

        private static bool ConnectionPlcValidation(string ip, string port, out Tuple<string, string, int> data)
        {
            bool pingStatus = true;
            bool result = true;
            string fault = "";

            bool address = IPAddress.TryParse(ip, out IPAddress? ipaddress);
            try
            {
                Ping test = new();
                PingReply reply = test.Send(ipaddress!);
                pingStatus = reply.Status == IPStatus.Success;
            }
            catch (ArgumentNullException)
            {
                fault += $"IP Address cannot empty;\n";
                result = false;
            }
            catch (PingException)
            {
                fault += $"Ping IP Failed;\n";
                result = false;
            }
            catch (Exception e)
            {
                fault += $"Error : {e};\n";
                result = false;
            }

            if (!address || !pingStatus || !int.TryParse(port, out int portNum))
            {
                result = false;

                if (!address) fault += "IP Address Invalid;\n";

                if (!pingStatus) fault += "IP Address Unreachable;\n";

                if (!int.TryParse(port, out portNum)) fault += "Port Invalid;\n";

            }
            else fault = "Validation Success";

            data = Tuple.Create(fault, ip, portNum);
            return result;
        }

        private void PlcConnect()
        {
            PLCComm.VenderNames plcType = (PLCComm.VenderNames)plcList.SelectedIndex;
            PLCComm.ProtocolNames protocol = (PLCComm.ProtocolNames)protocolList.SelectedIndex;

            _PLC = IsPlcAndProtocolValid(plcType, protocol);
            if (_PLC == null)
            {
                ShowPopupMessage("Error", "PLC and Protocol mismatch");
                return;
            }

            if (!ConnectionPlcValidation(txtIP.Text, txtPort.Text, out Tuple<string, string, int> data))
            {
                ShowPopupMessage("Error", $"\n{data.Item1}");
                return;
            }

            _PLC.IPAddress = data.Item2;
            _PLC.PortNumber = data.Item3;
            _PLC.IsUdp = rdoUDP.Checked;
            _PLC.IsAscii = rdoASCII.Checked;

            plcStatus.Text = "Connecting...";
            plcStatus.BackColor = SystemColors.AppWorkspace;
            int ret = _PLC.Open();
            if (ret != PLCComm.RET_COMPLETED)
            {
                plcStatus.Text = "Failed";
                plcStatus.BackColor = Color.Red;
                _plcConnectionStatus = false;
                return;
            }

            _plcConnectionStatus = true;
            plcStatus.Text = "Connected";
            plcStatus.BackColor = Color.Lime;
            plcBtnDisconnect.Enabled = true;
            plcBtnConnect.Enabled = false;
            grpReadRslt.Enabled = true;
            grpRead.Enabled = true;
            grpWrite.Enabled = true;
        }

        private void PlcDisconnect()
        {
            if (_PLC == null) return;

            _PLC.Close();
            _PLC = null;

            _plcConnectionStatus = false;
            plcStatus.Text = "Disconnected";
            plcStatus.BackColor = SystemColors.AppWorkspace;

            plcBtnDisconnect.Enabled = false;
            plcBtnConnect.Enabled = true;
            grpReadRslt.Enabled = false;
            grpRead.Enabled = false;
            grpWrite.Enabled = false;
        }

        private (string?, int) AddressCheck(string addressParam, string sizeParam = "1")
        {
            if (!_plcConnectionStatus || _PLC == null)
            {
                ShowPopupMessage("Error", "Read PLC Address Failed");
                return (null, 0);
            }

            string address = _PLC.RemakeDevice(addressParam, 0);
            if (string.IsNullOrEmpty(address) || !_PLC.IsWordAvailable(address))
            {
                ShowPopupMessage("Error", "Address Invalid");
                return (null, 0);
            }

            if (!int.TryParse(sizeParam, out int size)) return (null, 0);
            if (size < 1) return (null, 0);
            return (address, size);
        }

        private bool ReadAddress()
        {
            (string? address, int size) = AddressCheck(txtReadDeviceAddress.Text, txtSizeRead.Text);
            if (address == null || size == 0) return false;

            short[] data = new short[size];
            int readResult = _PLC!.ReadDeviceBlock(address, size, ref data);
            if (readResult != PLCComm.RET_COMPLETED)
            {
                ShowPopupMessage("Error", "Read Address Error");
                return false;
            };

            StringBuilder stringBuilder = new(2048);
            stringBuilder.AppendLine(address + ", " + size.ToString());
            stringBuilder.AppendLine("Read Time = " + _PLC.GetLastProcessingTime().ToString() + "ms");
            for (int i = 0; i < data.Length; i++)
            {
                stringBuilder.AppendLine(i.ToString() + " = " + data[i].ToString());

            }
            stringBuilder.AppendLine("Read Address Completed...");
            txtReadResult.Text = stringBuilder.ToString();
            return true;
        }

        private void ReadAddressPulseEvent(Object? source, System.Timers.ElapsedEventArgs e)
        {
            if(!ReadAddress())
            {
                _pulseRead.Stop();
                return;
            }
        }

        private void WriteAddress()
        {
            (string? address, int size) = AddressCheck(txtWriteDeviceAddress.Text, txtSizeWrite.Text);
            if (address == null || size == 0) return;

            if (!short.TryParse(txtDataToWrite.Text, out short dataWrite))
            {
                ShowPopupMessage("Error", "Data Invalid");
                return;
            };

            short[] data = new short[size];
            for (int i = 0; i < size; i++)
            {
                data[i] = dataWrite;
            }

            int writeResult = _PLC!.WriteDeviceBlock(address, size, ref data);
            if (writeResult != PLCComm.RET_COMPLETED)
            {
                ShowPopupMessage("Error", "Write Address Failed");
                return;
            };
            MessageBox.Show("Write Address Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Button Actions
        private void PlcBtnConnectOnClick(object sender, EventArgs e)
        {
            PlcConnect();
        }

        private void PlcBtnDisconnectOnClick(object sender, EventArgs e)
        {
            PlcDisconnect();
        }

        private void BtnReadOnClick(object sender, EventArgs e)
        {
            ReadAddress();
        }

        private void BtnReadPulseOnClick(object sender, EventArgs e)
        {
            _pulseRead.Start();
        }

        private void BtnStopReadOnClick(object sender, EventArgs e)
        {
            _pulseRead.Stop();
        }

        private void BtnStartWriteOnClick(object sender, EventArgs e)
        {
            WriteAddress();
        }
    }
}
