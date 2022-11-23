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
        private RepositorioTiposVehiculos repoTiposVehiculos;
        private RepositorioSectores repoSectores;
        private RepositorioLugares repoLugares;

        public ServicioVehiculos()
        {

        }

        public List<Vehiculo> GetLista()
        {
            try
            {
                List<Vehiculo> lista = null;
                using (var cn = ConexionBD.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioVehiculos(cn);
                    repoTiposVehiculos = new RepositorioTiposVehiculos(cn);
                    repoSectores = new RepositorioSectores(cn);
                    repoLugares = new RepositorioLugares(cn);
                    lista = repositorio.GetLista();
                    foreach (var vehiculo in lista)
                    {
                        vehiculo.TipoVehiculo = repoTiposVehiculos.GetTipoVehiculoPorId(vehiculo.TipoVehiculoId);
                        vehiculo.Sector = repoSectores.GetSectorPorId(vehiculo.SectorId);
                        vehiculo.Lugar = repoLugares.GetLugarPorId(vehiculo.LugarId);
                    }
                    return lista;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Agregar(Vehiculo vehiculo)
        {
            try
            {
                int registros = 0;
                using (var cn = ConexionBD.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioVehiculos(cn);
                    registros = repositorio.Agregar(vehiculo);
                }
                return registros;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool Existe(Vehiculo vehiculo)
        {
            try
            {
                bool existe = true;
                using (var cn = ConexionBD.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioVehiculos(cn);
                    existe = repositorio.Existe(vehiculo);
                    return existe;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(Vehiculo vehiculo)
        {
            try
            {
                using (var cn = ConexionBD.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioVehiculos(cn);
                    return repositorio.EstaRelacionado(vehiculo);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Borrar(int vehiculoId)
        {
            try
            {
                using (var cn = ConexionBD.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioVehiculos(cn);
                    repositorio.Borrar(vehiculoId);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Editar(Vehiculo vehiculo)
        {
            try
            {
                int registros = 0;
                using (var cn = ConexionBD.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioVehiculos(cn);
                    registros = repositorio.Editar(vehiculo);
                }

                return registros;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}
