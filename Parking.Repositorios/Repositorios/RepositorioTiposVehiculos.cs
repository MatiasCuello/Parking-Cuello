using Parking.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Repositorios.Repositorios
{
    public class RepositorioTiposVehiculos
    {
        private SqlConnection conexion;

        public RepositorioTiposVehiculos(SqlConnection conexion)
        {
            this.conexion = conexion;
        }

        public List<TipoVehiculo> GetLista()
        {
            List<TipoVehiculo> lista = new List<TipoVehiculo>();
            try
            {

                string cadenaComando = "SELECT TipoVehiculoId, Descripcion FROM TiposVehiculos";
                SqlCommand comando = new SqlCommand(cadenaComando, conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    var tipoVehiculo = ConstruirTipoVehiculo(reader);
                    lista.Add(tipoVehiculo);
                }
                reader.Close();


                return lista;

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private TipoVehiculo ConstruirTipoVehiculo(SqlDataReader reader)
        {
            return new TipoVehiculo()
            {
                TipoVehiculoId = reader.GetInt32(0),
                Descripcion = reader.GetString(1)
            };
           
            
        }

        public TipoVehiculo GetTipoVehiculoPorId(int id)
        {

            TipoVehiculo tipovehiculo = null;
            try
            {
                    var cadenaComando = "SELECT TipoVehiculoId, Descripcion FROM TiposVehiculos WHERE TipoVehiculoId=@id";
                    var comando = new SqlCommand(cadenaComando, conexion);
                    comando.Parameters.AddWithValue("@id", id);
                    using (var reader = comando.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            tipovehiculo = ConstruirTipoVehiculo(reader);
                        }
                    }
                return tipovehiculo;

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}
