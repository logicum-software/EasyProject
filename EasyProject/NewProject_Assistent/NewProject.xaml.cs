using System.Windows;

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
            buttonNext.IsEnabled = false;
            tmpProject = new Project();
            tmpProject.Name = textBoxName.Text;

            label1.Content = "Bitte geben Sie eine Projektbeschreibung ein:";
            textBoxName.Text = "Bitte Projektbeschreibung eingeben...";
            textBoxName.SelectAll();
            textBoxName.Focus();
        }

        private void TextBoxName_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (IsInitialized)
                buttonNext.IsEnabled = true;
        }
    }
}
