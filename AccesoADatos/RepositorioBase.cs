using System.Collections.Generic;

namespace AccesoADatos {
    public interface RepositorioBase<T> where T : class {
        bool GuardarEntidad(T entidad);
        bool BorrarEntidad(T entidad);
        bool ActualizarEntidad(T entidad);
        List<T> Listar();
    }
}
