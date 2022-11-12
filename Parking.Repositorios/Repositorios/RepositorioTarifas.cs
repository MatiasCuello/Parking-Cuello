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

        public List<Tarifa> GetLista()
        {
            List<Tarifa> lista = new List<Tarifa>();
            try
            {

                string cadenaComando = "SELECT TarifaId, TipoVehiculoId, TiempoId, Importe, RowVersion FROM Tarifas";
                SqlCommand comando = new SqlCommand(cadenaComando, conexion);
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
                TipoVehiculoId = reader.GetInt32(1),
                TiempoId = reader.GetInt32(2),
                Importe = reader.GetDecimal(3),
                RowVersion = (byte[])reader[4],
            };


        }
    }
}
