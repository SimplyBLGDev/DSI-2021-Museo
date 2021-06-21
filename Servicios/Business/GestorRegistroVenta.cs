using Servicios.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servicios.Business
{
    public static class GestorRegistroVenta
    {
        private static int cantidadEntradas;
        private static bool conGuia;
        private static float montoAdicionalPorGuia;
        private static Sede sedeActual;
        private static List<Tarifa> tarifas;

        private static ServicioTarifa _servicioTarifa = new ServicioTarifa();
        private static ServicioSede _servicioSede = new ServicioSede();
        private static ServicioReservas _servicioReservas = new ServicioReservas();
        private static ServicioEntrada _servicioEntrada = new ServicioEntrada();

        public static void Inicializar()
        {
            //sedeActual = new Sede { Id = 1 };
            sedeActual = _servicioSede.MostrarInformacionSede(new Sede { Id = 1 });
            tarifas = _servicioTarifa.MostrarTarifasExistentes(sedeActual);
        }

        public static DateTime GetFechaActual()
        {
            return DateTime.Now;
        }

        public static List<Tarifa> MostrarTarifasExistentes()
        {
            List<Tarifa> tarifasValidas = new List<Tarifa>();

            foreach (Tarifa tarifa in tarifas)
                if (tarifa.EsVigente(GetFechaActual()))
                    tarifasValidas.Add(tarifa);

            return tarifasValidas;
        }
        public static Hora CalcularDuracionVisitaCompleta()
        {
            return _servicioSede.MostrarDuracionDeVisita(sedeActual);
        }

        public static bool ValidarCantidadDeEntradas(int cantidadEntradasUsuario)
        {
            var cantidadMaximaSede = sedeActual.GetCantidadMaximaVisitantes();
            var cantidadConfirmados = _servicioReservas.CantidadDeAlumnosConfirmados(sedeActual);
            var cantidadReservas = _servicioEntrada.CantidadEntradasReservadas(sedeActual);

            var superarCantidadMaxima = (cantidadConfirmados + cantidadReservas + cantidadEntradasUsuario) > cantidadMaximaSede;

            return superarCantidadMaxima;
        }

        public static void RegistrarEntradas(int cantidadEntradas, Tarifa tarifaSeleccionada)
        {
            var numeroDeEntrada = _servicioEntrada.ObtenerUlTimoNumero(sedeActual);

            for (int i = 0; i < cantidadEntradas; i++)
            {
                var nuevaEntrada = new Entrada();
                nuevaEntrada.SetTarifa(tarifaSeleccionada);
                nuevaEntrada.SetSede(sedeActual);
                nuevaEntrada.SetNumero(numeroDeEntrada);
                nuevaEntrada.SetMonto(tarifaSeleccionada.GetMonto());
                _servicioEntrada.RegistraEntrada(nuevaEntrada);
                numeroDeEntrada++;
            }

            ActualizarCantidadDeVisitantes();
        }

        public static void ActualizarCantidadDeVisitantes()
        {
            var cantidadConfirmados = _servicioReservas.CantidadDeAlumnosConfirmados(sedeActual);
            var cantidadReservas = _servicioEntrada.CantidadEntradasReservadas(sedeActual);
            cantidadEntradas = (cantidadConfirmados + cantidadReservas);
        }

        public static void mensajeCerrar()
        {
            if (MessageBox.Show("¿Está seguro de cerrar?", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        public static int MostrarCantidadDeVisitantes()
        {
            ActualizarCantidadDeVisitantes();
            return cantidadEntradas;
        }

        public static int MostrarCantidadMaximaVisitantes()
        {
            return sedeActual.GetCantidadMaximaVisitantes();
        }

        public static List<Entrada> ListarEntradasSedeEnFecha()
        {
            return  _servicioEntrada.ListarEntradasDelDia(sedeActual);
        }
    }
}
