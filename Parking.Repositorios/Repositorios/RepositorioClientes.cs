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
                string cadenaComando = "SELECT ClienteId, NombreCompleto, Direccion, Telefono, RowVersion FROM Clientes";
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
                NombreCompleto = reader.GetString(1),
                Direccion = reader.GetString(2),
                Telefono = reader.GetString(3)
            };


        }

        public bool Existe(Cliente cliente)
        {

            try
            {
                var cadenaComando = "SELECT ClienteId, NombreCompleto FROM Clientes WHERE NombreCompleto=@nom";
                var comando = new SqlCommand(cadenaComando, conexion);
                comando.Parameters.AddWithValue("@nom", cliente.NombreCompleto);
                var reader = comando.ExecuteReader();
                return reader.HasRows;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }



        }
        public bool EstaRelacionado(Cliente c)
        {
            try
            {
                var cadenaComando = "SELECT COUNT(*) FROM CuentasCorrientes WHERE ClienteId=@id";
                var comando = new SqlCommand(cadenaComando, conexion);
                comando.Parameters.AddWithValue("@id", c.ClienteId);
                return (int)comando.ExecuteScalar() > 0;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Borrar(int clienteId)
        {

            try
            {
                string cadenaComando = "DELETE FROM Clientes WHERE ClienteId=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, conexion);
                comando.Parameters.AddWithValue("@id", clienteId);
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        public void Guardar(Cliente cliente)
        {
            if (cliente.ClienteId == 0)
            {
                try
                {
                    string cadenaComando =
                        "INSERT INTO Clientes (NombreCompleto, Direccion, Telefono)" +
                        " VALUES (@nom, @dir, @tel)";
                    SqlCommand comando = new SqlCommand(cadenaComando, conexion);
                    comando.Parameters.AddWithValue("@nom", cliente.NombreCompleto);
                    comando.Parameters.AddWithValue("@dir", cliente.Direccion);
                    comando.Parameters.AddWithValue("@tel", cliente.Telefono);

                    comando.ExecuteNonQuery();
                    cadenaComando = "SELECT @@IDENTITY";
                    comando = new SqlCommand(cadenaComando, conexion);
                    cliente.ClienteId = (int)(decimal)comando.ExecuteScalar();

                    cadenaComando = "SELECT RowVersion FROM Clientes WHERE ClienteId=@id";
                    comando = new SqlCommand(cadenaComando, conexion);
                    comando.Parameters.AddWithValue("@id", cliente.ClienteId);
                    cliente.RowVersion = (byte[])comando.ExecuteScalar();

                }
                catch (Exception)
                {
                    throw new Exception("Error al intentar guardar el registro");
                }

            }
            else
            {
                try
                {
                    string cadenaComando =
                        "UPDATE Clientes SET NombreCompleto=@nom, Direccion=@dir, Telefono=@tel " +
                        "WHERE ClienteId=@id";
                    SqlCommand comando = new SqlCommand(cadenaComando, conexion);
                    comando.Parameters.AddWithValue("@nom", cliente.NombreCompleto);
                    comando.Parameters.AddWithValue("@dir", cliente.Direccion);
                    comando.Parameters.AddWithValue("@tel", cliente.Telefono);
                    comando.Parameters.AddWithValue("@id", cliente.ClienteId);
                    comando.ExecuteNonQuery();

                }
                catch (Exception e)
                {
                    throw new Exception("Error al intentar modificar el registro");
                }

            }
        }
    }
}
