# 📦 OmroLink

A simple C# Windows Forms application for monitoring and communicating with PLCs.

---

## 📑 Project Info

- **Platform:** .NET 8.0 (Windows only)
- **Target Framework:** `net8.0-windows`
- **Architecture:** `x86`
- **Build Tool:** MSBuild 17.14.5
- **UI Framework:** Windows Forms
- **Language:** C#
- **IDE Support:** Visual Studio 2022 / Visual Studio Code

---

## 🛠️ Getting Started

### Prerequisites

#### Using Visual Studio 2022

- [✅] .NET SDK 8.0 or newer
- [✅] Windows OS

#### Using Visual Studio Code
- [✅] .NET SDK 8.0 or newer
- [✅] Windows OS
- [✅] Required Extension VS code `.NET Install Tool` , `C#` and `C# Dev Kit`


### Clone & Build

If you using Visual Studio Code for run project following this step:

- Clone project
```bash
git clone https://github.com/just4wann/OmroLink.git
cd project-name
```

- In `.csproj` add this line
```bash
<PropertyGroup>
    <PlatformTarget>x86</PlatformTarget>
</PropertyGroup>
```
- Then run project
```bash
dotnet build
dotnet run
```