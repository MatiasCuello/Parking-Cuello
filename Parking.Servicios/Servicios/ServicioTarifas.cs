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
    public class ServicioTarifas
    {
        private RepositorioTarifas repositorio;
        private RepositorioTiposVehiculos repoTiposVehiculos;
        private RepositorioTiempos repoTiempos;

        public ServicioTarifas()
        {

        }

        public List<Tarifa> GetLista()
        {
            try
            {
                List<Tarifa> lista;
                using (var cn = ConexionBD.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioTarifas(cn);
                    repoTiposVehiculos = new RepositorioTiposVehiculos(cn);
                    repoTiempos = new RepositorioTiempos(cn);
                    lista = repositorio.GetLista();
                    foreach (var tarifa in lista)
                    {
                        tarifa.TipoVehiculo = repoTiposVehiculos.GetTipoVehiculoPorId(tarifa.TipoVehiculoId);
                        tarifa.Tiempo = repoTiempos.GetTiempoPorId(tarifa.TiempoId);
                    }
                    return lista;

                }


            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
