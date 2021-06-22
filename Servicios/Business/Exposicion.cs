
using Servicios.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Business {
	public class Exposicion {
		
		private string nombre;
		private DateTime? fechaInicio;
		private DateTime? fechaFin;
		private Hora horaApertura;
		private Hora horaCierre;

		private List<DetalleExposicion> detalleExposicion { get; set; } = new List<DetalleExposicion>();


		public static implicit operator Exposicion(AccesoADatos.Exposicion tarifaBd)
		{
			var nuevo = new Exposicion();
			nuevo.nombre = tarifaBd.Nombre;
			nuevo.fechaInicio = tarifaBd.FechaInicio;
			nuevo.fechaFin = tarifaBd.FechaFin;
			nuevo.horaApertura = new Hora(int.Parse(tarifaBd.HoraApertura));
			nuevo.horaCierre = new Hora(int.Parse(tarifaBd.HoraCierra));
			nuevo.detalleExposicion = tarifaBd.DetalleExposicion.Select( x=> (DetalleExposicion)x).ToList();
			return nuevo;
		}

		public Hora CalcularDuracionVisita() {

			var duracionVisita = new Hora();

			detalleExposicion.ForEach(x =>
			{
				duracionVisita = duracionVisita + x.DuracionVisita();
			});

			return duracionVisita;
		}

		public bool EsVigente(DateTime fecha) {
			return (fechaFin == null || fecha < fechaFin) && fecha > fechaInicio;
		}
	}
}
