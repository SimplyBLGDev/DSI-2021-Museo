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
        private static decimal montoAdicionalPorGuia;
        private static Sede sedeActual;
        private static List<Tarifa> tarifas;

        
        private static ServicioSede _servicioSede = new ServicioSede();
        private static ServicioReservas _servicioReservas = new ServicioReservas();
        private static ServicioEntrada _servicioEntrada = new ServicioEntrada();


        //
        public static void OpcionRegitrarVenta()
        {
            sedeActual = _servicioSede.MostrarInformacionSede(new Sede { Id = 1 });
            BuscarTarifasExistentes();
        }

        private static void BuscarTarifasExistentes()
        {
            tarifas = sedeActual.MostrarTarifasExistentes();
        }

        public static List<Tarifa> MostrarTarifas()
        {
            return tarifas;
        }

        public static DateTime GetFechaActual()
        {
            return DateTime.Now;
        }


        public static Hora CalcularDuracionVisitaCompleta(Tarifa tarifaSeleccionada)
        {
            return tarifaSeleccionada.GetTipoVisita().EsCompleta() ? sedeActual.MostrarDuracionDeVisita(sedeActual) :
            new Hora(0);
        }

        public static bool ValidarCantidadDeEntradas(int cantidadEntradasUsuario)
        {
            var cantidadMaximaSede = sedeActual.GetCantidadMaximaVisitantes();
            var cantidadConfirmados = _servicioReservas.CantidadDeAlumnosConfirmados(sedeActual);
            var cantidadReservas = _servicioEntrada.CantidadEntradasReservadas(sedeActual);

            var superarCantidadMaxima = (cantidadConfirmados + cantidadReservas + cantidadEntradasUsuario) > cantidadMaximaSede;

            return superarCantidadMaxima;
        }

        public static void ConfirmarVenta(int cantidadEntradas, Tarifa tarifaSeleccionada)
        {
            montoAdicionalPorGuia = tarifaSeleccionada.GetMontoAdicional();

            var numeroDeEntrada = _servicioEntrada.CalcularUltimoNumero(sedeActual);

            RegistrarVenta(numeroDeEntrada, cantidadEntradas, tarifaSeleccionada);

            ActualizarCantidadDeVisitantes();
        }

        private static void RegistrarVenta(int numeroDeEntrada, int cantidadEntradas, Tarifa tarifaSeleccionada)
        {
            for (int i = 0; i < cantidadEntradas; i++)
            {
                var nuevaEntrada = new Entrada();
                nuevaEntrada.SetTarifa(tarifaSeleccionada);
                nuevaEntrada.SetSede(sedeActual);
                nuevaEntrada.SetNumero(numeroDeEntrada);
                nuevaEntrada.SetMonto(tarifaSeleccionada.GetMonto() + montoAdicionalPorGuia);
                _servicioEntrada.RegistraEntrada(nuevaEntrada);
                numeroDeEntrada++;
            }
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
            sedeActual = _servicioSede.MostrarInformacionSede(new Sede { Id = 1 });
            return  _servicioEntrada.ListarEntradasDelDia(sedeActual);
        }
    }
}
