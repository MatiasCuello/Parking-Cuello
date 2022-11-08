using Parking.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Repositorios.Repositorios
{
    public class RepositorioVehiculos
    {
        private readonly ConexionBD conexion;

        public RepositorioVehiculos()
        {
            conexion = new ConexionBD();
        }

        public List<Vehiculo> GetLista()
        {
            List<Vehiculo> lista = new List<Vehiculo>();
            try
            {
                using (var cn = conexion.AbrirConexion())
                {
                    string cadenaComando = "SELECT VehiculoId, Vehiculo FROM Vehiculos";
                    SqlCommand comando = new SqlCommand(cadenaComando, cn);
                    SqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        var categoria = ConstruirVehiculo(reader);
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

        private Vehiculo ConstruirVehiculo(SqlDataReader reader)
        {
            var categoria = new Vehiculo();
            categoria.VehiculoId = reader.GetInt32(0);
            categoria.TipoVehiculo = reader.GetString(1);
            return categoria;
        }
    }
}
