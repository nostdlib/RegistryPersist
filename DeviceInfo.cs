using System;
using System.Management;

public static class DeviceInfo
{
    public static string GetUUID()
    {
        ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT UUID FROM Win32_ComputerSystemProduct");

        foreach (ManagementObject obj in searcher.Get())
        {
            if (obj["UUID"] != null)
            {
                return new Guid(obj["UUID"].ToString().Trim()).ToString("N");
            }
        }

        return Guid.Empty.ToString("N");
    }
}
