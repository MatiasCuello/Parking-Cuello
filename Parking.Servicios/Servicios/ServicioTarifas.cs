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

        public ServicioTarifas()
        {

        }

        public List<Tarifa> GetLista()
        {
            try
            {
                List<Tarifa> lista=null;
                using (var cn = ConexionBD.GetInstancia().AbrirConexion())
                {
                    repoTiposVehiculos = new RepositorioTiposVehiculos(cn);
                    repositorio = new RepositorioTarifas(cn);
                    lista = repositorio.GetLista();
                    foreach (var tarifa in lista)
                    {
                        tarifa.TipoVehiculo = repoTiposVehiculos.GetTipoVehiculoPorId(tarifa.TipoVehiculoId);
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
