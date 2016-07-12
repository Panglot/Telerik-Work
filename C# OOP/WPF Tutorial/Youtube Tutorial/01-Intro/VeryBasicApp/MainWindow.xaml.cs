namespace VeryBasicApp
{
    using System.Windows;
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }


        private void DemoButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello The button was clicked", "Caption for the box");
        }

        private void DemoButton2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The second button was clicked", "Reduce dulness");
        }
        private void BaseClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The base executes", "Aaand another caption");
        }
    }
}
