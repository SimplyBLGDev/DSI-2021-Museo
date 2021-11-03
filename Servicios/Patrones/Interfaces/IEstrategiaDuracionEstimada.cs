using Base.Business;
using System.Collections.Generic;

namespace Servicios.Patrones.Interfaces
{
    interface IEstrategiaDuracionEstimada
    {
        //Si la visita es completa, se deben obtener todas las exposiciones vigentes para la sede y sumar la duración resumida de cada obra para calcular la duración estimada
        //de la visita.
        //Si la visita es por exposición se suman la duración extendida de cada obra únicamente de las exposiciones temporales seleccionadas.
        Hora CalcularDuracionDeVisita(Sede sede  , List<Exposicion> exposiciones );
    }
}
