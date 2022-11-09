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
        private SqlConnection conexion;

        public RepositorioVehiculos(SqlConnection conexion)
        {
            this.conexion = conexion;
        }

        public List<Vehiculo> GetLista()
        {
            List<Vehiculo> lista = new List<Vehiculo>();
            try
            {

                string cadenaComando = "SELECT VehiculoId, TipoVehiculo FROM Vehiculos";
                SqlCommand comando = new SqlCommand(cadenaComando, conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    var categoria = ConstruirVehiculo(reader);
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

        private Vehiculo ConstruirVehiculo(SqlDataReader reader)
        {
            return new Vehiculo()
            {
                VehiculoId = reader.GetInt32(0),
                TipoVehiculo = reader.GetString(1),
            };
           
            
        }

        public Vehiculo GetVehiculoPorId(int id)
        {

            Vehiculo vehiculo = null;
            try
            {
                    var cadenaComando = "SELECT VehiculoId, TipoVehiculo FROM Vehiculos WHERE VehiculoId=@id";
                    var comando = new SqlCommand(cadenaComando, conexion);
                    comando.Parameters.AddWithValue("@id", id);
                    using (var reader = comando.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            vehiculo = ConstruirVehiculo(reader);
                        }
                    }
                    return vehiculo;


            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
