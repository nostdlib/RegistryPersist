# RegistryPersist

.NET Framework 2.0 library that adds a registry Run key for persistence. On load, it retrieves the device UUID via WMI and writes a `HKCU\Software\Microsoft\Windows\CurrentVersion\Run` entry using the UUID as the key name.

## Project Structure

- `Program.cs` - Entry point, executes via static constructor
- `DeviceInfo.cs` - Retrieves device UUID from WMI (`Win32_ComputerSystemProduct`)
- `RegistryHelper.cs` - Writes to the registry Run key

## Build

Requires .NET Framework MSBuild (`C:\Windows\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe`).

```
msbuild RegistryPersist.csproj /p:Configuration=Release /p:Platform=AnyCPU
```

Available platforms: `AnyCPU`, `x86`, `x64`

A post-build step outputs a base64-encoded copy of the DLL to `bin\<config>\RegistryPersist.b64.txt`.

## VS Code

Build tasks are preconfigured. Press `Ctrl+Shift+B` to build (Debug|AnyCPU by default). Run **Terminal > Run Task** to see all configurations.
