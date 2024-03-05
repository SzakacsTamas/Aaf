using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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

namespace wpfgyak02._23
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

        private void textbox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        string uzenet = "";

        private void gomb_Click(object sender, RoutedEventArgs e)
        {
            string nev = textbox1.Text;
            string szhely = textbox2.Text;
            string kor = textbox3.Text;


            if (nev == "" || szhely == "" || kor == "")
            {
                MessageBox.Show("Töltsd ki mind!");

            }
            else
            {

                if(uzenet== "Add vissza az ezresem")
                {
                    listbox.Items[listbox.SelectedIndex] = nev + ", " + szhely + ", " + kor;

                    uzenet = "";
                }
                else
                {
                    listbox.Items.Add(nev + ", " + szhely + ", " + kor);
                }
                

                textbox1.Text = "";
                textbox2.Text = "";
                textbox3.Text = "";
            }





        }

        private void listbox_MouseUp(object sender, MouseButtonEventArgs e)
        {
            string szoveg = ((ListBox)sender).SelectedItem.ToString();
            //MessageBox.Show(szoveg);
            string[] vag = szoveg.Split(", ");
            textbox1.Text=vag[0];
            textbox2.Text=vag[1];
            textbox3.Text = vag[2];

            uzenet = "Add vissza az ezresem";

        }
    }
}