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

namespace CharacterSheetApp.Sections.Components
{
    /// <summary>
    /// Interaction logic for InvertedCornersHeader.xaml
    /// </summary>
    public partial class InvertedCornersHeader : UserControl
    {
        public static readonly DependencyProperty HeaderProperty = DependencyProperty.Register("HeaderText", typeof(string), typeof(InvertedCornersHeader));
        public string HeaderText
        {
            get => GetValue(HeaderProperty) as string;
            set => SetValue(HeaderProperty, value);
        }
        public InvertedCornersHeader()
        {
            InitializeComponent();
        }
    }
}
