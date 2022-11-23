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

                string cadenaComando =
                    "SELECT VehiculoId, Patente, FechaHoraIngreso, TipoVehiculoId, SectorId, LugarId, Estacionado, RowVersion FROM Vehiculos";
                SqlCommand comando = new SqlCommand(cadenaComando, conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    var vehiculo = ConstruirVehiculo(reader);
                    lista.Add(vehiculo);
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
                Patente = reader.GetString(1),
                FechaHoraIngreso = reader.GetDateTime(2),
                TipoVehiculoId = reader.GetInt32(3),
                SectorId = reader.GetInt32(4),
                LugarId = reader.GetInt32(5),
                Estacionado = reader.GetBoolean(6),
                RowVersion = (byte[])reader[7],
            };
        }

        public bool Existe(Vehiculo vehiculo)
        {
            try
            {
                var cadenaComando = "SELECT VehiculoId, Patente FROM Vehiculos" +
                                     " WHERE Patente=@patente AND VehiculoId=@id ";
                var comando = new SqlCommand(cadenaComando, conexion);
                comando.Parameters.AddWithValue("@patente", vehiculo.Patente);
                comando.Parameters.AddWithValue("@id", vehiculo.VehiculoId);
                var reader = comando.ExecuteReader();
                return reader.HasRows;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public int Agregar(Vehiculo vehiculo)
        {
            int registrosAfectados = 0;
            try
            {
                string cadenaComando =
                    "INSERT INTO Vehiculos ( Patente, FechaHoraIngreso, TipoVehiculoId, SectorId, LugarId, Estacionado) " +
                    "VALUES ( @patente, @fechaHoraIngreso, @tipoVehiculoId, @sectorId, @lugarId, @estacionado)";
                SqlCommand comando = new SqlCommand(cadenaComando, conexion);
                comando.Parameters.AddWithValue("@patente", vehiculo.Patente);
                comando.Parameters.AddWithValue("@fechaHoraIngreso", vehiculo.FechaHoraIngreso);
                comando.Parameters.AddWithValue("@tipoVehiculoId", vehiculo.TipoVehiculoId);
                comando.Parameters.AddWithValue("@sectorId", vehiculo.SectorId);
                comando.Parameters.AddWithValue("@lugarId", vehiculo.LugarId);
                comando.Parameters.AddWithValue("@estacionado", vehiculo.Estacionado);


                registrosAfectados = comando.ExecuteNonQuery();

                if (registrosAfectados == 0)
                {
                    throw new Exception("Error al intentar agregar el registro");
                }
                else
                {
                    cadenaComando = "SELECT @@IDENTITY";
                    comando = new SqlCommand(cadenaComando, conexion);
                    vehiculo.VehiculoId = (int)(decimal)comando.ExecuteScalar();

                    cadenaComando = "SELECT RowVersion FROM Vehiculos WHERE VehiculoId=@id";
                    comando = new SqlCommand(cadenaComando, conexion);
                    comando.Parameters.AddWithValue("@id", vehiculo.VehiculoId);
                    vehiculo.RowVersion = (byte[])comando.ExecuteScalar();
                }
                return registrosAfectados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
    }
}
