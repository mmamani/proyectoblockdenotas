﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Resources;
using System.IO;


namespace BLOCDENOTAS
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }
        
        private void openbloc(object sender, RoutedEventArgs e)
        {
            string r;
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.DefaultExt = ".txt";

            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                StreamReader mytext = new StreamReader(dlg.FileName);
                r = mytext.ReadToEnd();
                textBox1.Text = r.ToString();
                //string filename = dlg.FileName;
                //textBlock1.Text = filename;
            }
            
            //StreamReader mytext = new StreamReader(dlg.FileName);
            
            
            
        }
    }
}
