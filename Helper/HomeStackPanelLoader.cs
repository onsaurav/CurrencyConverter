using CurrencyConverter.Control;
using CurrencyConverterModel.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CurrencyConverter.Helper
{
    public class HomeStackPanelLoader : StackPanelLoadHelper
    {
        private StackPanel stackPanel;

        public HomeStackPanelLoader(StackPanel panel) : base(panel)
        {
            this.stackPanel = panel;
        }

        public override void LoadControlByTag(string tag)
        {
            base.ClearStackPanel();
            if (tag == Constant.CONVERT_CONTROL_TAG)
                stackPanel.Children.Add(new ucConverter());
            else if (tag == Constant.INFORMATION_CONTROL_TAG)
                stackPanel.Children.Add(new ucInformation());
        }
    }
}
