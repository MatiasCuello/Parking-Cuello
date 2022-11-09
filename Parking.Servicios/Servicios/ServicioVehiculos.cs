using Parking.Entidades.Entidades;
using Parking.Repositorios;
using Parking.Repositorios.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Servicios.Servicios
{
    public class ServicioVehiculos
    {
        private RepositorioVehiculos repositorio;

        public ServicioVehiculos()
        {

        }

        public List<Vehiculo> GetLista()
        {
            try
            {
                List<Vehiculo> lista;
                using (var cn = ConexionBD.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioVehiculos(cn);
                    lista = repositorio.GetLista();
                }

                return lista;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }

}


