using System.Diagnostics;

namespace WindowsServiceAgent.Application
{
    public static class RunCommand
    {
        public static void TestCommand()
        {
            var processInfo = new ProcessStartInfo
            {
                WindowStyle = ProcessWindowStyle.Normal,
                CreateNoWindow = true, //Start cmd without creating a window:
                UseShellExecute = false,
                FileName = "CMD.exe",
                Arguments = @"/C c:\temp\test.bat"
            };

            var process = Process.Start(processInfo);
        }

    }
}
