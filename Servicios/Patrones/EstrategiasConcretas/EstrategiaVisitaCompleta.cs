using Base.Business;
using Servicios.Patrones.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Patrones.EstrategiasConcretas
{
    public class EstrategiaVisitaCompleta : IEstrategiaDuracionEstimada
    {

        public Hora CalcularDuracionDeVisita(Sede sede, List<Exposicion> exposiciones)
        {
            Hora duracionVisita = new Hora(0);
            
            foreach (Exposicion exposicion in exposiciones)
                if (exposicion.EsVigente(DateTime.Now))
                    duracionVisita += exposicion.CalcularDuracionVisita();

            return duracionVisita;
        }
    }
}
