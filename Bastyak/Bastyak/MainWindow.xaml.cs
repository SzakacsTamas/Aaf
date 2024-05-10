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

namespace Bastyak
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Label cimke=new Label();
            cimke.Content = "asd";
            cimke.BorderBrush = Brushes.SlateBlue;
            cimke.BorderThickness = new Thickness(5);
            cimke.Background = Brushes.AliceBlue;
            cimke.Foreground = Brushes.White;
            cimke.Height = Tabla.Height/8;
            cimke.Width = Tabla.Width/8;
            Tabla.Children.Add(cimke);
        }
    }
}
