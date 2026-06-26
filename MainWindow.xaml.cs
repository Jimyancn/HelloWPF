using System.Security.Cryptography.Xml;
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

namespace HelloWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var i = 0; 
            i = i + 1;
            i++;
            var j = 0;
            j = i * 12;
            T1.Text = j.ToString(); 
            T2.Text = "Test ok";
        }
    }
}