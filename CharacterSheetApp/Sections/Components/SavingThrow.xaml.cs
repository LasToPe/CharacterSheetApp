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
        private string _saveName;
        public string SaveName
        {
            get { return _saveName; }
            set
            {
                Tag.Abbreviation = value;
                _saveName = value;
            }
        }
        private string _saveAbility;
        public string SaveAbility
        {
            get { return _saveAbility; }
            set
            {
                Tag.FullName = value;
                _saveAbility = value;
            }
        }

        public SavingThrow()
        {
            InitializeComponent();
        }
    }
}
