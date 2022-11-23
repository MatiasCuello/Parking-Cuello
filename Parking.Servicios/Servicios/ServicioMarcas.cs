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
    public class ServicioMarcas
    {
        private RepositorioMarcas repositorio;

        public ServicioMarcas()
        {

        }

        public List<Marca> GetLista()
        {
            try
            {
                List<Marca> lista;
                using (var cn = ConexionBD.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioMarcas(cn);
                    lista = repositorio.GetLista();
                }

                return lista;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool Existe(Marca marca)
        {
            try
            {
                bool existe = true;
                using (var cn = ConexionBD.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioMarcas(cn);
                    existe = repositorio.Existe(marca);
                    return existe;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Guardar(Marca marca)
        {
            try
            {
                using (var cn = ConexionBD.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioMarcas(cn);
                    repositorio.Guardar(marca);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(Marca m)
        {
            try
            {
                using (var cn = ConexionBD.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioMarcas(cn);
                    return repositorio.EstaRelacionado(m);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Borrar(int marcaId)
        {
            try
            {
                using (var cn = ConexionBD.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioMarcas(cn);
                    repositorio.Borrar(marcaId);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
