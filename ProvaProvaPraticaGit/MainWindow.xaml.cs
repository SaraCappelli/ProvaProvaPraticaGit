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
                Brano b = new Brano(titolo_txtBox.Text, autore_txtBox.Text, MinSecToSec(durata_txtBox.Text));
                listaBrani.Add(b);
                brani_listBox.Items.Add(b);
            } catch
            {

            }
        }

        private int MinSecToSec(string text)
        {
            throw new NotImplementedException();
        }


        private void creaCD_button_Click(object sender, RoutedEventArgs e)
        {
            CD cd = new CD(titoloCD_txtBox, autoreCD_txtBox, listaBrani);
            listaBrani.Clear();
            brani_listBox.Items.Clear();
            listaCD_listBox.Items.Add(cd);
        }



        private void listaCD_listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                CD cdSel = listaCD_listBox.SelectedItem;
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
