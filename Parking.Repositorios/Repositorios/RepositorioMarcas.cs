using Parking.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Repositorios.Repositorios
{
    public class RepositorioMarcas
    {
        private SqlConnection conexion;

        public RepositorioMarcas(SqlConnection conexion)
        {
            this.conexion = conexion;
        }

        public List<Marca> GetLista()
        {
            List<Marca> lista = new List<Marca>();
            try
            {

                string cadenaComando = "SELECT MarcaId, Descripcion, RowVersion FROM Marcas";
                SqlCommand comando = new SqlCommand(cadenaComando, conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    var marca = ConstruirMarca(reader);
                    lista.Add(marca);
                }
                reader.Close();


                return lista;

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private Marca ConstruirMarca(SqlDataReader reader)
        {
            return new Marca()
            {
                MarcaId = reader.GetInt32(0),
                Descripcion = reader.GetString(1),
                RowVersion = (byte[])reader[2]
            };


        }

        public bool Existe(Marca marca)
        {

            try
            {
                var cadenaComando = "SELECT MarcaId, Descripcion FROM Marcas WHERE Descripcion=@des";
                var comando = new SqlCommand(cadenaComando, conexion);
                comando.Parameters.AddWithValue("@des", marca.Descripcion);
                var reader = comando.ExecuteReader();
                return reader.HasRows;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public void Guardar(Marca marca)
        {
            if (marca.MarcaId == 0)
            {
                try
                {
                    string cadenaComando =
                        "INSERT INTO Marcas (Descripcion) VALUES (@des)";
                    SqlCommand comando = new SqlCommand(cadenaComando, conexion);
                    comando.Parameters.AddWithValue("@des", marca.Descripcion);

                    comando.ExecuteNonQuery();
                    cadenaComando = "SELECT @@IDENTITY";
                    comando = new SqlCommand(cadenaComando, conexion);
                    marca.MarcaId = (int)(decimal)comando.ExecuteScalar();

                    cadenaComando = "SELECT RowVersion FROM Marcas WHERE MarcaId=@id";
                    comando = new SqlCommand(cadenaComando, conexion);
                    comando.Parameters.AddWithValue("@id", marca.MarcaId);
                    marca.RowVersion = (byte[])comando.ExecuteScalar();

                }
                catch (Exception)
                {
                    throw new Exception("Error al intentar guardar el registro");
                }

            }
            else
            {
                try
                {
                    string cadenaComando ="UPDATE Marcas SET Descripcion=@des WHERE MarcaId=@id";
                    SqlCommand comando = new SqlCommand(cadenaComando, conexion);
                    comando.Parameters.AddWithValue("@des", marca.Descripcion);
                    comando.Parameters.AddWithValue("@id", marca.MarcaId);
                    comando.ExecuteNonQuery();

                }
                catch (Exception e)
                {
                    throw new Exception("Error al intentar modificar el registro");
                }

            }
        }

        public void Borrar(int marcaId)
        {

            try
            {
                string cadenaComando = "DELETE FROM Marcas WHERE MarcaId=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, conexion);
                comando.Parameters.AddWithValue("@id", marcaId);
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(Marca m)
        {
            try
            {
                var cadenaComando = "SELECT COUNT(*) FROM VehiculosRegistrados WHERE MarcaId=@id";
                var comando = new SqlCommand(cadenaComando, conexion);
                comando.Parameters.AddWithValue("@id", m.MarcaId);
                return (int)comando.ExecuteScalar() > 0;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Marca GetMarcaPorId(int id)
        {

            Marca marca = null;
            try
            {
                var cadenaComando = "SELECT MarcaId, Descripcion FROM Marcas WHERE MarcaId=@id";
                var comando = new SqlCommand(cadenaComando, conexion);
                comando.Parameters.AddWithValue("@id", id);
                using (var reader = comando.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        marca = ConstruirMarca(reader);
                    }
                }
                return marca;

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}
