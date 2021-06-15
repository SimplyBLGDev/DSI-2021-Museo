using AccesoADatos.Entidades;
using AccesoADatos.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class ServicioTarifa
    {

        private readonly RepositorioTarifa _repositorioTarifa = new RepositorioTarifa();

        public List<Tarifa> MostrarTarifasExistentes(Sede sede)
        {

            //return _repositorioTarifa.ListarTarifaPorSede(sede.Id);
            return new List<Tarifa>();
        }


    }
}
