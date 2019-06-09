using System.Diagnostics;
using System.ServiceProcess;
using WindowsServiceAgent.Application;

namespace WindowsServiceAgent
{
    public partial class MyNewService : ServiceBase
    {
        public MyNewService()
        {
            InitializeComponent();
            eventLog1 = new EventLog();
            
            eventLog1.Source = "MyNewService";            
        }

        protected override void OnStart(string[] args)
        {
            eventLog1.WriteEntry("Your new my service is in OnStart.", EventLogEntryType.Information, 101, 1);

            RunCommand.TestCommand();
        }

        protected override void OnStop()
        {
        }
    }
}
