using CurrencyConverterModel.Common;
using CurrencyConverterServiveWrapper.CurrencyConverterServiceClient;
using CurrencyConverterServiveWrapper.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Text.RegularExpressions;
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

namespace CurrencyConverter.Control
{
    /// <summary>
    /// Interaction logic for ucConverter.xaml
    /// </summary>
    public partial class ucConverter : UserControl
    {
        ILogger logger;
        public ucConverter()
        {
            InitializeComponent();

            logger = new Logger();
        }

        private void BtnConvert_Click(object sender, RoutedEventArgs e)
        {
            IConverterServiceWrapper converterService = new ConverterServiceWrapper();
            string convertedNumberInWord = string.Empty;
            try
            {
                if (IsValidInput(txtCurrency.Text))
                    convertedNumberInWord = converterService.ConvertCurrencyIntoWord(txtCurrency.Text);
                else
                    MessageBox.Show(Constant.INVALID_INPUT_MSG, "Invalid Input", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            catch (TimeoutException ex)
            {
                logger.Error(ex);
                convertedNumberInWord = Constant.ERROR_TIMEOUT_FAILED;
            }
            catch (FaultException ex)
            {
                logger.Error(ex);
                convertedNumberInWord = Constant.ERROR_FETAL_FAILED;
            }
            catch (CommunicationException ex)
            {
                logger.Error(ex);
                convertedNumberInWord = Constant.ERROR_COMMUNICATION_FAILED;
            }            
            catch (Exception ex)
            {
                logger.Error(ex);
                convertedNumberInWord = Constant.ERROR_CONVERSION_FAILED;
            }
            finally
            {
                txtResult.Text = convertedNumberInWord;
            }
        }

        private bool IsValidInput(string text)
        {
            double number = 0;

            if (string.IsNullOrEmpty(text)) return false;

            text = text.Trim();

            if (double.TryParse(text, out number) == false)
                return false;

            if (Math.Floor(number) > 999999999)
                return false;

            if (text.Contains(","))
            {
                string[] parts = text.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);

                if (double.TryParse(parts[parts.Length - 1], out number) == false)
                    return false;

                if (Math.Floor(number) > 99)
                    return false;
            }

            return true;
        }
        
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9,-]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
