using CurrencyConverter.Control;
using CurrencyConverter.Helper;
using CurrencyConverterModel.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CurrencyConverter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Home : Window
    {
        private StackPanelLoadHelper stackPanelLoadHelper;

        public Home()
        {
            InitializeComponent();
            stackPanelLoadHelper = new HomeStackPanelLoader(stkMain);
        }

        private void ImgClose_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ExitApplication();
        }

        private static void ExitApplication()
        {
            if (MessageBox.Show(Constant.APP_CLOSE_MSG, "Exit Application", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                Application.Current.Shutdown();
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            ExitApplication();
        }

        private void BtnInformation_Click(object sender, RoutedEventArgs e)
        {
            LoadControl(Constant.INFORMATION_CONTROL_TAG);
        }

        private void LoadControl(string tag)
        {
            stackPanelLoadHelper.LoadControlByTag(tag);
        }

        private void BtnConvert_Click(object sender, RoutedEventArgs e)
        {
            LoadControl(Constant.CONVERT_CONTROL_TAG);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadControl(Constant.CONVERT_CONTROL_TAG);
        }
    }
}
