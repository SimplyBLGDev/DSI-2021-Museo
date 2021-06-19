using Servicios.Data;
using System;

namespace Servicios.Business
{
	public class ReservaVisita {
		
		private Sede sede;
		private int cantidadAlumnos;
		private int cantidadAlumnosConfirmada;
		private Hora duracionEstimada;
		private DateTime? fechaHoraCreacion;
		private DateTime? fechaHoraReserva;
		private Hora horaFinReal;
		private Hora horaInicioReal;
		private int numeroReserva;



		public static implicit operator ReservaVisita(AccesoADatos.ReservaVisita tarifaBd)
		{
			var nuevo = new ReservaVisita();
			nuevo.cantidadAlumnos = tarifaBd.CantidadDeAlumnos ?? 0;
			nuevo.cantidadAlumnosConfirmada = tarifaBd.CantidadDeAlumnosAConfirmar ?? 0;
			nuevo.duracionEstimada = new Hora(string.IsNullOrEmpty(tarifaBd.DuracionEstimada) ? 0 : int.Parse(tarifaBd.DuracionEstimada));
			nuevo.fechaHoraCreacion = tarifaBd.FechaHoraCreacion;
			nuevo.fechaHoraReserva = tarifaBd.FechaHoraReserva;
			//nuevo.horaFinReal = new Hora(int.Parse(tarifaBd.HoraFinReal));
			//nuevo.horaInicioReal = new Hora(int.Parse(tarifaBd.HoraInicioReal));
			return nuevo;
		}


		public Sede GetSede() {
			return sede;
		}

		public bool ValidarHorarioReserva(DateTime fecha) {
			return fecha.Date == fechaHoraReserva.Value.Date;
		}

		public int GetCantidadDeAlumnosConfirmada()
		{
			return cantidadAlumnosConfirmada;
		}


		
	}
}
