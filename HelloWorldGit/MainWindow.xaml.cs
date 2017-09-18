using System.Windows;

namespace HelloWorldGit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btnClickMe.Click += BtnClickMe_Click;
        }

        private void BtnClickMe_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello World!");
        }
    }
}
