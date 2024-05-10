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

namespace tortek
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

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            int szamlalo = 0;
            try
            {
                szamlalo = Convert.ToInt32(textBox.Text);
            }
            catch { }
            int nevezo = 0;
            textBlock6.Text = "" + szamlalo+" / "+nevezo;

            try
            {
                nevezo = Convert.ToInt32(textBox1.Text);
                
            }
            catch { };

            if (szamlalo / nevezo == 0 && nevezo!=0)
            {
                textBlock.Text = (szamlalo / nevezo).ToString();
            }
        }

      
    }
}
