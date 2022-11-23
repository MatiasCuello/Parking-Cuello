using Parking.Entidades.Entidades;
using Parking.Servicios.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking.Windows.Helpers
{
    public class HelperCombos
    {
        public static void CargarDatosComboTiposVehiculos(ref ComboBox combo)
        {
            ServicioTiposVehiculos servicio = new ServicioTiposVehiculos();
            var lista = servicio.GetLista();
            var defaultTipoV = new TipoVehiculo()
            {
                TipoVehiculoId = 0,
                Descripcion = "<Seleccione Tipo de Vehiculo>"
            };
            lista.Insert(0, defaultTipoV);
            combo.DataSource = lista;
            combo.DisplayMember = "Descripcion";
            combo.ValueMember = "TipoVehiculoId";
            combo.SelectedIndex = 0;
        }
        public static void CargarDatosComboTiempos(ref ComboBox combo)
        {
            ServicioTiempos servicio = new ServicioTiempos();
            var lista = servicio.GetLista();
            var defaultTiempo = new Tiempo()
            {
                TiempoId = 0,
                Descripcion = "<Seleccione Tiempo>"
            };
            lista.Insert(0, defaultTiempo);
            combo.DataSource = lista;
            combo.DisplayMember = "Descripcion";
            combo.ValueMember = "TiempoId";
            combo.SelectedIndex = 0;
        }
        public static void CargarDatosComboSectores(ref ComboBox combo)
        {
            ServicioSectores servicio = new ServicioSectores();
            var lista = servicio.GetLista();
            var defaultSector = new Sector()
            {
                SectorId = 0,
                Descripcion = "<Seleccione Sector>"
            };
            lista.Insert(0, defaultSector);
            combo.DataSource = lista;
            combo.DisplayMember = "Descripcion";
            combo.ValueMember = "SectorId";
            combo.SelectedIndex = 0;
        }
        public static void CargarDatosComboLugares(ref ComboBox combo, Sector sector)
        {
            ServicioLugares servicio = new ServicioLugares();
            var lista = servicio.GetLista(sector);
            var defaultLugar = new Lugar()
            {
                LugarId = 0,
                Descripcion = "<Seleccione Lugar>"
            };
            lista.Insert(0, defaultLugar);
            combo.DataSource = lista;
            combo.DisplayMember = "Descripcion";
            combo.ValueMember = "LugarId";
            combo.SelectedIndex = 0;
        }
        public static void CargarDatosComboTarifas(ref ComboBox combo)
        {
            ServicioTarifas servicio = new ServicioTarifas();
            var lista = servicio.GetLista();
            var defaultTarifa = new Tarifa()
            {
                TarifaId = 0,
                Descripcion = "<Seleccione Tarifa>"
            };
            lista.Insert(0, defaultTarifa);
            combo.DataSource = lista;
            combo.DisplayMember = "Descripcion";
            combo.ValueMember = "TarifaId";
            combo.SelectedIndex = 0;
        }
    }
}
