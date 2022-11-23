using Parking.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Repositorios.Repositorios
{
    public class RepositorioSectores
    {
        private SqlConnection conexion;

        public RepositorioSectores(SqlConnection conexion)
        {
            this.conexion = conexion;
        }

        public List<Sector> GetLista()
        {
            List<Sector> lista = new List<Sector>();
            try
            {

                string cadenaComando =
                    "SELECT SectorId, Descripcion, LugaresDisponibles, RowVersion FROM Sectores";
                SqlCommand comando = new SqlCommand(cadenaComando, conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    var sector = ConstruirSector(reader);
                    lista.Add(sector);
                }
                reader.Close();


                return lista;

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private Sector ConstruirSector(SqlDataReader reader)
        {
            return new Sector()
            {
                SectorId = reader.GetInt32(0),
                Descripcion = reader.GetString(1),
                LugaresDisponibles = reader.GetInt32(2),
                RowVersion = (byte[])reader[3]
            };


        }

        public Sector GetSectorPorId(int id)
        {

            Sector sector = null;
            try
            {
                var cadenaComando = 
                    "SELECT SectorId, Descripcion, LugaresDisponibles, RowVersion FROM Sectores WHERE SectorId=@id";
                var comando = new SqlCommand(cadenaComando, conexion);
                comando.Parameters.AddWithValue("@id", id);
                using (var reader = comando.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        sector = ConstruirSector(reader);
                    }
                }
                return sector;

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}
