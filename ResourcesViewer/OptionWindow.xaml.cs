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

namespace ResourcesViewer
{
    /// <summary>
    /// Interaction logic for OptionWindow.xaml
    /// </summary>
    public partial class OptionWindow : Window
    {
        public string rootDirectory { set; get;} 
        public string resourcesFilesExtention { set; get; }
        public OptionWindow()
        {
            InitializeComponent();
            rootDirectory = @"D:/Resources";            
        }

        private void optionListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void resourcesFile_Checked(object sender, RoutedEventArgs e)
        {
            string substr = getCheckBoxContent(sender as CheckBox) + ";";
            resourcesFilesExtention += substr;            
        }

        private void resourcesFile_Unchecked(object sender, RoutedEventArgs e)
        {                       
            string substr = getCheckBoxContent(sender as CheckBox) +";";
            int index = resourcesFilesExtention.IndexOf(substr);
            resourcesFilesExtention = resourcesFilesExtention.Remove(index, substr.Length);            
        }

        private string getCheckBoxContent(CheckBox ckBox) {
            string checkBoxContent = ckBox.Content.ToString();
            return checkBoxContent;
        }      

        private void browseButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
