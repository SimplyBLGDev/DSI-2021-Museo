using AccesoADatos.Repositorios;
using Servicios.Business;
using System.Collections.Generic;

namespace Servicios {
    public class ServicioSede {
        private readonly ServicioTarifa _servicioTarifa = new ServicioTarifa();
        private readonly ServicioExposiciones _servicioExposiciones = new ServicioExposiciones();
        private readonly RepositorioSede _sedeRepositorio = new RepositorioSede();

        public List<Tarifa> MostrarTarifasExistentes(Sede sede) {
            var listadoTarifas = _servicioTarifa.MostrarTarifasExistentes(sede);
            return listadoTarifas;
        }

        public Sede MostrarInformacionSede(Sede sede) {
            return _sedeRepositorio.BuscarSede(new AccesoADatos.Sede { Id = 1 });
        }
    }
}
