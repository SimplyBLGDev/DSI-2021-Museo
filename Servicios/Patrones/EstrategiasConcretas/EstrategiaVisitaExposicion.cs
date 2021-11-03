using Base.Business;
using Servicios.Patrones.Interfaces;
using System.Collections.Generic;

namespace Servicios.Patrones.EstrategiasConcretas {

   public class EstrategiaVisitaExposicion : IEstrategiaDuracionEstimada {
		public Hora CalcularDuracionVisita(Sede sede, List<Exposicion> exposiciones) {
			Hora duracionVisita = new Hora(0);

			foreach (Exposicion exposicion in exposiciones)
				duracionVisita += exposicion.CalcularDuracionVisitaExtendida();

			return duracionVisita;
		}
	}
}
