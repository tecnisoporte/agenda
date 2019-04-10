using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using LogicaDeAgenda;

namespace ConexionBaseDedatos

{
    public class Conexion
    {

        string server = "Server=localhost; Database=agenda; User Id=manager; Password=12345";

        public SqlConnection conectBD = new SqlConnection();

        public Conexion()  // Autenticacion de usuario con el servidos SQL
        {
            conectBD.ConnectionString = server;
        }

        public void Abrir()
        {

            try
            {
                conectBD.Open();
                Console.WriteLine("Conexion abierta");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir la Base de Datos" + ex.Message);
            }

        }

        public void CrearContacto(Contacto contactoMW)

        {
            try
            {
                Abrir();
                try
                {
                     string inserTo = "INSERT INTO Contactos (Nombre,Apellido,Movil,Casa,Trabajo,Email,Twitter) VALUES (@nombre,@apellido,@movil,@casa,@trabajo,@email,@twitter)";
                     SqlCommand contacto = new SqlCommand(inserTo, conectBD);
                     contacto.Parameters.AddWithValue("@nombre", contactoMW.Nombre);
                     contacto.Parameters.AddWithValue("@apellido", contactoMW.Apellido);
                     contacto.Parameters.AddWithValue("@movil", contactoMW.TelefonoMovil);
                     contacto.Parameters.AddWithValue("@casa", contactoMW.TelefonoCasa);
                     contacto.Parameters.AddWithValue("@trabajo", contactoMW.TelefonoTrabajo);
                     contacto.Parameters.AddWithValue("@email", contactoMW.Email);
                     contacto.Parameters.AddWithValue("@twitter", contactoMW.Twitter);
                     int result=contacto.ExecuteNonQuery();
                    Console.WriteLine(result);
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Cerrar();
                }

            } catch (SqlException ex) {
                Console.WriteLine(ex.Message);
            }

        }


        public void Cerrar()
        {
            try
            {
                conectBD.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public List<Contacto> VerContactos()  
        {
            try
            {
                Abrir();

                string selecTo = "select * from Contactos"; //query
                SqlCommand select = new SqlCommand(selecTo, conectBD);
                SqlDataReader reader = select.ExecuteReader();
                List<Contacto> contactos = new List<Contacto>();

                while (reader.Read())
                {
                    Contacto contacto = new Contacto();
                    contacto.Nombre = reader[0].ToString();
                    contacto.Apellido = reader[1].ToString();
                    contacto.TelefonoMovil = reader[2].ToString();
                    contacto.TelefonoCasa = reader[3].ToString();
                    contacto.TelefonoTrabajo = reader[4].ToString();
                    contacto.Email = reader[5].ToString();
                    contacto.Twitter = reader[6].ToString();
                    contactos.Add(contacto);
                };

                return contactos;
            }

            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Cerrar();
            }
            return null;
        }
             

    }

}

