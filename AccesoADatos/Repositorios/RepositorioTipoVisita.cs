using System.Collections.Generic;
using System.Linq;

namespace AccesoADatos.Repositorios
{
    public class RepositorioTipoVisita : RepositorioBase<TipoVisita>
    {

        private readonly MuseoEntities _baseDeDatos = new MuseoEntities();

        public bool ActualizarEntidad(TipoVisita entidad)
        {
            if (entidad != null)
            {
                var entidadBase = _baseDeDatos.TipoVisita.FirstOrDefault(x => x.Id == entidad.Id);

                //actualizar entidad
                ///entidad. = entidad.GetId();

                _baseDeDatos.SaveChanges();
                return true;
            }

            return false;
        }

        public bool BorrarEntidad(TipoVisita entidad)
        {
            if (entidad != null)
            {
                var entidadBase = _baseDeDatos.TipoVisita.FirstOrDefault(x => x.Id == entidad.Id);
                _baseDeDatos.TipoVisita.Remove(entidadBase);
                return true;
            }

            return false;
        }

        public bool GuardarEntidad(TipoVisita entidad)
        {
            if (entidad != null)
            {
                _baseDeDatos.TipoVisita.Add(entidad);
                _baseDeDatos.SaveChanges();
                return true;
            }

            return false;
        }

        public List<TipoVisita> Listar()
        {
          return  _baseDeDatos.TipoVisita.ToList();
        }
    }
}
