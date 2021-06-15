using AccesoADatos.Entidades;
using AccesoADatos.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class ServicioSede
    {

        private readonly ServicioTarifa _servicioTarifa = new ServicioTarifa();

        public List<Tarifa> MostrarTarifasExistentes(Sede sede)
        {
            var listadoTarifas = _servicioTarifa.MostrarTarifasExistentes(sede);
            List<Tarifa> listadoTarifasVigentes = new List<Tarifa>();

            foreach (var tarifa in listadoTarifas)
            {
                if (tarifa.EsVigente())
                {
                    tarifa.GetTipoDeEntrada();
                    tarifa.GetTipoVisita();
                    listadoTarifasVigentes.Add(tarifa);
                }
            }

            return listadoTarifasVigentes;
        }


    }
}
