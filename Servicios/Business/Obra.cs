using Servicios.Data;
using System;

namespace Servicios.Business {
	public class Obra {
		private string nombre;
		private decimal alto;
		private decimal ancho;
		private string codigoSensor;
		private string descripcion;
		private Hora duracionExtendida;
		private Hora duracionResumida;
		private DateTime? fechaCreacion;
		private DateTime? fechaPrimerIngreso;
		private decimal peso;
		private decimal valuacion;

		public static implicit operator Obra(AccesoADatos.Obra entidadBd) {
			var nuevo = new Obra();
			nuevo.nombre = entidadBd.NombreObra;
			nuevo.alto = entidadBd.Alto ?? 0;
			nuevo.ancho = entidadBd.Ancho ?? 0;
			nuevo.codigoSensor = entidadBd.CodigoSensor;
			nuevo.descripcion = entidadBd.Descripcion;
			nuevo.duracionExtendida = new Hora ( entidadBd.DuracionExtendida ?? 0);
			nuevo.duracionResumida = new Hora(entidadBd.DuracionResumida ?? 0);
			nuevo.fechaCreacion = entidadBd.FechaCreacion;
			nuevo.fechaPrimerIngreso = entidadBd.FechaPrimeroIngreso;
			nuevo.peso = entidadBd.Peso ?? 0;
			nuevo.valuacion = entidadBd.Valuacion ?? 0;
			return nuevo;
		}

		public Hora GetDuracionResumida() {
			return duracionResumida;
		}
	}
}
