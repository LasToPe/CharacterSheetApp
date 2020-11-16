using CharacterSheetApp.Pages;
using System.Windows;

namespace CharacterSheetApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainContent.Navigate(new Pathfinder1e());
        }

        private void Pathfinder1e_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Navigate(new Pathfinder1e());
        }

        private void DnD5e_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Navigate(new DnD5e());
        }
    }
}
