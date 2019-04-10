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
using LogicaDeAgenda;
using ConexionBaseDedatos;
using System.Data.SqlClient;


namespace Agenda_WPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // List<Contacto> listaContacos = new List<Contacto>();

        public MainWindow()
        {
            InitializeComponent();
            // EventPrivateKey readyonly dataGrid;
            
            Conexion conexion = new Conexion();
           
            this.dataGrid.ItemsSource = conexion.VerContactos();
            

        }

       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Contacto contacto = new Contacto();
            int x;
            string num;
            num = textBoxMovil.Text;
                for (x=0;x<num.Length;x++)
                {
                    if (num[x] >='0'&& num[x] <= '9')
                    {
                    contacto.TelefonoMovil = textBoxMovil.Text;
                    }
                    else
                    {
                    MessageBox.Show("El campo numero solo admite numeros");
                }
                }
           

           // Contacto contacto = new Contacto();

            contacto.Nombre = textBoxNombre.Text;
            contacto.Apellido = textBoxApellido.Text;
            //contacto.TelefonoMovil = textBoxMovil.Text;
            contacto.TelefonoCasa = texBoxTelefonoCasa.Text;
            contacto.TelefonoTrabajo = textBoxTelefonoTrabajo.Text;
            contacto.Email = texBoxEmail.Text;
            contacto.Twitter = texBoxTwitter.Text;
            Conexion conexion1 = new Conexion(); // instansiamos para poder usar el metodo crear contacto de la capa coexion
            conexion1.CrearContacto(contacto); //mandamos a llamar el metodo crear contacto y le mandamos el objeto contacto
            MessageBox.Show("Contacto Creado");
            //listaContacos.Add(contacto);
            dataGrid.Items.Refresh();
        }



        private void Nombre_txt_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           // ListViewItem item1 = new ListViewItem (contacto.nombre)

        }
    }
}
