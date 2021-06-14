using DSI2021.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI2021.Business {
	class Obra {
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
