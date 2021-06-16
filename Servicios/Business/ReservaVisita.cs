using Servicios.Data;
using System;

namespace Servicios.Business
{
	public class ReservaVisita {
		private Sede sede;
		private int cantidadAlumnos;
		private int cantidadAlumnosConfirmada;
		private Hora duracionEstimada;
		private DateTime fechaHoraCreacion;
		private DateTime fechaHoraReserva;
		private Hora horaFinReal;
		private Hora horaInicioReal;
		private int numeroReserva;

		public Sede GetSede() {
			return sede;
		}

		private bool ValidarHorarioReserva(DateTime fecha) {
			return fecha.Date == fechaHoraReserva.Date;
		}
	}
}
