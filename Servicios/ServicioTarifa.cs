
using AccesoADatos.Repositorios;
using AutoMapper;
using Servicios.Business;
using System.Collections.Generic;
using System.Linq;

namespace Servicios
{
    public class ServicioTarifa
    {
        private readonly RepositorioTarifa _repositorioTarifa = new RepositorioTarifa();

        public List<Tarifa> MostrarTarifasExistentes(Sede sede)
        {
            var listadoTarifas = _repositorioTarifa.ListarTarifaPorSede(sede.Id).Select( x=> (Tarifa)x).ToList();
            return listadoTarifas;
        }


        public List<Tarifa> ListarTarifas()
        {
            var listadoTarifas = _repositorioTarifa.Listar().Select(x => (Tarifa)x).ToList();
            return listadoTarifas;
        }


    }
}
