
using AccesoADatos.Repositorios;
using Servicios.Business;
using Servicios.Data;
using System;
using System.Collections.Generic;

namespace Servicios
{
    public class ServicioSede
    {

        private readonly ServicioTarifa _servicioTarifa = new ServicioTarifa();
        private readonly ServicioExposiciones _servicioExposiciones = new ServicioExposiciones();
        private readonly RepositorioSede _sedeRepositorio = new RepositorioSede();

        public List<Tarifa> MostrarTarifasExistentes(Sede sede)
        {

            var listadoTarifas = _servicioTarifa.MostrarTarifasExistentes(sede);

            return listadoTarifas;
        }

        public Hora MostrarDuracionDeVisita(Sede sede)
        {
            Hora duracionVisita = new Hora(0);
            var listadoDeExposiciones = _servicioExposiciones.MostrarExposicionesVigentesPorSede(sede);

            foreach (var exposicion in listadoDeExposiciones)
            {
                duracionVisita = duracionVisita + exposicion.CalcularDuracionVisita();
            }

            return duracionVisita;
        }

        public Sede MostrarInformacionSede(Sede sede)
        {
           
            return (Sede)_sedeRepositorio.BuscarSede(new AccesoADatos.Sede { Id = 1 });

        }
    }
}
