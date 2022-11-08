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
        private readonly RepositorioVehiculos repositorio;
        private readonly ConexionBD conexion;

        public ServicioVehiculos()
        {
            repositorio = new RepositorioVehiculos();
        }

        public List<Vehiculo> GetLista()
        {
            try
            {
                return repositorio.GetLista();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }

}


