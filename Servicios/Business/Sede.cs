using Base.Data;
using System;
using System.Collections.Generic;

namespace Base.Business {
	public class Sede {
		public int id;
		private int cantidadMaximaVisitantes;
		private string nombre;
		private int cantMaxPorGuia;

		public int CantMaxPorGuia {
			get {
				return cantMaxPorGuia;
			}
			set {
				cantMaxPorGuia = value;
			}
		}
		public string Nombre {
			get {
				return nombre;
			}
			set {
				nombre = value;
			}
		}

		public static implicit operator Sede(AccesoADatos.Sede tarifaBd) {
			Sede nuevo = new Sede();
			nuevo.id = tarifaBd.Id;
			nuevo.cantidadMaximaVisitantes = tarifaBd.CantMaximaVisitantes ?? 0;
			nuevo.cantMaxPorGuia = tarifaBd.CantMaxPorGuia ?? 0;
			nuevo.nombre = tarifaBd.Nombre;
			return nuevo;
		}

		public int GetCantidadMaximaVisitantes() {
			return cantidadMaximaVisitantes;
		}

		public List<Tarifa> MostrarTarifasExistentes() {
			List<Tarifa> tarifas = Persistencia.FetchTarifasPorSede(this);
			List<Tarifa> tarifasValidas = new List<Tarifa>();

			foreach (Tarifa tarifa in tarifas)
				if (tarifa.EsVigente(DateTime.Now))
					tarifasValidas.Add(tarifa);

			return tarifasValidas;
		}

		public Hora CalcularDuracionVisita() {
			Hora duracionVisita = new Hora(0);
			List<Exposicion> exposiciones = Persistencia.FetchExposicionesPorSede(this);

			foreach (Exposicion exposicion in exposiciones)
				if (exposicion.EsVigente(DateTime.Now))
					duracionVisita += exposicion.CalcularDuracionVisita();

			return duracionVisita;
		}
	}
}
