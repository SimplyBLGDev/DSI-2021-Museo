﻿using AccesoADatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoADatos.Repositorios
{
    public class RepositorioObra : RepositorioBase<Obra>
    {
        private readonly MueseoBaseEntities _baseDeDatos = new MueseoBaseEntities();
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

        public Obra GuardarEntidad(Obra entidad)
        {
            if (entidad != null)
            {
                _baseDeDatos.Obra.Add(entidad);
                _baseDeDatos.SaveChanges();
                return entidad;
            }

            return new Obra();
        }

        public List<Obra> Listar()
        {
            return _baseDeDatos.Obra.ToList();
        }
    }
}