
using AccesoADatos.Repositorios;
using Servicios.Business;
using Servicios.Data;
using System;
using System.Collections.Generic;

namespace Servicios
{
    public class ServicioReservas
    {
        private readonly RepositorioReservaVisita _repositorioReserva = new RepositorioReservaVisita();
        private readonly MapperEntidades mapper = new MapperEntidades();

        public int CantidadDeAlumnosConfirmados(Sede sede)
        {
            var listadoReservas = mapper.Mapper.Map<List<ReservaVisita>>(_repositorioReserva.ListarReservasPorSede(sede.Id));
            //List<Tarifa> listadoTarifasVigentes = new List<Tarifa>();
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
