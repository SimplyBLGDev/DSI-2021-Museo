using System.Collections.Generic;
using System.Linq;

namespace AccesoADatos.Repositorios
{
    public class RepositorioEntrada : RepositorioBase<Entrada>
    {
        private readonly MuseoEntities _baseDeDatos = new MuseoEntities();

        public bool ActualizarEntidad(Entrada entidad)
        {
            if (entidad != null)
            {
                var entidadBase = _baseDeDatos.Entrada.FirstOrDefault(x => x.Id == entidad.Id);

                entidad.Id = entidad.Id;

                _baseDeDatos.SaveChanges();
                return true;
            }
            return false;
        }

        public bool BorrarEntidad(Entrada entidad)
        {
            if (entidad != null)
            {
                var entidadBase = _baseDeDatos.Entrada.FirstOrDefault(x => x.Id == entidad.Id);
                _baseDeDatos.Entrada.Remove(entidadBase);
                return true;
            }

            return false;
        }

        public Entrada GuardarEntidad(Entrada entidad)
        {
            if (entidad != null)
            {
                _baseDeDatos.Entrada.Add(entidad);
                _baseDeDatos.SaveChanges();
                return entidad;
            }

            return new Entrada();
        }

        public List<Entrada> Listar()
        {
            return _baseDeDatos.Entrada.ToList();
        }
    }
}
