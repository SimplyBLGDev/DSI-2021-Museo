using AutoMapper;
using Servicios.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class MapperEntidades
    {
        private  MapperConfiguration config;

        public MapperEntidades()
        {
            config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<DetalleExposicion, AccesoADatos.DetalleExposicion>();
                cfg.CreateMap<Entrada, AccesoADatos.Entrada>();
                cfg.CreateMap<Exposicion, AccesoADatos.Exposicion>();
                cfg.CreateMap<Obra, AccesoADatos.Obra>();
                cfg.CreateMap<ReservaVisita, AccesoADatos.ReservaVisita>();
                cfg.CreateMap<Sede, AccesoADatos.Sede>();
                cfg.CreateMap<Tarifa, AccesoADatos.Tarifa>();
                cfg.CreateMap<TipoEntrada, AccesoADatos.TipoEntrada>();
                cfg.CreateMap<TipoVisita, AccesoADatos.TipoVisita>();
                cfg.CreateMap<DetalleExposicion, AccesoADatos.DetalleExposicion>().ReverseMap();
                cfg.CreateMap<Entrada, AccesoADatos.Entrada>().ReverseMap();
                cfg.CreateMap<Exposicion, AccesoADatos.Exposicion>().ReverseMap();
                cfg.CreateMap<Obra, AccesoADatos.Obra>().ReverseMap();
                cfg.CreateMap<ReservaVisita, AccesoADatos.ReservaVisita>().ReverseMap();
                cfg.CreateMap<Sede, AccesoADatos.Sede>().ReverseMap();
                cfg.CreateMap<Tarifa, AccesoADatos.Tarifa>().ReverseMap();
                cfg.CreateMap<TipoEntrada, AccesoADatos.TipoEntrada>().ReverseMap();
                cfg.CreateMap<TipoVisita, AccesoADatos.TipoVisita>().ReverseMap();
            });
        }
    

        public Mapper Mapper {

            get { 
                return new Mapper(config);
            }
        }
       
    }
}
