using StandartLibrary;
using System.Windows;

namespace WpfFramework
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Hello, {textbox.Text}");

            var message = LibraryClass.AddDateTimeNowToPhrase(textbox.Text);
            MessageBox.Show(message);
        }
    }
}
