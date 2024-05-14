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

namespace PassWordGen
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

        private void GenerateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (charCantComboBox.Text == "")
                {
                    MessageBox.Show("Ingrese la cantidad de caracteres");
                    passwordLabel.Text = "##############";
                }
                else
                {
                    passwordLabel.Text = "";
                    Random random = new Random();
                    string password = string.Empty;
                    int asciiNumber = 0;
                    short n = Convert.ToInt16(charCantComboBox.Text);
                    for (int i = 0; i < n; i++)
                    {
                        asciiNumber = random.Next(48, 126);
                        char asciiChar = (char)asciiNumber;
                        password += asciiChar;
                    }
                    passwordLabel.Text = password;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show($"ERR: {x.Message}");
                
            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}