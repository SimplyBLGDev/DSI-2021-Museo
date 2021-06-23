using System.Collections.Generic;
using System.Linq;

namespace AccesoADatos.Repositorios
{
    public class RepositorioTipoEntrada : RepositorioBase<TipoEntrada>
    {

        private readonly MuseoEntities _baseDeDatos = new MuseoEntities();

        public bool ActualizarEntidad(TipoEntrada entidad)
        {
            if (entidad != null)
            {
                var entidadBase = _baseDeDatos.TipoEntrada.FirstOrDefault(x => x.Id == entidad.Id);

                //actualizar entiendad
                //entidad.Id = entidad.Id;

                _baseDeDatos.SaveChanges();
                return true;
            }

            return false;
        }

        public bool BorrarEntidad(TipoEntrada entidad)
        {
            if (entidad != null)
            {
                var entidadBase = _baseDeDatos.TipoEntrada.FirstOrDefault(x => x.Id == entidad.Id);
                _baseDeDatos.TipoEntrada.Remove(entidadBase);
                return true;
            }

            return false;
        }

        public bool GuardarEntidad(TipoEntrada entidad)
        {
            if (entidad != null)
            {
                _baseDeDatos.TipoEntrada.Add(entidad);
                _baseDeDatos.SaveChanges();
                return true;
            }

            return false;
        }

        public List<TipoEntrada> Listar()
        {
            return _baseDeDatos.TipoEntrada.ToList();
        }
    }
}
