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

namespace libreria
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        Biblioteca biblioteca;
        private void btnAggiungiLibro_Click(object sender, RoutedEventArgs e)
        {
            biblioteca.aggiungiLibro(txtAutore,txtTitolo,txtAnnoPubblicazione,txtEditore, int.Parse(txtNPagine.Text));
        }

        private void btnAggiungiBiblioteca_Click(object sender, RoutedEventArgs e)
        {
            Biblioteca biblioteca = new Biblioteca(txtNomeBiblioteca, txtIndirizzo, txtOrarioApertura, txtOrarioChiusura);


        }
    }
}
