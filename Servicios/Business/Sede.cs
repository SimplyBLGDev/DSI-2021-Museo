using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Business {
	public class Sede {
		public int Id { get; set; }

		private int _cantidadMaximaVisitantes { get; set; }

		private string _nombre { get; set; }
		private int _cantMaxPorGuia { get; set; }


		public int CantMaxPorGuia
		{
			get
			{
				return _cantMaxPorGuia;
			}
			set
			{
				_cantMaxPorGuia = value;
			}
		}

		public string Nombre
		{
			get
			{
				return _nombre;
			}
			set
			{
				_nombre = value;
			}
		}

		public static implicit operator Sede(AccesoADatos.Sede tarifaBd)
		{
			var nuevo = new Sede();
			nuevo.Id = tarifaBd.Id;
			nuevo._cantidadMaximaVisitantes = tarifaBd.CantMaximaVisitantes ?? 0 ;
			nuevo._cantMaxPorGuia = tarifaBd.CantMaxPorGuia ?? 0;
			nuevo._nombre = tarifaBd.Nombre;
			return nuevo;
		}



		public int GetCantidadMaximaVisitantes()
		{
			return _cantidadMaximaVisitantes;
		}
	}
}
