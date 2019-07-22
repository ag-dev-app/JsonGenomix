using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JsonGenomix
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<File> files;

        public MainWindow()
        {
            InitializeComponent();
            files = new ObservableCollection<File>();
            ListeViewFiles.ItemsSource = files;
        }

        private void SelectJson_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Filter = "Json files(*.json)|*.json|All files(*.*)|*.*";
            if (fileDialog.ShowDialog() == true)
            {
                foreach (string name in fileDialog.FileNames)
                {
                    files.Add(new File(name));
                }

            }
        }
        private void RemoveFileListe(object sender, RoutedEventArgs e)
        {
            File selected = (File)ListeViewFiles.SelectedItem;
            files.Remove(selected);
        }

        private void DisplayContent(object sender, MouseButtonEventArgs e)
        {
            File selected = (File)ListeViewFiles.SelectedItem;
            FileDisplay fileDisplay = new FileDisplay(selected);
            fileDisplay.Show();
        }
    }
}
