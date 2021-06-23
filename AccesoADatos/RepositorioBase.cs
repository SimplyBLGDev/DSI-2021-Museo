using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoADatos
{
    public interface RepositorioBase<T> where T : class
    {
        bool GuardarEntidad(T entidad);
        bool BorrarEntidad(T entidad);
        bool ActualizarEntidad(T entidad);
        List<T> Listar();
    }
}
