using System.Windows;
using System.Windows.Controls;

namespace WpfTest;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        Button1.Click += Button1_Click;
        Button2.Click += Button2_Click;
        Button3.Click += Button3_Click;
    }

    /// <summary>
    /// Logs a message to the LogTextBox with a timestamp and optionally disables/enables a button.
    /// </summary>
    /// <param name="txt">The text message to log.</param>
    /// <param name="sender">The sender object, typically a Button, which will be disabled and then re-enabled after the delay.</param>
    /// <param name="delay">The delay in milliseconds before re-enabling the button. Default is 100 milliseconds.</param>
    /// <returns>A Task representing the asynchronous operation.</returns>
    private async Task Log(string txt, object? sender = null, int delay = 100)
    {
        if (sender!=null && sender is Button buttonStart)
            buttonStart.IsEnabled = false;
        LogTextBox.Text = $"{DateTime.Now:HH:mm:ss.fff} - {txt}\r\n" + LogTextBox.Text;
        await Task.Delay(delay);
        if (sender!=null && sender is Button buttonExit)
            buttonExit.IsEnabled = true;
    }

    private async void Button1_Click(object sender, RoutedEventArgs e)
    {
        await Log("Button 1 clicked", sender, 1000);
    }

    private async void Button2_Click(object sender, RoutedEventArgs e)
    {
        await Log("Button 2 clicked", sender, 1000);
    }

    private async void Button3_Click(object sender, RoutedEventArgs e)
    {
        await Log("Button 3 clicked", sender, 1000);
    }

}
