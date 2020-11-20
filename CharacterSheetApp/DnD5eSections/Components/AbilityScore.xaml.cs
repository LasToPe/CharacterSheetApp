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

namespace CharacterSheetApp.DnD5eSections.Components
{
    /// <summary>
    /// Interaction logic for AbilityScore.xaml
    /// </summary>
    public partial class AbilityScore : UserControl
    {
        public static readonly DependencyProperty AbilityNameProperty = DependencyProperty.Register(nameof(AbilityName), typeof(string), typeof(AbilityScore));
        public string AbilityName { get => GetValue(AbilityNameProperty) as string; set => SetValue(AbilityNameProperty, value); }

        public AbilityScore()
        {
            InitializeComponent();
        }
    }
}
