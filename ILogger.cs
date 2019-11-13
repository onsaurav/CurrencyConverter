using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    public interface ILogger
    {
        void Information(string message);
        void Information(Exception ex);
        void Error(string message);
        void Error(Exception ex);
        void Warning(string message);
        void Warning(Exception ex);
    }
}
