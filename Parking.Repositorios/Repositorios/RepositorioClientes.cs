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
        private readonly ConexionBD conexionBd;

        public RepositorioClientes()
        {
            conexionBd = new ConexionBD();
        }

        public List<Cliente> GetLista()
        {
            List<Cliente> lista = new List<Cliente>();
            try
            {
                using (var cn = conexionBd.AbrirConexion()) 
                {
                    string cadenaComando = "SELECT ClienteId, Nombre, Apellido, VehiculoId, Telefono FROM Clientes";
                    SqlCommand comando = new SqlCommand(cadenaComando, cn);
                    SqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        var categoria = ConstruirCliente(reader);
                        lista.Add(categoria);
                    }
                    reader.Close();
                }

                return lista;

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private Cliente ConstruirCliente(SqlDataReader reader)
        {
            var categoria = new Cliente();
            categoria.ClienteId = reader.GetInt32(0);
            categoria.Nombre = reader.GetString(1);
            categoria.Apellido = reader.GetString(2);
            categoria.VehiculoId = reader.GetInt32(3);
            categoria.Telefono = reader.GetString(4);
            return categoria;
        }
    }
}
