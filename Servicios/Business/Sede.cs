using AccesoADatos.Repositorios;
using Servicios.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Business {
	public class Sede {

		private readonly ServicioSede _servicioSede = new ServicioSede();
		private readonly ServicioExposiciones _servicioExposiciones = new ServicioExposiciones();

		public int Id { get; set; }

		private int _cantidadMaximaVisitantes { get; set; }

		private string _nombre { get; set; }
		private int _cantMaxPorGuia { get; set; }

		private List<Exposicion> _exposiciones { get; set; }


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
			nuevo._cantidadMaximaVisitantes = tarifaBd.CantMaximaVisitantes ?? 0;
			nuevo._cantMaxPorGuia = tarifaBd.CantMaxPorGuia ?? 0;
			nuevo._nombre = tarifaBd.Nombre;
			return nuevo;
		}



		public int GetCantidadMaximaVisitantes()
		{
			return _cantidadMaximaVisitantes;
		}

		//patron experto
        public List<Tarifa> MostrarTarifasExistentes()
		{
			var tarifas =_servicioSede.MostrarTarifasExistentes(this);
			List<Tarifa> tarifasValidas = new List<Tarifa>();

			foreach (Tarifa tarifa in tarifas)
				if (tarifa.EsVigente(DateTime.Now))
					tarifasValidas.Add(tarifa);

			return tarifasValidas;
		}

		public Hora MostrarDuracionDeVisita(Sede sede)
		{
			Hora duracionVisita = new Hora(0);
			_exposiciones = _servicioExposiciones.MostrarExposicionesPorSede(sede);

			foreach (var exposicion in _exposiciones)
			{
				if (exposicion.EsVigente(DateTime.Now))
				{
					duracionVisita = duracionVisita + exposicion.CalcularDuracionVisita();
				}
			}

			return duracionVisita;
		}

}
}
