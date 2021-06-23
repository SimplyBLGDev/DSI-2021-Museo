using AccesoADatos.Repositorios;
using Base.Business;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Base.Data.Servicios {
	public class ServicioReservas {
		private readonly RepositorioReservaVisita repositorioReserva = new RepositorioReservaVisita();

		public int FetchCantidadAlumnosConfirmados(Sede sede) {
			var listadoReservas = repositorioReserva.ListarReservasPorSede(sede.id);
			List<ReservaVisita> listadoReservasBusiness = listadoReservas.Select(x => (ReservaVisita)x).ToList();
			int cantidad = 0;

			foreach (ReservaVisita reserva in listadoReservasBusiness)
				if (reserva.ValidarHorarioReserva(DateTime.Now))
					cantidad += reserva.GetCantidadDeAlumnosConfirmada();

			return cantidad;
		}
	}
}
