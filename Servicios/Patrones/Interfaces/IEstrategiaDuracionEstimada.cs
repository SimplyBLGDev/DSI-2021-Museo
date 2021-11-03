using Base.Business;
using System.Collections.Generic;

namespace Servicios.Patrones.Interfaces {
	interface IEstrategiaDuracionEstimada {
		Hora CalcularDuracionVisita(Sede sede, List<Exposicion> exposiciones);
	}
}
