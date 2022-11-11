﻿using Parking.Entidades.Entidades;
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
                Descripcion = "Seleccione Tipo de Vehiculo"
            };
            lista.Insert(0, defaultTipoV);
            combo.DataSource = lista;
            combo.DisplayMember = "Descripcion";
            combo.ValueMember = "TipoVehiculoId";
            combo.SelectedIndex = 0;
        }

    }
}