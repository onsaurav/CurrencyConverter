using CurrencyConverterModel.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    public class Logger: ILogger
    {
        public void Information(string message)
        {
            Write(message, EventLogEntryType.Information);
        }

        public void Information(Exception ex)
        {
            Write(ex.Message, EventLogEntryType.Information);
        }

        public void Error(string message)
        {
            Write(message, EventLogEntryType.Error);
        }

        public void Error(Exception ex)
        {
            Write(ex.Message, EventLogEntryType.Error);
        }

        public void Warning(string message)
        {
            Write(message, EventLogEntryType.Warning);
        }

        public void Warning(Exception ex)
        {
            Write(ex.Message, EventLogEntryType.Warning);
        }

        private void Write(string message, EventLogEntryType eventLogEntryType)
        {
            using (EventLog eventLog = new EventLog(Constant.LOG_LEVEL))
            {
                eventLog.Source = Constant.LOG_LEVEL;
                eventLog.WriteEntry(message, eventLogEntryType);
            }
        }
    }
}
