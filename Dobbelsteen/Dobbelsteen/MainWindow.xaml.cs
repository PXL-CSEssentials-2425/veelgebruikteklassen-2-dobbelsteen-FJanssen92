using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Dobbelsteen
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

        Random diceThrow = new Random();

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void startButton_Click(object sender, RoutedEventArgs e)
        {

            int newThrow = diceThrow.Next(1, 7);
            int i = 1;
            StringBuilder sb = new StringBuilder();

            for (i = 1; newThrow != 6; i++)
            {
                sb.AppendLine("Worp " + i + " Geeft " + newThrow);
                newThrow = diceThrow.Next(1, 7);

            }

            resultTextBox.Text = sb.ToString();
            if (newThrow == 6)
            {
                sb.AppendLine($"Worp {i} geeft {newThrow}! Gefeliciteerd!");
                resultTextBox.Text = sb.ToString() ;
            }


        }

            private void newButton_Click(object sender, RoutedEventArgs e)
            {
                resultTextBox.Clear();
                startButton.Focus();
            }
        }
    }
