﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ResourcesViewer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {        
        public MainWindow()
        {
            InitializeComponent();            
            
        }

        private void exitItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void optionsItem_Click(object sender, RoutedEventArgs e)
        {
            OptionWindow w = new OptionWindow();
            w.Owner = this;
            w.WindowStartupLocation = WindowStartupLocation.CenterOwner;            
            w.ShowDialog();           
        }

        private void findItem_Click(object sender, RoutedEventArgs e)
        {            

        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
