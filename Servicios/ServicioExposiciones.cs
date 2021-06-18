
using AccesoADatos.Repositorios;
using AutoMapper;
using Servicios.Business;
using System;
using System.Collections.Generic;

namespace Servicios
{
    public class ServicioExposiciones
    {

        private readonly RepositorioExposicion _repositorioExposicion = new RepositorioExposicion();
        private readonly MapperEntidades mapper = new MapperEntidades();

        public List<Exposicion> MostrarExposicionesVigentesPorSede(Sede sede)
        {
            var exposiciones = _repositorioExposicion.ListarExposicionesPorSede(sede.Id);
            var exposionesDeSede = mapper.Mapper.Map<List<Exposicion>>(exposiciones);
            List<Exposicion> listadoExposiciones = new List<Exposicion>();

            foreach (var exposicion in exposionesDeSede)
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
