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
    public class ServicioSectores
    {
        private RepositorioSectores repositorio;

        public ServicioSectores()
        {

        }

        public List<Sector> GetLista()
        {
            try
            {
                List<Sector> lista;
                using (var cn = ConexionBD.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioSectores(cn);
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
