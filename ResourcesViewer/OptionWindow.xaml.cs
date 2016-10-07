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
using Microsoft.Win32;
using System.IO;
using ResourcesViewer.Model;

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
            using (System.Windows.Forms.FolderBrowserDialog dlg = new System.Windows.Forms.FolderBrowserDialog())
            {
                dlg.Description = "Choose root directory to process";
                dlg.ShowNewFolderButton = false;
                if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    rootDirectoryTextBox.Text = dlg.SelectedPath.ToString();
                    Options.GetInstance().rootDirectory = dlg.SelectedPath;
                }
            }
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
