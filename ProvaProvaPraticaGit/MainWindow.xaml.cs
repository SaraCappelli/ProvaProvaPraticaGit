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


//SARA CAPPELLI 4E

namespace ProvaProvaPraticaGit
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

        List<Brano> listaBrani = new List<Brano>();
        private void creaBrano_button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Brano b = new Brano(NotEmptyString(titolo_txtBox.Text), NotEmptyString(autore_txtBox.Text), MinSecToSec(durata_txtBox.Text));
                listaBrani.Add(b);
                brani_listBox.Items.Add(b);
            } catch
            {

            }
        }

        string NotEmptyString(string text)
        {
            if (text != "") return text;
            else throw new Exception("vuoto");
        }

        private int MinSecToSec(string text)
        {
            string[] arr = text.Split(':');
            return int.Parse(arr[0]) * 60 + int.Parse(arr[1]);
        }


        private void creaCD_button_Click(object sender, RoutedEventArgs e)
        {
            CD cd = new CD(listaBrani, titoloCD_txtBox.Text, autoreCD_txtBox.Text);
            listaBrani.Clear();
            brani_listBox.Items.Clear();
            listaCD_listBox.Items.Add(cd);
        }



        private void listaCD_listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                CD cdSel = (CD)listaCD_listBox.SelectedItem;
                listaBraniCD_listBox.Items.Clear();
                foreach (Brano b in cdSel.ListaDeiBrani)
                {
                    listaBraniCD_listBox.Items.Add(b);
                }
            } catch
            {

            }
        }
    }
}
