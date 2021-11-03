using Base.Business;
using Servicios.Patrones.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Patrones.EstrategiasConcretas
{
   public class EstrategiaVisitaExposicion : IEstrategiaDuracionEstimada
    {
        public Hora CalcularDuracionDeVisita(Sede sede, List<Exposicion> exposiciones)
        {
            Hora duracionVisita = new Hora(0);

            foreach (Exposicion exposicion in exposiciones)
                    duracionVisita += exposicion.CalcularDuracionVisitaExtendida();

            return duracionVisita;
        }
    }
}
