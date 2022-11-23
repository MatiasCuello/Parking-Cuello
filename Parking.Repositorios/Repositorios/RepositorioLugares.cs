using Parking.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Repositorios.Repositorios
{
    public class RepositorioLugares
    {
        private SqlConnection conexion;

        public RepositorioLugares(SqlConnection conexion)
        {
            this.conexion = conexion;
        }

        public List<Lugar> GetLista(Sector sector=null)
        {
            List<Lugar> lista = new List<Lugar>();
            try
            {
                StringBuilder SB = new StringBuilder(" SELECT LugarId, Descripcion, SectorId, Disponible, RowVersion FROM Lugares ");
                if (sector != null)
                {
                    SB.Append("WHERE SectorId=@id ");

                }
                else
                {
                    SB.Append(" ORDER BY Descripcion");
                }
                var cadenaComando = SB.ToString();
                var comando = new SqlCommand(cadenaComando, conexion);
                if (sector != null)
                {
                    comando.Parameters.AddWithValue("@id", sector.SectorId);
                }
                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Lugar lugar = ConstruirLugar(reader);
                        lista.Add(lugar);
                    }
                }
                return lista;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            //    string cadenaComando = "SELECT LugarId, Descripcion, SectorId, Disponible, RowVersion FROM Lugares";
            //    SqlCommand comando = new SqlCommand(cadenaComando, conexion);
            //    SqlDataReader reader = comando.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        var lugar = ConstruirLugar(reader);
            //        lista.Add(lugar);
            //    }
            //    reader.Close();


            //    return lista;

            //}
            //catch (Exception e)
            //{
            //    throw new Exception(e.Message);
            //}
        }

        private Lugar ConstruirLugar(SqlDataReader reader)
        {
            return new Lugar()
            {
                LugarId = reader.GetInt32(0),
                Descripcion = reader.GetString(1),
                SectorId = reader.GetInt32(2),
                Disponible = reader.GetBoolean(3),
                RowVersion = (byte[])reader[4]
            };


        }

        public Lugar GetLugarPorId(int lugarId)
        {
            Lugar lugar = null;
            try
            {
                var cadenaComando =
                    "SELECT LugarId, Descripcion, SectorId, Disponible, RowVersion FROM Lugares WHERE LugarId=@id";
                var comando = new SqlCommand(cadenaComando, conexion);
                comando.Parameters.AddWithValue("@id", lugarId);
                using (var reader = comando.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        lugar = ConstruirLugar(reader);
                    }
                }
                return lugar;

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}
