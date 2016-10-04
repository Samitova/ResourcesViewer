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
using System.Configuration;
using System.IO;

namespace ResourcesViewer
{
    /// <summary>
    /// Interaction logic for OptionWindow.xaml
    /// </summary>
    public partial class OptionWindow : Window
    {
        
        public OptionWindow()
        {
            InitializeComponent();           
        }

        private void optionListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void browseButton_Click(object sender, RoutedEventArgs e)
        {
            

        }

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            Options.GetInstance().SaveConfiguration();
            this.Close();
        }

        private void canselButton_Click(object sender, RoutedEventArgs e)
        {
            Options.GetInstance().LoadConfiguration();
            this.Close();
        }

       
    }
}
