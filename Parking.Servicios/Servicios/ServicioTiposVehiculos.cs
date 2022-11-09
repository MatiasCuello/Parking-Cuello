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
    public class ServicioTiposVehiculos
    {
        private RepositorioTiposVehiculos repositorio;

        public ServicioTiposVehiculos()
        {

        }

        public List<TipoVehiculo> GetLista()
        {
            try
            {
                List<TipoVehiculo> lista;
                using (var cn = ConexionBD.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioTiposVehiculos(cn);
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


