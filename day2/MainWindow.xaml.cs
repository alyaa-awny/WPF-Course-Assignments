using System.Windows;
using System.Windows.Controls;

namespace day2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// private Operator currentOperator;  

    public partial class MainWindow : Window
    {
        double firstNumber;
        double secondNumber;
        string ope;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            Result.Text += btn.Content.ToString();
            secondNumber = int.Parse(Result.Text);

        }


        private void Button_Click_Multip(object sender, RoutedEventArgs e)
        {
            firstNumber = int.Parse(Result.Text);
            ope = "*";
            Result.Clear();
        }

        private void Button_Click_Miuns(object sender, RoutedEventArgs e)
        {
            firstNumber = int.Parse(Result.Text);
            ope = "-";
            Result.Clear();

        }



        private void Button_Click_Devision(object sender, RoutedEventArgs e)
        {
            firstNumber = int.Parse(Result.Text);
            ope = "/";
            Result.Clear();
        }


        private void Button_Click_Dot(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_Plus(object sender, RoutedEventArgs e)
        {
            firstNumber = int.Parse(Result.Text);
            ope = "+";
            Result.Clear();
        }

        private void Button_Click_Equal(object sender, RoutedEventArgs e)
        {
            secondNumber = int.Parse(Result.Text);
            double result = 0;
            switch (ope)
            {
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    result = firstNumber / secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "+":
                    result = firstNumber + secondNumber;
                    break;
            }
            Result.Text = result.ToString();

        }

        private void Button_Click_Clear(object sender, RoutedEventArgs e)
        {
            Result.Clear();
        }
    }
}
