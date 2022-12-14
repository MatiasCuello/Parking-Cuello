using Parking.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Repositorios.Repositorios
{
    public class RepositorioTarifas
    {
        private SqlConnection conexion;

        public RepositorioTarifas(SqlConnection conexion)
        {
            this.conexion = conexion;
        }

        public List<Tarifa> GetLista(TipoVehiculo tipoVehiculo=null)
        {
            List<Tarifa> lista = new List<Tarifa>();
            try
            {
                StringBuilder sb = new StringBuilder(" SELECT TarifaId, Descripcion, TipoVehiculoId, TiempoId, Importe, RowVersion FROM Tarifas ");
                if (tipoVehiculo != null)
                {
                    sb.Append("WHERE TipoVehiculoId=@tipoVehiculoId ORDER BY TarifaId");
                }
                else
                {
                    sb.Append(" ORDER BY TarifaId");
                }

                //string cadenaComando =
                //    "SELECT TarifaId, Descripcion, TipoVehiculoId, TiempoId, Importe, RowVersion FROM Tarifas";
                string cadenaComando = sb.ToString();
                SqlCommand comando = new SqlCommand(cadenaComando, conexion);
                if (tipoVehiculo != null)
                {
                    comando.Parameters.AddWithValue("@tipoVehiculoId", tipoVehiculo.TipoVehiculoId);
                }
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    var tarifa = ConstruirTarifa(reader);
                    lista.Add(tarifa);
                }
                reader.Close();


                return lista;

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private Tarifa ConstruirTarifa(SqlDataReader reader)
        {
            return new Tarifa()
            {
                TarifaId = reader.GetInt32(0),
                Descripcion = reader.GetString(1),
                TipoVehiculoId = reader.GetInt32(2),
                TiempoId = reader.GetInt32(3),
                Importe = reader.GetDecimal(4),
                RowVersion = (byte[])reader[5],
            };


        }

        public bool Existe(Tarifa tarifa)
        {
            try
            {
                var cadenaComando = "SELECT TipoVehiculoId, TiempoId, Importe FROM Tarifas" +
                                     " WHERE TipoVehiculoId=@tipoVehiculoId AND TiempoId=@tiempoId AND Importe=@imp ";
                var comando = new SqlCommand(cadenaComando, conexion);
                comando.Parameters.AddWithValue("@tipoVehiculoId", tarifa.TipoVehiculoId);
                comando.Parameters.AddWithValue("@tiempoId", tarifa.TiempoId);
                comando.Parameters.AddWithValue("@imp", tarifa.Importe);
                comando.Parameters.AddWithValue("@id", tarifa.TarifaId);
                var reader = comando.ExecuteReader();
                return reader.HasRows;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }



        public int Agregar(Tarifa tarifa)
        {
            int registrosAfectados = 0;
            try
            {
                string cadenaComando =
                    "INSERT INTO Tarifas (TipoVehiculoId, TiempoId, Importe) VALUES (@tipoVehiculoId, @tiempoId, @imp)";
                SqlCommand comando = new SqlCommand(cadenaComando, conexion);
                comando.Parameters.AddWithValue("@tipoVehiculoId", tarifa.TipoVehiculoId);
                comando.Parameters.AddWithValue("@tiempoId", tarifa.TiempoId);
                comando.Parameters.AddWithValue("@imp", tarifa.Importe);

                registrosAfectados = comando.ExecuteNonQuery();

                if (registrosAfectados == 0)
                {
                    throw new Exception("Error al intentar agregar el registro");
                }
                else
                {
                    cadenaComando = "SELECT @@IDENTITY";
                    comando = new SqlCommand(cadenaComando, conexion);
                    tarifa.TarifaId = (int)(decimal)comando.ExecuteScalar();

                    cadenaComando = "SELECT RowVersion FROM Tarifas WHERE TarifaId=@id";
                    comando = new SqlCommand(cadenaComando, conexion);
                    comando.Parameters.AddWithValue("@id", tarifa.TarifaId);
                    tarifa.RowVersion = (byte[])comando.ExecuteScalar();
                }
                return registrosAfectados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public int Editar(Tarifa tarifa)
        {
            int registrosAfectados= 0;
            try
            {
                string cadenaComando =
                    "UPDATE Tarifas SET TipoVehiculoId=@tipoVehiculoId, TiempoId=@tiempoId, Importe=@imp " +
                    "WHERE TarifaId=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, conexion);
                comando.Parameters.AddWithValue("@tipoVehiculoId", tarifa.TipoVehiculoId);
                comando.Parameters.AddWithValue("@tiempoId", tarifa.TiempoId);
                comando.Parameters.AddWithValue("@imp", tarifa.Importe);
                comando.Parameters.AddWithValue("@id", tarifa.TarifaId);
                registrosAfectados=comando.ExecuteNonQuery();
                if (registrosAfectados==0)
                {
                    throw new Exception("No se ha modificado ningun registro");
                }
                else
                {

                    cadenaComando = "SELECT RowVersion FROM Tarifas WHERE TarifaId=@id";
                    comando = new SqlCommand(cadenaComando, conexion);
                    comando.Parameters.AddWithValue("@id", tarifa.TarifaId);
                    tarifa.RowVersion = (byte[])comando.ExecuteScalar();
                }
            
                return registrosAfectados;
            }
            catch (Exception)
            {
                throw new Exception("Error al intentar modificar el registro");
            }
        }

        public Tarifa GetTarifaPorId(int tarifaId)
        {
            Tarifa tarifa = null;
            try
            {
                var cadenaComando =
                    "SELECT TarifaId, TipoVehiculoId, TiempoId, Importe, RowVersion FROM Tarifas WHERE TarifaId=@id";
                var comando = new SqlCommand(cadenaComando, conexion);
                comando.Parameters.AddWithValue("@id", tarifaId);
                using (var reader = comando.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        tarifa = ConstruirTarifa(reader);

                    }
                }

                return tarifa;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Borrar(int tarifaId)
        {
            try
            {
                string cadenaComando = "DELETE FROM Tarifas WHERE TarifaId=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, conexion);
                comando.Parameters.AddWithValue("@id", tarifaId);
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(Tarifa t)
        {
            try
            {
                var cadenaComando = "SELECT COUNT(*) FROM DetalleVehiculos WHERE TarifaId=@id";
                var comando = new SqlCommand(cadenaComando, conexion);
                comando.Parameters.AddWithValue("@id", t.TarifaId);
                return (int)comando.ExecuteScalar() > 0;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
