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

namespace Biblioteca
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
        private void btnBiblioteca_Click(object sender, RoutedEventArgs e)
        {
            if (txtBiblioteca.Text != string.Empty)
            {
                string[] dati = txtBiblioteca.Text.Split('|');
                if (dati.Length == 4)
                {
                    biblioteca = new Biblioteca(dati[0], dati[1], dati[2], dati[3], new List<Libro>());
                    txtBiblioteca.Text = string.Empty;
                }
            }
        }

        private void btnLibro_Click(object sender, RoutedEventArgs e)
        {
            if (txtLibro.Text != string.Empty && biblioteca != null) 
            {
                string[] dati = txtLibro.Text.Split('|');
                if (dati.Length == 5)
                {
                    int annoPubblicazione;
                    int nPagine;

                    if (int.TryParse(dati[2], out annoPubblicazione) && int.TryParse(dati[4], out nPagine))
                    {
                        Libro libro = new Libro(dati[0], dati[1], annoPubblicazione, dati[3], nPagine);
                        biblioteca.addLibro(libro);
                        txtLibro.Text = string.Empty;
                    }
                }
            }
        }
    }
}
