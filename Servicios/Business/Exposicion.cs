using Base.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Base.Business {
	public class Exposicion {
		
		private string nombre;
		private DateTime? fechaInicio;
		private DateTime? fechaFin;
		private Hora horaApertura;
		private Hora horaCierre;

		private List<DetalleExposicion> detalleExposicion { get; set; } = new List<DetalleExposicion>();

		public static implicit operator Exposicion(AccesoADatos.Exposicion tarifaBd) {
			Exposicion nuevo = new Exposicion {
				nombre = tarifaBd.Nombre,
				fechaInicio = tarifaBd.FechaInicio,
				fechaFin = tarifaBd.FechaFin,
				horaApertura = new Hora(int.Parse(tarifaBd.HoraApertura)),
				horaCierre = new Hora(int.Parse(tarifaBd.HoraCierra)),
				detalleExposicion = tarifaBd.DetalleExposicion.Select(x => (DetalleExposicion)x).ToList()
			};
			return nuevo;
		}

		public string GetNombre() {
			return nombre;
		}

		public Hora CalcularDuracionObrasExpuestas() {

			var duracionVisita = new Hora();

			detalleExposicion.ForEach(x => {
				duracionVisita += x.DuracionVisita();
			});

			return duracionVisita;
		}

		public Hora CalcularDuracionVisitaExtendida() {
			var duracionVisita = new Hora();

			detalleExposicion.ForEach(x => {
				duracionVisita += x.DuracionVisitaExtendida();
			});

			return duracionVisita;
		}

		public bool EsVigente(DateTime fecha) {
			return (fechaFin == null || fecha < fechaFin) && fecha > fechaInicio;
		}
	}
}
