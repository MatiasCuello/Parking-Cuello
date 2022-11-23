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
    public class ServicioLugares
    {
        private RepositorioLugares repositorio;
        private RepositorioSectores repoSectores;

        public ServicioLugares()
        {

        }

        public List<Lugar> GetLista(Sector sector=null)
        {
            try
            {
                List<Lugar> lista;
                using (var cn = ConexionBD.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioLugares(cn);
                    repoSectores = new RepositorioSectores(cn);
                    lista = repositorio.GetLista(sector);
                    foreach (var lugar in lista)
                    {
                        lugar.Sector = repoSectores.GetSectorPorId(lugar.SectorId);
                    }
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
