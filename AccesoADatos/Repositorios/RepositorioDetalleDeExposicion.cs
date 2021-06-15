using AccesoADatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoADatos.Repositorios
{
    public class RepositorioDetalleDeExposicion : RepositorioBase<DetalleExposicion>
    {
        private readonly MueseoBaseEntities _baseDeDatos = new MueseoBaseEntities();
        public bool ActualizarEntidad(DetalleExposicion entidad)
        {
            if (entidad != null)
            {
                var entidadBase = _baseDeDatos.DetalleExposicion.FirstOrDefault(x => x.Id == entidad.Id);

                entidad.Id = entidad.Id;

                _baseDeDatos.SaveChanges();
                return true;
            }
            return false;
        }

        public bool BorrarEntidad(DetalleExposicion entidad)
        {
            if (entidad != null)
            {
                var entidadBase = _baseDeDatos.DetalleExposicion.FirstOrDefault(x => x.Id == entidad.Id);
                _baseDeDatos.DetalleExposicion.Remove(entidadBase);
                return true;
            }

            return false;
        }

        public DetalleExposicion GuardarEntidad(DetalleExposicion entidad)
        {
            if (entidad != null)
            {
                _baseDeDatos.DetalleExposicion.Add(entidad);
                _baseDeDatos.SaveChanges();
                return entidad;
            }

            return new DetalleExposicion();
        }

        public List<DetalleExposicion> Listar()
        {
            return _baseDeDatos.DetalleExposicion.ToList();
        }
    }
}
