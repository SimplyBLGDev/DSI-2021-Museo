
using AccesoADatos.Repositorios;
using Servicios.Business;
using Servicios.Data;
using System;
using System.Collections.Generic;

namespace Servicios
{
    public class ServicioEntrada
    {
        private readonly RepositorioEntrada _repositorioEntrada = new RepositorioEntrada();
        private readonly MapperEntidades mapper = new MapperEntidades();

        public int CantidadEntras(Sede sede)
        {
            var listadoEntradas = mapper.Mapper.Map<List<Entrada>>(_repositorioEntrada.ListarEntradasPorSede(sede.Id));
            var cantidad = 0;
            foreach (var entrada in listadoEntradas)
            {
                if (entrada.ValidarHorarioEntrada(DateTime.Now))
                {
                    cantidad++;
                }
            }

            return cantidad;
        }

        public int ObtenerUlTimoNumero(Sede sede)
        {
            var listadoEntradas = mapper.Mapper.Map<List<Entrada>>(_repositorioEntrada.Listar());
            var ultimaEntrada = listadoEntradas[listadoEntradas.Count - 1];
            return ultimaEntrada.Id + 1;
        }



    }
}
