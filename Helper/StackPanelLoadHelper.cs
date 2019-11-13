using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CurrencyConverter.Helper
{     
    public abstract class StackPanelLoadHelper
    {
        private StackPanel stkMain;

        protected StackPanelLoadHelper(StackPanel stkMain)
        {
            this.stkMain = stkMain;
        }
        protected void ClearStackPanel()
        {
            this.stkMain.Children.Clear();
        }
        public abstract void LoadControlByTag(string tag);
    }
}
