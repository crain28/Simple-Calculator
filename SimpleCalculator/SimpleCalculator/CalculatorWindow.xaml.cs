using SimpleCalculator;
using System;
using System.Windows;

namespace SimpleCalculator
{
    /// <summary>
    /// Interaction logic for CalculatorWindow.xaml
    /// </summary>
    public partial class CalculatorWindow : Window
    {
        public CalculatorWindow()
        {
            InitializeComponent();
        }

        #region Buttons

        /// <summary>
        /// Sets behavior of Clear Button when clicked
        /// </summary>
      private void Button_Click_Clear(object sender, RoutedEventArgs e)
        {
            Height.Text = "";
            Weight.Text = "";
            RadioInch.IsChecked = true;
            RadioCm.IsChecked = false;
            RadioLbs.IsChecked = true;
            RadioKg.IsChecked = false;
            HeightLabel.Content = "(Inches)";
            WeightLabel.Content = "(lbs)";
        }

        /// <summary>
        /// Sets behavior of Help Button when clicked
        /// </summary>
       private void Button_Click_Help(object sender, RoutedEventArgs e)
        {
            HelpWindow modalHelpWindow = new HelpWindow();

            modalHelpWindow.ShowDialog();
        }

        /// <summary>
        /// Sets behavior of Exit Button when clicked
        /// </summary>
        private void Button_Click_Exit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        #endregion

        #region TextBox's

        /// <summary>
        /// Sets behavior of Height Text Box when changed
        /// </summary>
         private void TextBox_TextChanged_Height(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            bool validHeight = IsValidDouble(Height.Text);
            if (validHeight || Height.Text == "")
            {
                HeightError.Text = "";
                RadioInch.IsEnabled = true;
                RadioCm.IsEnabled = true;
            }
            else
            {
                HeightError.Text = "Please enter only numbers";
                RadioInch.IsEnabled = false;
                RadioCm.IsEnabled = false;
            }
        }

        /// <summary>
        /// Sets behavior of Weight Text Box when changed
        /// </summary>
        private void TextBox_TextChanged_Weight(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            bool validWeight = IsValidDouble(Weight.Text);
            if (validWeight || Weight.Text == "")
            {
                WeightError.Text = "";
                RadioLbs.IsEnabled = true;
                RadioKg.IsEnabled = true;
            }
            else
            {
                WeightError.Text = "Please enter only numbers";
                RadioLbs.IsEnabled = false;
                RadioKg.IsEnabled = false;
            }
        }

        #endregion

        #region RadioButtons

        /// <summary>
        /// Sets behavior for Inch Radio Button when checked
        /// </summary>
      private void RadioInch_Checked(object sender, RoutedEventArgs e)
        {
            if (Height.Text == "")
            {

            }
            else
            {
                double.TryParse(Height.Text, out double height);
                double result = height / 2.54;
                Height.Text = Convert.ToString(result);
                HeightLabel.Content = "(Inches)";
            }
        }

        /// <summary>
        /// Sets behavior for cm Radio Button when checked
        /// </summary>
        private void RadioCm_Checked(object sender, RoutedEventArgs e)
        {
            double.TryParse(Height.Text, out double height);
            double result = height * 2.54;
            Height.Text = Convert.ToString(result);
            HeightLabel.Content = "(Cm)";
        }

        /// <summary>
        /// Sets behavior for Lbs Radio Button when checked
        /// </summary>
        private void RadioLbs_Checked(object sender, RoutedEventArgs e)
        {
            if (Weight.Text == "")
            {

            }
            else
            {
                double.TryParse(Weight.Text, out double weight);
                double result = weight * 2.205;
                Weight.Text = Convert.ToString(result);
                WeightLabel.Content = "(lbs)";
            }
        }

        /// <summary>
        /// Sets behavior for Kg Radio Button when checked
        /// </summary>
       private void RadioKg_Checked(object sender, RoutedEventArgs e)
        {
            double.TryParse(Weight.Text, out double weight);
            double result = weight / 2.205;
            Weight.Text = Convert.ToString(result);
            WeightLabel.Content = "(Kg)";
        }
        #endregion

        /// <summary>
        /// Validation Method for User Input
        /// </summary>
        private bool IsValidDouble(string userResult)
        {
            bool isValid = double.TryParse(userResult, out double validHeight);
            return isValid;
        }
    }
}
