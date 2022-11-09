using Parking.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Repositorios.Repositorios
{
    public class RepositorioClientes
    {
        private SqlConnection conexion;

        public RepositorioClientes(SqlConnection conexion)
        {
            this.conexion = conexion;
        }

        public List<Cliente> GetLista()
        {
            List<Cliente> lista = new List<Cliente>();
            try
            {
                string cadenaComando = "SELECT ClienteId, Nombre, Apellido, VehiculoId, Telefono FROM Clientes";
                SqlCommand comando = new SqlCommand(cadenaComando, conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    var categoria = ConstruirCliente(reader);
                    lista.Add(categoria);
                }
                reader.Close();


                return lista;

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private Cliente ConstruirCliente(SqlDataReader reader)
        {
            return new Cliente
            {
                ClienteId = reader.GetInt32(0),
                Nombre = reader.GetString(1),
                Apellido = reader.GetString(2),
                VehiculoId = reader.GetInt32(3),
                Telefono = reader.GetString(4)
            };


        }
    }
}
