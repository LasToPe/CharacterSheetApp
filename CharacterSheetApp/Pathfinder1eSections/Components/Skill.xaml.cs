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
    /// Interaction logic for Skill.xaml
    /// </summary>
    public partial class Skill : UserControl
    {
        public static readonly DependencyProperty SkillNameProperty = DependencyProperty.Register("SkillName", typeof(string), typeof(Skill));
        public string SkillName
        {
            get => GetValue(SkillNameProperty) as string;
            set => SetValue(SkillNameProperty, value);
        }
        public static readonly DependencyProperty AbilityProperty = DependencyProperty.Register("Ability", typeof(string), typeof(Skill));
        public string Ability
        {
            get => GetValue(AbilityProperty) as string;
            set => SetValue(AbilityProperty, value);
        }
        public Skill()
        {
            InitializeComponent();
        }
    }
}
