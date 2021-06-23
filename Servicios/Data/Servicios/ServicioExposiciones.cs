using AccesoADatos.Repositorios;
using Base.Business;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Base.Data.Servicios {
	public class ServicioExposiciones {
		private readonly RepositorioExposicion repositorioExposicion = new RepositorioExposicion();

		public List<Exposicion> GetExposicionesPorSede(Sede sede) {
			List<AccesoADatos.Exposicion> exposiciones = repositorioExposicion.ListarExposicionesPorSede(sede.id);
			List<Business.Exposicion> exposicionesBussiness = exposiciones.Select(x => (Business.Exposicion)x).ToList();

			return exposicionesBussiness;
		}

		public List<Exposicion> GetExposicionesVigentesPorSede(Sede sede) {
			List<Exposicion> exposicionesBussiness = GetExposicionesPorSede(sede);
			List<Exposicion> listadoExposiciones = new List<Exposicion>();

			foreach (var exposicion in exposicionesBussiness)
				if (exposicion.EsVigente(DateTime.Now))
					listadoExposiciones.Add(exposicion);

			return listadoExposiciones;
		}
	}
}
