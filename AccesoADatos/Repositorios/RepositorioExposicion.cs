using AccesoADatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoADatos.Repositorios
{
    public class RepositorioExposicion : RepositorioBase<Exposicion>
    {

        private readonly MuseoEntities _baseDeDatos = new MuseoEntities();

        public bool ActualizarEntidad(Exposicion entidad)
        {
            if (entidad != null)
            {
                var entidadBase = _baseDeDatos.Exposicion.FirstOrDefault(x => x.Id == entidad.Id);

                entidad.Id = entidad.Id;

                _baseDeDatos.SaveChanges();
                return true;
            }
            return false;
        }

        public bool BorrarEntidad(Exposicion entidad)
        {
            if (entidad != null)
            {
                var entidadBase = _baseDeDatos.Exposicion.FirstOrDefault(x => x.Id == entidad.Id);
                _baseDeDatos.Exposicion.Remove(entidadBase);
                return true;
            }

            return false;
        }

        public Exposicion GuardarEntidad(Exposicion entidad)
        {
            if (entidad != null)
            {
                _baseDeDatos.Exposicion.Add(entidad);
                _baseDeDatos.SaveChanges();
                return entidad;
            }

            return new Exposicion();
        }

        public List<Exposicion> Listar()
        {
            return _baseDeDatos.Exposicion.ToList();
        }
    }
}
