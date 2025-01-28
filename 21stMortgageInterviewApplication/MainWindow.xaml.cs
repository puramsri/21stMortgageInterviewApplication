using System;
using System.Linq;
using System.Windows;

namespace _21stMortgageInterviewApplication
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Find_Largest_Value(object sender, RoutedEventArgs e)
        {
            try
            {
                var input = UserInputTextBox.Text;

                var numbers = input.Split(',').Select(int.Parse);

                int largestNumber = numbers.Max();

                ResultTextBox.Text = $"Largest Value: {largestNumber}";

                ResultTextBox.Foreground = largestNumber >= 0
                    ? System.Windows.Media.Brushes.Green
                    : System.Windows.Media.Brushes.Red;
                ResultTextBox.FontSize = 16;
                ResultTextBox.FontFamily = new System.Windows.Media.FontFamily("Arial");
            }
            catch (Exception ex)
            {
                ResultTextBox.Text = "Invalid input! Please enter valid comma-separated numbers.";
                ResultTextBox.Foreground = System.Windows.Media.Brushes.Red;
            }
        }

        private void Find_Total_Even_numbers(object sender, RoutedEventArgs e)
        {
            try
            {
                var input = UserInputTextBox.Text;

                var numbers = input.Split(',').Select(int.Parse);

                int evenSum = numbers.Where(n => n % 2 == 0).Sum();

                ResultTextBox.Text = $"Total of Even Numbers: {evenSum}";

                ResultTextBox.Foreground = evenSum >= 0
                    ? System.Windows.Media.Brushes.Green
                    : System.Windows.Media.Brushes.Red;
                ResultTextBox.FontSize = 16;
                ResultTextBox.FontFamily = new System.Windows.Media.FontFamily("Arial");
            }
            catch (Exception ex)
            {
                ResultTextBox.Text = "Invalid input! Please enter valid comma-separated numbers.";
                ResultTextBox.Foreground = System.Windows.Media.Brushes.Red;
            }
        }

        private void Find_Total_Odd_numbers(object sender, RoutedEventArgs e)
        {
            try
            {
                var input = UserInputTextBox.Text;

                var numbers = input.Split(',').Select(int.Parse);

                int oddSum = numbers.Where(n => n % 2 != 0).Sum();

                ResultTextBox.Text = $"Total of Odd Numbers: {oddSum}";

                ResultTextBox.Foreground = oddSum >= 0
                    ? System.Windows.Media.Brushes.Green
                    : System.Windows.Media.Brushes.Red;
                ResultTextBox.FontSize = 16;
                ResultTextBox.FontFamily = new System.Windows.Media.FontFamily("Arial");
            }
            catch (Exception ex)
            {
                ResultTextBox.Text = "Invalid input! Please enter valid comma-separated numbers.";
                ResultTextBox.Foreground = System.Windows.Media.Brushes.Red;
            }
        }

    }
}
