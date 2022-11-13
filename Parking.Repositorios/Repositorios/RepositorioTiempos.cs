using Parking.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Repositorios.Repositorios
{
    public class RepositorioTiempos
    {
        private SqlConnection conexion;

        public RepositorioTiempos(SqlConnection conexion)
        {
            this.conexion = conexion;
        }

        public List<Tiempo> GetLista()
        {
            List<Tiempo> lista = new List<Tiempo>();
            try
            {

                string cadenaComando = "SELECT TiempoId, Descripcion, Detalle FROM Tiempos";
                SqlCommand comando = new SqlCommand(cadenaComando, conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    var tiempo = ConstruirTiempo(reader);
                    lista.Add(tiempo);
                }
                reader.Close();


                return lista;

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private Tiempo ConstruirTiempo(SqlDataReader reader)
        {
            return new Tiempo()
            {
                TiempoId = reader.GetInt32(0),
                Descripcion = reader.GetString(1),
                Detalle = reader.GetString(2)
            };


        }

        public Tiempo GetTiempoPorId(int id)
        {

            Tiempo tiempo = null;
            try
            {
                var cadenaComando = "SELECT TiempoId, Descripcion,Detalle FROM Tiempos WHERE TiempoId=@id";
                var comando = new SqlCommand(cadenaComando, conexion);
                comando.Parameters.AddWithValue("@id", id);
                using (var reader = comando.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        tiempo = ConstruirTiempo(reader);
                    }
                }
                return tiempo;

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}

