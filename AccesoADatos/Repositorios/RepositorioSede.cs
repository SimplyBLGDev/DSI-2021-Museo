using System.Collections.Generic;
using System.Linq;

namespace AccesoADatos.Repositorios
{
    public class RepositorioSede : RepositorioBase<Sede>
    {
        private readonly MuseoEntities _baseDeDatos = new MuseoEntities();



        public bool ActualizarEntidad(Sede entidad)
        {
            if (entidad != null)
            {
                var entidadBase = _baseDeDatos.Sede.FirstOrDefault(x => x.Id == entidad.Id);

                entidad.Id = entidad.Id;

                _baseDeDatos.SaveChanges();
                return true;
            }

            return false;
        }

        public bool BorrarEntidad(Sede entidad)
        {
            if (entidad != null)
            {
                var entidadBase = _baseDeDatos.Sede.FirstOrDefault(x => x.Id == entidad.Id);
                _baseDeDatos.Sede.Remove(entidadBase);
                return true;
            }

            return false;
        }

        public bool GuardarEntidad(Sede entidad)
        {
            if (entidad != null)
            {
                _baseDeDatos.Sede.Add(entidad);
                _baseDeDatos.SaveChanges();
                return true;
            }

            return false;
        }

        public List<Sede> Listar()
        {
            return _baseDeDatos.Sede.ToList();
        }
        public Sede BuscarSede(Sede entidad)
        {
            if (entidad != null)
            {
                var entidadBase = _baseDeDatos.Sede.FirstOrDefault(x => x.Id == entidad.Id);
                return entidadBase;
            }

            return new Sede();
        }
    }
}
