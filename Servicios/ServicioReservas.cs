
using AccesoADatos.Repositorios;
using Servicios.Business;
using Servicios.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Servicios
{
    public class ServicioReservas
    {
        private readonly RepositorioReservaVisita _repositorioReserva = new RepositorioReservaVisita();

        public int CantidadDeAlumnosConfirmados(Sede sede)
        {
            var listadoReservas = _repositorioReserva.ListarReservasPorSede(sede.Id).Select(x => (ReservaVisita)x).ToList() ;
            var cantidad = 0;
            foreach (var reserva in listadoReservas)
            {
                if (reserva.ValidarHorarioReserva(DateTime.Now))
                {
                    cantidad = cantidad + reserva.GetCantidadDeAlumnosConfirmada();
                }
            }

            return cantidad;
        }

     
    }
}
