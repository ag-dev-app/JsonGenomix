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

namespace JsonGenomix
{
    /// <summary>
    /// Logique d'interaction pour FileDisplay.xaml
    /// </summary>
    public partial class FileDisplay : Window
    {
        public FileDisplay(File file)
        {
            InitializeComponent();
            LblName.Text = file.Path;
            Content.Text = file.JsonString;
        }

    }
}
