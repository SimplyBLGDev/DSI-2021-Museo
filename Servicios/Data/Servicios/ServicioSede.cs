using AccesoADatos.Repositorios;
using Base.Business;
using System.Collections.Generic;

namespace Base.Data.Servicios {
	public class ServicioSede {
		private readonly RepositorioSede repositorioSede = new RepositorioSede();
		private readonly ServicioTarifa servicioTarifa = new ServicioTarifa();

		public Sede FetchSede(int id) {
			return repositorioSede.BuscarSede(new AccesoADatos.Sede { Id = id });
		}

		public List<Tarifa> FetchTarifasPorSede(Sede sede) {
			List<Tarifa> listadoTarifas = servicioTarifa.MostrarTarifasExistentes(sede);
			return listadoTarifas;
		}
	}
}
