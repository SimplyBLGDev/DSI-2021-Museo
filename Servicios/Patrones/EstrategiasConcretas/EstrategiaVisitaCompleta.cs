using Base.Business;
using Servicios.Patrones.Interfaces;
using System;
using System.Collections.Generic;

namespace Servicios.Patrones.EstrategiasConcretas {

	public class EstrategiaVisitaCompleta : IEstrategiaDuracionEstimada {
		public Hora CalcularDuracionVisita(Sede sede, List<Exposicion> exposiciones) {
			return sede.CalcularDuracionExposicionesVigentes();
		}
	}
}
