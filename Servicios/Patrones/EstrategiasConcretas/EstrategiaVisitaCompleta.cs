using Base.Business;
using Servicios.Patrones.Interfaces;
using System;
using System.Collections.Generic;

namespace Servicios.Patrones.EstrategiasConcretas {

	public class EstrategiaVisitaCompleta : IEstrategiaDuracionEstimada {
		public Hora CalcularDuracionVisita(Sede sede, List<Exposicion> exposiciones) {
			Hora duracionVisita = new Hora(0);
			
			foreach (Exposicion exposicion in exposiciones)
				if (exposicion.EsVigente(DateTime.Now))
					duracionVisita += exposicion.CalcularDuracionVisita();

			return duracionVisita;
		}
	}
}
