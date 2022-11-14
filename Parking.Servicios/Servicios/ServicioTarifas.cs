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
                List<Tarifa> lista=null;
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

        public bool Existe(Tarifa tarifa)
        {
            try
            {
                bool existe = true;
                using (var cn = ConexionBD.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioTarifas(cn);
                    existe = repositorio.Existe(tarifa);
                    return existe;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Agregar(Tarifa tarifa)
        {
            try
            {
                int registros = 0;
                using (var cn = ConexionBD.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioTarifas(cn);
                    registros=repositorio.Agregar(tarifa);
                }
                return registros;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(Tarifa tarifa)
        {
            try
            {
                using (var cn = ConexionBD.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioTarifas(cn);
                    return repositorio.EstaRelacionado(tarifa);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Borrar(int tarifaId)
        {
            try
            {
                using (var cn = ConexionBD.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioTarifas(cn);
                    repositorio.Borrar(tarifaId);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        //public Tarifa GetTarifaPorId(int tarifaId)
        //{
        //    try
        //    {
        //        Tarifa tarifa = null;
        //        using (var cn = ConexionBD.GetInstancia().AbrirConexion())
        //        {
        //            repositorio = new RepositorioTarifas(cn);
        //            tarifa = repositorio.GetTarifaPorId(tarifaId);
        //        }

        //        return tarifa;
        //    }
        //    catch (Exception e)
        //    {
        //        throw new Exception(e.Message);
        //    }
        //}

        public int Editar(Tarifa tarifa)
        {
            try
            {
                int registros = 0;
                using (var cn = ConexionBD.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioTarifas(cn);

                    registros = repositorio.Editar(tarifa);
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
