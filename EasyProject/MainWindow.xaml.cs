using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows;

namespace EasyProject
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private AppData appData { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            appData = new AppData();

            //Daten einlesen aus Datei "udata.dat"
            IFormatter formatter = new BinaryFormatter();
            try
            {
                Stream stream = new FileStream("udata.dat", FileMode.Open, FileAccess.Read, FileShare.Read);
                appData = (AppData)formatter.Deserialize(stream);
                stream.Close();
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show(e.Message, "Dateifehler", MessageBoxButton.OK);
                //throw;
            }
            //listBoxProjects.ItemsSource = appData
        }
    }
}
