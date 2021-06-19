
using AccesoADatos.Repositorios;
using Servicios.Business;
using Servicios.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Servicios
{
    public class ServicioEntrada
    {
        private readonly RepositorioEntrada _repositorioEntrada = new RepositorioEntrada();
        private readonly MapperEntidades mapper = new MapperEntidades();

        public int CantidadEntradasReservadas(Sede sede)
        {
            var listadoEntradas = _repositorioEntrada.ListarEntradasPorSede(sede.Id).Select(x => (Entrada)x).ToList();
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
            var listadoEntradas = _repositorioEntrada.Listar().Select(x => (Entrada)x).ToList();
            var ultimaEntrada = listadoEntradas[listadoEntradas.Count - 1];
            return ultimaEntrada.Id + 1;
        }



    }
}
