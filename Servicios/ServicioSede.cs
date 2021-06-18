
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
        private readonly MapperEntidades mapper = new MapperEntidades();

        public List<Tarifa> MostrarTarifasExistentes(Sede sede)
        {

            var sedeBase = mapper.Mapper.Map<AccesoADatos.Sede>(sede);
            var listadoTarifas = mapper.Mapper.Map<List<Tarifa>>(_servicioTarifa.MostrarTarifasExistentes(sedeBase));
            List<Tarifa> listadoTarifasVigentes = new List<Tarifa>();

            foreach (var tarifa in listadoTarifas)
            {
                if (tarifa.EsVigente(DateTime.Now))
                {
                    listadoTarifasVigentes.Add(tarifa);
                }
            }

            return listadoTarifasVigentes;
        }

        //preguntar como funciona la estructura Hora 
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
    }
}
