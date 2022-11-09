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
        private RepositorioTiposVehiculos repositorioTiposVehiculos;

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
                    repositorioTiposVehiculos = new RepositorioTiposVehiculos(cn);
                    lista = repositorio.GetLista();
                    foreach (var cliente in lista)
                    {
                        cliente.TipoVehiculo = repositorioTiposVehiculos.GetTipoVehiculoPorId(cliente.TipoVehiculoId);
                    }


                    return lista;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public bool Existe(Cliente cliente)
        {
            try
            {
                bool existe = true;
                using (var cn = ConexionBD.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioClientes(cn);
                    existe = repositorio.Existe(cliente);
                    return existe;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Guardar(Cliente cliente)
        {
            try
            {
                using (var cn = ConexionBD.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioClientes(cn);
                    repositorio.Guardar(cliente);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
