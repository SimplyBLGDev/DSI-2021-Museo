using AccesoADatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoADatos.Repositorios
{
    public class RepositorioTarifa : RepositorioBase<Tarifa>
    {

        private readonly MuseoEntities _baseDeDatos = new MuseoEntities();

        public bool ActualizarEntidad(Tarifa entidad)
        {
            if (entidad != null)
            {
                var entidadBase = _baseDeDatos.Tarifa.FirstOrDefault(x => x.Id == entidad.Id);

                entidad.Id = entidad.Id;

                _baseDeDatos.SaveChanges();
                return true;
            }

            return false;
        }

        public bool BorrarEntidad(Tarifa entidad)
        {
            if (entidad != null)
            {
                var entidadBase = _baseDeDatos.Tarifa.FirstOrDefault(x => x.Id == entidad.Id);
                _baseDeDatos.Tarifa.Remove(entidadBase);
                return true;
            }

            return false;
        }

        public Tarifa GuardarEntidad(Tarifa entidad)
        {
            if (entidad != null)
            {
                _baseDeDatos.Tarifa.Add(entidad);
                _baseDeDatos.SaveChanges();
                return entidad;
            }

            return new Tarifa();
        }

        public List<Tarifa> Listar()
        {
            return _baseDeDatos.Tarifa.ToList();
        }

        public List<Tarifa> ListarTarifaPorSede(int idSede)
        {
            return _baseDeDatos.Tarifa.Where( x=> x.IdSede == idSede).ToList();
        }
    }
}
