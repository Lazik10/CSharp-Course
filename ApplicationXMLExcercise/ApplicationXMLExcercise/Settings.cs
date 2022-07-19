using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationXMLExcercise
{
    internal class Settings
    {
        public DateTime LastRunDate { get; private set; }
        public bool RunOnStartup { get; private set; }
        public string ApplicationPath { get; private set; }
        public string DocumentsPath { get; private set; }
        public string Message { get; private set; }

        public Settings(DateTime lastRunDate, bool runOnStartup, string appPath, string documentsPath, string message)
        {
            LastRunDate = DateTime.Now;
            RunOnStartup = runOnStartup;
            ApplicationPath = appPath;
            DocumentsPath = documentsPath;
            Message = message;
        }
    }
}
