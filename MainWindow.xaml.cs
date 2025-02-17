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
using System.Net.Http;
using System.Threading.Tasks;

namespace WpfTest;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private static readonly HttpClient client = new HttpClient();

    public MainWindow()
    {
        InitializeComponent();
        Button1.Click += Button1_Click;
        Button2.Click += Button2_Click;
        Button3.Click += Button3_Click;
    }

    private async void Button1_Click(object sender, RoutedEventArgs e)
    {
        await Task.Delay(100);
    }


    private async void Button2_Click(object sender, RoutedEventArgs e)
    {
        await Task.Delay(100);
    }

    private async void Button3_Click(object sender, RoutedEventArgs e)
    {
        await Task.Delay(100);

    }
}