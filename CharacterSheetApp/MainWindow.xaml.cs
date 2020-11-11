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
            MainContent.Navigate(new Sheet1e());
        }
    }
}
