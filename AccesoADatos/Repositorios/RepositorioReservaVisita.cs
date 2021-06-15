using AccesoADatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoADatos.Repositorios
{
    public class RepositorioReservaVisita : RepositorioBase<ReservaVisita>
    {
        private readonly MueseoBaseEntities _baseDeDatos = new MueseoBaseEntities();

        public bool ActualizarEntidad(ReservaVisita entidad)
        {
            if (entidad != null)
            {
                var entidadBase = _baseDeDatos.ReservaVisita.FirstOrDefault(x => x.Id == entidad.Id);

                entidad.Id = entidad.Id;

                _baseDeDatos.SaveChanges();
                return true;
            }
            return false;
        }

        public bool BorrarEntidad(ReservaVisita entidad)
        {
            if (entidad != null)
            {
                var entidadBase = _baseDeDatos.ReservaVisita.FirstOrDefault(x => x.Id == entidad.Id);
                _baseDeDatos.ReservaVisita.Remove(entidadBase);
                return true;
            }

            return false;
        }

        public ReservaVisita GuardarEntidad(ReservaVisita entidad)
        {
            if (entidad != null)
            {
                _baseDeDatos.ReservaVisita.Add(entidad);
                _baseDeDatos.SaveChanges();
                return entidad;
            }

            return new ReservaVisita();
        }

        public List<ReservaVisita> Listar()
        {
            return _baseDeDatos.ReservaVisita.ToList();
        }
    }
}
