using AccesoADatos.Repositorios;
using Base.Business;
using System.Collections.Generic;
using System.Linq;

namespace Base.Data.Servicios {
	public class ServicioTarifa {
		private readonly RepositorioTarifa repositorioTarifa = new RepositorioTarifa();

		public List<Tarifa> MostrarTarifasExistentes(Sede sede) {
			List<AccesoADatos.Tarifa> tarifasDatos = repositorioTarifa.ListarTarifaPorSede(sede.id);
			List<Tarifa> listadoTarifas = tarifasDatos.Select( x=> (Tarifa)x).ToList(); // Convertir AccesoADatos -> Business

			return listadoTarifas;
		}

		public List<Tarifa> ListarTarifas() {
			List<AccesoADatos.Tarifa> tarifasDatos = repositorioTarifa.Listar();
			List<Tarifa> listadoTarifas = tarifasDatos.Select(x => (Tarifa)x).ToList(); // Convertir AccesoADatos -> Business

			return listadoTarifas;
		}
	}
}
