using CurrencyConverter.Control;
using CurrencyConverter.CurrencyConverterService;
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
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ImgClose_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ExitApplication();
        }

        private static void ExitApplication()
        {
            if (MessageBox.Show("Do you want to close this application?", "Exit Application", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                Application.Current.Shutdown();
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            ExitApplication();
        }

        private void BtnInformation_Click(object sender, RoutedEventArgs e)
        {
            LoadControl("Information");
        }

        private void LoadControl(string tag)
        {
            stkMain.Children.Clear();

            if (tag == "Convert")
                stkMain.Children.Add(new ucConverter());
            else if(tag == "Information")
                stkMain.Children.Add(new ucInformation());
        }

        private void BtnConvert_Click(object sender, RoutedEventArgs e)
        {
            LoadControl("Convert");
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadControl("Convert");
        }
    }
}
