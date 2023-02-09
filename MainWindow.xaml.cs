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
using System.IO;
using Microsoft.Win32;

namespace WpfApp3
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

        private void Betolt(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fajlMegnyitas = new OpenFileDialog();

            fajlMegnyitas.DefaultExt = ".txt";

            if (fajlMegnyitas.ShowDialog() == false)
            {
                return;
            }

            StreamReader fileHandler = new StreamReader(fajlMegnyitas.FileName);
            String? olvasottSor;

            while (!fileHandler.EndOfStream)
            {
                olvasottSor = fileHandler.ReadLine();
                if (olvasottSor != "")
                {
                    lbElso.Items.Add(olvasottSor);
                }
            }
        }

        private void btnSzur(object sender, RoutedEventArgs e)
        {

            lbMasodik.Items.Clear();
            foreach (Object objektum in lbElso.Items)
            {
                if (objektum.ToString().Contains(txtBekeres.Text))
                {
                    lbMasodik.Items.Add(objektum.ToString());
                }
            }
        }
    }
}
