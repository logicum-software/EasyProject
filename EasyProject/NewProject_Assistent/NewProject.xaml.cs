using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace EasyProject.NewProject_Assistent
{
    /// <summary>
    /// Interaktionslogik für NewProject.xaml
    /// </summary>
    public partial class NewProject : Window
    {
        private Project tmpProject;
        public NewProject()
        {
            InitializeComponent();

            textBoxName.SelectAll();
            textBoxName.Focus();
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Möchten Sie die Projekterstellung abbrechen?",
                "Abbrechen", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                Close();
            else
            {
                textBoxName.SelectAll();
                textBoxName.Focus();
            }
        }

        private void ButtonNext_Click(object sender, RoutedEventArgs e)
        {
            tmpProject = new Project();
            tmpProject.Name = textBoxName.Text;
        }
    }
}
