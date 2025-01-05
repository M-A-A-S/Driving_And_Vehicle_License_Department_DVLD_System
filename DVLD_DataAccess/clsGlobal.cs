using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsGlobal
    {
        public static void LogToEventLog(string LogMessage)
        {
            string SourceName = "DVLD";

            if (!EventLog.Exists(SourceName))
            {
                EventLog.CreateEventSource(SourceName, "Application");
            }

            EventLog.WriteEntry(SourceName, LogMessage, EventLogEntryType.Error);
        }
    }
}
