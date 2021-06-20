
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
            return ultimaEntrada.GetNumero() + 1;
        }


        public bool RegistraEntrada(Entrada nuevaEntrada)
        {
            var entidadDb = new AccesoADatos.Entrada();
            entidadDb.FechaVenta = DateTime.Now;
            entidadDb.Monto = nuevaEntrada.GetMonto();
            entidadDb.Numero = nuevaEntrada.GetNumero().ToString();
            entidadDb.IdSede = nuevaEntrada.GetSede().Id;
            entidadDb.IdTarifa = nuevaEntrada.GetTarifa().GetNumeroTarifa();

            _repositorioEntrada.GuardarEntidad(entidadDb);

            return true;
        }



    }
}
