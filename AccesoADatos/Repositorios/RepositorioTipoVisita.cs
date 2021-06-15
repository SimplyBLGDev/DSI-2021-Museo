using AccesoADatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoADatos.Repositorios
{
    public class RepositorioTipoVisita : RepositorioBase<TipoVisita>
    {

        private readonly MueseoBaseEntities _baseDeDatos = new MueseoBaseEntities();

        public bool ActualizarEntidad(TipoVisita entidad)
        {
            if (entidad != null)
            {
                var entidadBase = _baseDeDatos.TipoVisita.FirstOrDefault(x => x.GetId() == entidad.GetId());

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
                var entidadBase = _baseDeDatos.TipoVisita.FirstOrDefault(x => x.GetId() == entidad.GetId());
                _baseDeDatos.TipoVisita.Remove(entidadBase);
                return true;
            }

            return false;
        }

        public TipoVisita GuardarEntidad(TipoVisita entidad)
        {
            if (entidad != null)
            {
                _baseDeDatos.TipoVisita.Add(entidad);
                _baseDeDatos.SaveChanges();
                return entidad;
            }

            return new TipoVisita();
        }

        public List<TipoVisita> Listar()
        {
          return  _baseDeDatos.TipoVisita.ToList();
        }
    }
}
