
using Servicios.Business;
using System;
using System.Collections.Generic;

namespace Servicios
{
    public class ServicioSede
    {

        private readonly ServicioTarifa _servicioTarifa = new ServicioTarifa();
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


    }
}
