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
    /// Interaction logic for AbilityScore.xaml
    /// </summary>
    public partial class AbilityScore : UserControl
    {
        private string _abbreviation;
        public string Abbreviation
        {
            get { return _abbreviation; }
            set
            {
                _abbreviation = value;
                Tag.Abbreviation = _abbreviation;
            }
        }
        private string _fullName;
        public string FullName
        {
            get { return _fullName; }
            set
            {
                _fullName = value;
                Tag.FullName = _fullName;
            }
        }
        public AbilityScore()
        {
            InitializeComponent();
        }
    }
}
