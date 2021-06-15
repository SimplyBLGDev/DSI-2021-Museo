using AccesoADatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoADatos.Repositorios
{
    public class RepositorioTipoEntrada : RepositorioBase<TipoEntrada>
    {

        private readonly MueseoBaseEntities _baseDeDatos = new MueseoBaseEntities();

        public bool ActualizarEntidad(TipoEntrada entidad)
        {
            if (entidad != null)
            {
                var entidadBase = _baseDeDatos.TipoEntrada.FirstOrDefault(x => x.GetId() == entidad.GetId());

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
                var entidadBase = _baseDeDatos.TipoEntrada.FirstOrDefault(x => x.GetId() == entidad.GetId());
                _baseDeDatos.TipoEntrada.Remove(entidadBase);
                return true;
            }

            return false;
        }

        public TipoEntrada GuardarEntidad(TipoEntrada entidad)
        {
            if (entidad != null)
            {
                _baseDeDatos.TipoEntrada.Add(entidad);
                _baseDeDatos.SaveChanges();
                return entidad;
            }

            return new TipoEntrada();
        }

        public List<TipoEntrada> Listar()
        {
            return _baseDeDatos.TipoEntrada.ToList();
        }
    }
}
