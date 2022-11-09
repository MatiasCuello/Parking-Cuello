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
    public class ServicioClientes
    {
        private RepositorioClientes repositorio;
        private RepositorioVehiculos repositorioVehiculos;

        public ServicioClientes()
        {

        }

        public List<Cliente> GetLista()
        {
            try
            {
                List<Cliente> lista = null;
                using (var cn = ConexionBD.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioClientes(cn);
                    repositorioVehiculos = new RepositorioVehiculos(cn);
                    lista = repositorio.GetLista();
                    foreach (var cliente in lista)
                    {
                        cliente.Vehiculo = repositorioVehiculos.GetVehiculoPorId(cliente.VehiculoId);
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
