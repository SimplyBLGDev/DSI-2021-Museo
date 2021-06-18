using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Business {
	public class TipoEntrada {
		private string nombre;


		public static implicit operator TipoEntrada(AccesoADatos.TipoEntrada tarifaBd)
		{
			var nuevo = new TipoEntrada();
			nuevo.nombre = tarifaBd.Nombre;
			
			return nuevo;
		}

		public string GetNombre() {
			return nombre;
		}
	}
}
