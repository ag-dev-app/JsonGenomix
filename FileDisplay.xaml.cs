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
using JsonGenomix.JsonFile;
using Newtonsoft.Json.Linq;
using static JsonGenomix.JsonFile.all;

namespace JsonGenomix
{
    /// <summary>
    /// Logique d'interaction pour FileDisplay.xaml
    /// </summary>
    public partial class FileDisplay : Window
    {
        File _file;
        public JsonFieldsCollector JsonCollector { get; set; }


        public FileDisplay(File file)
        {
            InitializeComponent();
            _file = file;
            LblName.Text = file.Path;
            JsonCollector = new JsonFieldsCollector(_file.Path);
        }

        //public all CreateJsonObj(string file)
        //{
        //    all objAll = new all(file);
        //    return objAll;
        //}

        private void DisplayValue(object sender, MouseButtonEventArgs e)
        {
            string selected = (string)ListeViewKeys.SelectedItem;
            string displayDatas = JsonCollector.DisplayDatas(selected);
            Content.Text = displayDatas;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {

            JsonCollector.SetFieldsKeys(_file.JsonString);

            ListeViewKeys.ItemsSource = JsonCollector.GetFieldsKeys();

        }

    }
}
