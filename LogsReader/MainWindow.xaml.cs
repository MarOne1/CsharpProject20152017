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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
using System.IO;

namespace LogsReader
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private string filename;
        private string filecontent;


        public MainWindow()
        {
            InitializeComponent();
            
        }


        /*Lire le fichier texte*/
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog boiteDialogue1 = new OpenFileDialog();
            boiteDialogue1.Multiselect = false;
            boiteDialogue1.Filter = "Fichiers txt |*.txt";
            boiteDialogue1.FilterIndex = 2;
            boiteDialogue1.RestoreDirectory = true;

            try
            {
                using(Stream stream1 = boiteDialogue1.OpenFile())
                {
                    using (StreamReader reader = new StreamReader(stream1, Encoding.UTF8))
                    {
                        filecontent = reader.ReadToEnd();
                    }

                }
            }

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
