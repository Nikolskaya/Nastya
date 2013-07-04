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
using System.IO;
using System.Collections;
using Microsoft.Win32;

namespace pro
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void oprogram_click(object sender, RoutedEventArgs e)
        {
            string program = "Настя Никольская\n";
            MessageBox.Show(program,"О программе",MessageBoxButton.OK,MessageBoxImage.Information);
        }
        private void vihod_click (object sender, RoutedEventArgs e)
        {

        }
        private void pomosh_click(object sender, RoutedEventArgs e)
        {
            string pomosh = "Помощь\n";
            MessageBox.Show(pomosh,"Помощь",MessageBoxButton.OK,MessageBoxImage.Question);
        }
        private void otkr_click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();
        }
        private void soxp_click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.ShowDialog();
        }
        private void soxpkak_click(object sender, RoutedEventArgs e)
        {

        }
        private void pechat_click(object sender, RoutedEventArgs e)
        {

        }
    }
}
