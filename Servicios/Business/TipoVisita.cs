using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Business {
	public class TipoVisita {
		private string nombre;

		public static implicit operator TipoVisita(AccesoADatos.TipoVisita tarifaBd)
		{
			var nuevo = new TipoVisita();
			nuevo.nombre = tarifaBd.Nombre;

			return nuevo;
		}
		public string GetNombre() {
			return nombre;
		}
	}
}
