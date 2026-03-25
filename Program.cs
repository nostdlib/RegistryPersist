public class Program
{
    static Program()
    {
        Main();
    }

    static void Main()
    {
        string deviceId = DeviceInfo.GetUUID();
        RegistryHelper.SetRunKey(deviceId, "%CommandLine%");
    }
}
