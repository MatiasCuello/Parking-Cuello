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
                string cadenaComando = "SELECT ClienteId, NombreCompleto, Direccion, TipoVehiculoId, Telefono FROM Clientes";
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
                Direccion=reader.GetString(2),
                TipoVehiculoId = reader.GetInt32(3),
                Telefono = reader.GetString(4)
            };


        }

        public bool Existe(Cliente cliente)
        {
            if (cliente.ClienteId == 0)
            {
                string cadenaComando =
                    "SELECT ClienteId, NombreCompleto FROM Clientes WHERE NombreCompleto=@nom";
                SqlCommand comando = new SqlCommand(cadenaComando, conexion);
                comando.Parameters.AddWithValue("@nom", cliente.NombreCompleto);
                SqlDataReader reader = comando.ExecuteReader();
                return reader.HasRows;
            }
            else
            {
                string cadenaComando =
                    "SELECT ClienteId, NombreCompleto FROM Clientes WHERE NombreCompleto=@nom AND TipoVehiculoId<>@tipoVehiculoId";
                SqlCommand comando = new SqlCommand(cadenaComando, conexion);
                comando.Parameters.AddWithValue("@nom", cliente.NombreCompleto);
                comando.Parameters.AddWithValue("@tipoVehiculoId", cliente.TipoVehiculoId);
                SqlDataReader reader = comando.ExecuteReader();
                return reader.HasRows;

            }
        }

        public void Guardar(Cliente cliente)
        {
            if (cliente.ClienteId == 0)
            {
                try
                {
                    string cadenaComando =
                        "INSERT INTO Clientes VALUES(@nom,@dir,@tipoVehiculoId,@tel)";
                    SqlCommand comando = new SqlCommand(cadenaComando, conexion);
                    comando.Parameters.AddWithValue("@nom", cliente.NombreCompleto);
                    comando.Parameters.AddWithValue("@dir", cliente.Direccion);
                    comando.Parameters.AddWithValue("@tipoVehiculoId", cliente.TipoVehiculoId);
                    comando.Parameters.AddWithValue("@tel", cliente.Telefono);

                    comando.ExecuteNonQuery();
                    cadenaComando = "SELECT @@IDENTITY";
                    comando = new SqlCommand(cadenaComando, conexion);
                    cliente.ClienteId = (int)(decimal)comando.ExecuteScalar();

                }
                catch (Exception e)
                {
                    throw new Exception("Error al intentar guardar el registro");
                }

            }
            else
            {
                try
                {
                    string cadenaComando = 
                        "UPDATE Estados SET Cliente=@nom, Direccion=@dir,TipoVehiculoId=@tipoVehiculoId, Telefono=@tel WHERE ClienteId=@id";
                    SqlCommand comando = new SqlCommand(cadenaComando, conexion);
                    comando.Parameters.AddWithValue("@nom", cliente.NombreCompleto);
                    comando.Parameters.AddWithValue("@dir", cliente.Direccion);
                    comando.Parameters.AddWithValue("@tipoVehiculoId", cliente.TipoVehiculoId);
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
