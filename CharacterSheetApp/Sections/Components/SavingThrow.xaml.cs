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
    /// Interaction logic for SavingThrow.xaml
    /// </summary>
    public partial class SavingThrow : UserControl
    {
        public static readonly DependencyProperty SaveNameProperty = DependencyProperty.Register(nameof(SaveName), typeof(string), typeof(SavingThrow));
        public string SaveName
        {
            get => GetValue(SaveNameProperty) as string;
            set => SetValue(SaveNameProperty, value);
        }
        public static readonly DependencyProperty SaveAbilityProperty = DependencyProperty.Register(nameof(SaveAbility), typeof(string), typeof(SavingThrow));
        public string SaveAbility
        {
            get => GetValue(SaveAbilityProperty) as string;
            set => SetValue(SaveAbilityProperty, value);
        }

        public SavingThrow()
        {
            InitializeComponent();
        }
    }
}
