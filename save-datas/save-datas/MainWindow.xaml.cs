using System;
using System.IO;
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

namespace save_datas
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Savedatas SD = new Savedatas();

            SD.textboxInhalt = Convert.ToString(textbox.Document);

            SD.save(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\userdaten.txt");
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Savedatas SD = new Savedatas();

            SD.load(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\userdaten.txt");

            


        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
