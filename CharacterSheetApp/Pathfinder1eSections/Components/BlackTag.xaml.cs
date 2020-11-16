using System;
using System.Collections.Generic;
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

namespace CharacterSheetApp.Pathfinder1eSections.Components
{
    /// <summary>
    /// Interaction logic for BlackTag.xaml
    /// </summary>
    public partial class BlackTag : UserControl
    {
        public static readonly DependencyProperty AbbreviationProperty = DependencyProperty.Register(nameof(Abbreviation), typeof(string), typeof(BlackTag));
        public string Abbreviation
        {
            get => GetValue(AbbreviationProperty) as string;
            set => SetValue(AbbreviationProperty, value);
        }
        public static readonly DependencyProperty FullNameProperty = DependencyProperty.Register(nameof(FullName), typeof(string), typeof(BlackTag));
        public string FullName
        {
            get => GetValue(FullNameProperty) as string;
            set => SetValue(FullNameProperty, value);
        }
        public BlackTag()
        {
            InitializeComponent();
        }
    }
}
