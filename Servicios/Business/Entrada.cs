using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Business {
	public class Entrada {
		private Sede sede;
		private DateTime fechaVenta;
		private decimal monto;
		private int numero;
		public int Id { get; set; }


		public static implicit operator Entrada(AccesoADatos.Entrada entidadBd)
		{
			var nuevo = new Entrada();
			nuevo.fechaVenta = entidadBd.FechaVenta.Value;
			nuevo.monto = entidadBd.Monto ?? 0;
			nuevo.numero = int.Parse(entidadBd.Numero);
			nuevo.Id = entidadBd.Id;
			nuevo.sede = entidadBd.Sede;
			return nuevo;
		}


		public Sede GetSede() {
			return sede;
		}

		public bool ValidarHorarioEntrada(DateTime actual) {
			return actual.Date == fechaVenta.Date;
		}
	}
}
