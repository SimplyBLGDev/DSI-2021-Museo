using AccesoADatos;
using AccesoADatos.Repositorios;
using AutoMapper;
using System.Collections.Generic;

namespace Servicios
{
    public class ServicioTarifa
    {

        private readonly RepositorioTarifa _repositorioTarifa = new RepositorioTarifa();

        public List<Tarifa> MostrarTarifasExistentes(Sede sede)
        {
            return _repositorioTarifa.ListarTarifaPorSede(sede.Id);
        }


    }
}
