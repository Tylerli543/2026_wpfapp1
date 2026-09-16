using System.Windows;
using System.Windows.Controls;

namespace _2026_wpfapp1
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            okButton_Click(sender, e);
        }

       
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            computeButton_Click(sender, e);
        }

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            string name = nameTextBox.Text;
            string telphone = phone1.Text;
            string message = $"Name: {name}\nTelphone: {telphone}";
            MessageBox.Show(message, "我的資訊", MessageBoxButton.OK);
        }

        private void computeButton_Click(object sender, RoutedEventArgs e)
        {
            int n = int.Parse(輸入一個數1.Text);

            string result = "";
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                    result += $"{i}*{j}={i * j}\t\t";
                result += "\n";
            }
            ans1.Text = result;
        }
    }
}