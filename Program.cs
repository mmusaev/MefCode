using System.ServiceProcess;

public static class Program
{
    public static void Main()
    {
        ServiceBase[] ServicesToRun;
        ServicesToRun = new ServiceBase[]
        {
            new MyWindowsService()
        };
        ServiceBase.Run(ServicesToRun);
    }
}