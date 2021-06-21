
using AccesoADatos.Repositorios;
using AutoMapper;
using Servicios.Business;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Servicios
{
    public class ServicioExposiciones
    {

        private readonly RepositorioExposicion _repositorioExposicion = new RepositorioExposicion();


        public List<Exposicion> MostrarExposicionesPorSede(Sede sede)
        {
            var exposiciones = _repositorioExposicion.ListarExposicionesPorSede(sede.Id);
            var exposicionesBussiness = exposiciones.Select(x => (Exposicion)x).ToList();

            return exposicionesBussiness;
        }


        public List<Exposicion> MostrarExposicionesVigentesPorSede(Sede sede)
        {
            var exposiciones = _repositorioExposicion.ListarExposicionesPorSede(sede.Id);
            var exposicionesBussiness = exposiciones.Select(x => (Exposicion)x).ToList();
            List<Exposicion> listadoExposiciones = new List<Exposicion>();

            foreach (var exposicion in exposicionesBussiness)
            {
                if (exposicion.EsVigente(DateTime.Now))
                {
                    listadoExposiciones.Add(exposicion);
                }
            }

            return listadoExposiciones;
        }


    }
}
