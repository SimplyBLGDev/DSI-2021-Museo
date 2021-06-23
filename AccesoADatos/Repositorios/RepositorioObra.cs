using System.Collections.Generic;
using System.Linq;

namespace AccesoADatos.Repositorios
{
    public class RepositorioObra : RepositorioBase<Obra>
    {
        private readonly MuseoEntities _baseDeDatos = new MuseoEntities();
        public bool ActualizarEntidad(Obra entidad)
        {
            if (entidad != null)
            {
                var entidadBase = _baseDeDatos.Obra.FirstOrDefault(x => x.Id == entidad.Id);

                entidad.Id = entidad.Id;

                _baseDeDatos.SaveChanges();
                return true;
            }
            return false;
        }

        public bool BorrarEntidad(Obra entidad)
        {
            if (entidad != null)
            {
                var entidadBase = _baseDeDatos.Obra.FirstOrDefault(x => x.Id == entidad.Id);
                _baseDeDatos.Obra.Remove(entidadBase);
                return true;
            }

            return false;
        }

        public bool GuardarEntidad(Obra entidad)
        {
            if (entidad != null)
            {
                _baseDeDatos.Obra.Add(entidad);
                _baseDeDatos.SaveChanges();
                return true;
            }

            return false;
        }

        public List<Obra> Listar()
        {
            return _baseDeDatos.Obra.ToList();
        }
    }
}
