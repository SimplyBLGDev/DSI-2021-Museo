using DSI2021.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI2021.Business {
	class ReservaVisita {
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
