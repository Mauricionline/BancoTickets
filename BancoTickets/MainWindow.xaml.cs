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

namespace BancoTickets
{    
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int posicionCola = 0;
        int ticket=0;
        int tope = 10;
        ColaBanco<int> colaBanco;
        Cajero cajero1;
        Cajero cajero2;
        public MainWindow()
        {
            cajero1 = new Cajero();
            cajero2 = new Cajero();
            colaBanco = new ColaBanco<int>(tope);
            InitializeComponent();
        }

        private void BtnNuevoTicket_Click(object sender, RoutedEventArgs e)
        {
            ListCola.Items.Clear();
            txtNumeroTicket.Text = ticket.ToString();            
            colaBanco.insertar(ticket);

            for (int i = colaBanco.Front; i < colaBanco.Rear; i++)
            {
                ListCola.Items.Add(colaBanco.Vec[i]);
            }

            
            if (ticket < tope)
            {
                ticket++;
            }
            else
            {
                MessageBox.Show("llego al numero maximo de tickets diarios");
            }
        }

        private void BtnNuevoCliente1_Click(object sender, RoutedEventArgs e)
        {
            ListCola.Items.Clear();
            cajero1.ListaAtendidos.Add(colaBanco.Vec[posicionCola]);
            txtSiguienteNumero1.Text = colaBanco.Vec[posicionCola].ToString();            
            colaBanco.eliminar();

            for (int i = colaBanco.Front; i < colaBanco.Rear; i++)
            {
                ListCola.Items.Add(colaBanco.Vec[i]);
            }
            
            posicionCola++;
        }

        private void BtnNuevoCliente2_Click(object sender, RoutedEventArgs e)
        {
            ListCola.Items.Clear();
            txtSiguienteNumero2.Text = colaBanco.Vec[posicionCola].ToString();
            cajero2.ListaAtendidos.Add(colaBanco.Vec[posicionCola]);
            colaBanco.eliminar();

            for (int i = colaBanco.Front; i < colaBanco.Rear; i++)
            {
                ListCola.Items.Add(colaBanco.Vec[i]);
            }
            
            posicionCola++;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            foreach(int x in cajero1.ListaAtendidos)
            {
                listCajero1.Items.Add(x);
            }

            foreach (int x in cajero2.ListaAtendidos)
            {
                listCajero2.Items.Add(x);
            }

            txtContador1.Text = cajero1.ListaAtendidos.Count().ToString();
            txtContador2.Text = cajero2.ListaAtendidos.Count().ToString();
        }
    }
}
