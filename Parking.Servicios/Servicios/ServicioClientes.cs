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
        private readonly RepositorioClientes repositorio;
        private readonly ConexionBD conexion;
        public ServicioClientes()
        {
            repositorio = new RepositorioClientes();
        }
        

        public List<Cliente> GetLista()
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
