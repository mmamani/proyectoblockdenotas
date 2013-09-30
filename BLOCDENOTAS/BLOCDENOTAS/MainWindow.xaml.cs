using System;
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
using Microsoft.Win32;


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
        #region open
        private void openbloc(object sender, RoutedEventArgs e)
        {
            string r;
            OpenFileDialog dlg = new OpenFileDialog();
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
        #endregion
        #region nuevo
        private void newnote(object sender, RoutedEventArgs e)
        {
            textBox1.Clear();
            
        }
        #endregion
        #region guardarcomo
        private void guardarcomo(object sender, RoutedEventArgs e)
        {
            SaveFileDialog my = new SaveFileDialog();
            my.Filter = "text file *.txt";
            my.FileName = "untitled";
            my.Title = "save as";
            if (my.ShowDialog()== DialogResult.Equals("ok"))
            {
                F
            }

        }
        #endregion
        #region salir
        private void exit(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
        #endregion
    }
}
