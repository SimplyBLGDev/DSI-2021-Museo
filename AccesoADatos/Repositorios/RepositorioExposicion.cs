using System.Collections.Generic;
using System.Linq;

namespace AccesoADatos.Repositorios {
    public class RepositorioExposicion : RepositorioBase<Exposicion> {
        private readonly MuseoEntities _baseDeDatos = new MuseoEntities();

        public bool ActualizarEntidad(Exposicion entidad) {
            if (entidad != null) {
                var entidadBase = _baseDeDatos.Exposicion.FirstOrDefault(x => x.Id == entidad.Id);
                entidad.Id = entidad.Id;

                _baseDeDatos.SaveChanges();
                return true;
            }
            return false;
        }

        public bool BorrarEntidad(Exposicion entidad) {
            if (entidad != null) {
                var entidadBase = _baseDeDatos.Exposicion.FirstOrDefault(x => x.Id == entidad.Id);
                _baseDeDatos.Exposicion.Remove(entidadBase);
                return true;
            }

            return false;
        }

        public bool GuardarEntidad(Exposicion entidad) {
            if (entidad != null) {
                _baseDeDatos.Exposicion.Add(entidad);
                _baseDeDatos.SaveChanges();
                return true;
            }

            return true;
        }

        public List<Exposicion> Listar() {
            return _baseDeDatos.Exposicion.ToList();
        }

        public List<Exposicion> ListarExposicionesPorSede(int idSede) {
            return _baseDeDatos.Exposicion.Where(x => x.IdSede == idSede).ToList();
        }
    }
}
