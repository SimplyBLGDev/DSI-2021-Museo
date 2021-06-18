using Servicios.Data;
using System;

namespace Servicios.Business
{
	public class Obra {
		private string nombre;
		private int alto;
		private int ancho;
		private string codigoSensor;
		private string descripcion;
		private Hora duracionExtendida;
		private Hora duracionResumida;
		private DateTime fechaCreacion;
		private DateTime fechaPrimerIngreso;
		private int peso;
		private int valuacion;

		public Hora GetDuracionResumida() {
			return duracionResumida;
		}
	}
}
