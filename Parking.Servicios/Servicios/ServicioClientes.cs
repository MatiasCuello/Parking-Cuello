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

                    lista = repositorio.GetLista();



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

        public bool EstaRelacionado(Cliente c)
        {

            try
            {
                using (var cn = ConexionBD.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioClientes(cn);
                    return repositorio.EstaRelacionado(c);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public void Borrar(int clienteId)
        {
            try
            {
                using (var cn = ConexionBD.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepositorioClientes(cn);
                    repositorio.Borrar(clienteId);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        //public int Editar(Cliente cliente)
        //{
        //    try
        //    {
        //        using (var cn = ConexionBD.GetInstancia().AbrirConexion())
        //        {
        //            repositorio = new RepositorioClientes(cn);
        //            return repositorio.Editar(cliente);
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw new Exception(e.Message);
        //    }
        //}
    }
}
