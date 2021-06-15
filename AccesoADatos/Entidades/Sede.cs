using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoADatos.Entidades
{
    public class Sede
    {
        public int Id {get;set;}
    }

    public class Tarifa
    {
        public int Id { get; set; }
        public int IdSede { get; set; }


        public bool EsVigente()
        {
            return true;
        }
        public bool GetMonto()
        {
            return true;
        }
        public bool GetMontoAdicional()
        {
            return true;
        }

        public TipoEntrada GetTipoDeEntrada()
        {
            return new TipoEntrada();
        }

        public TipoVisita GetTipoVisita()
        {
            return new TipoVisita();
        }
    }

    public class TipoVisita
    {
        private int Id;
        private string Nombre;

        public int GetId()
        {
            return Id;
        }

        public string GetNombre()
        {
            return Nombre;
        }
    }

    public class TipoEntrada
    {

        private int id;
        private string nombre;

        public  int GetId()
        {
            return id;  
        }

        public string GetNombre()
        {
            return nombre;
        }
    }

    public class Exposicion
    {
        public int Id { get; set; }
    }

    public class DetalleExposicion
    {
        public int Id { get; set; }
    }

    public class Obra
    {
        public int Id { get; set; }
    }

    public class Entrada
    {
        public int Id { get; set; }
    }

    public class ReservaVisita
    {
        public int Id { get; set; }
    }
}
