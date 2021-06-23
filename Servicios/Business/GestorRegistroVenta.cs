using Base.Data;
using System;
using System.Collections.Generic;

namespace Base.Business {
	public static class GestorRegistroVenta {
		private static decimal montoAdicionalPorGuia;
		private static Sede sedeActual;
		private static List<Tarifa> tarifas;

		// Patron Controlador, al existir un objeto de fabricacion pura (tipo controlador) nos va a permitir
		// mantener la separacion entre la capa de presentacion y la capa de logica de negocio.
		
		// Patron Bajo Acomplamiento: el metodo opcionRegistrarVenta esta cumpliendo este patron ya que la
		// unica relacion que tiene la clase boundary es con el gestor
		public static void OpcionRegistrarVenta() {
			sedeActual = Persistencia.FetchSede(1); // Constante
			BuscarTarifasExistentes();
		}

		private static void BuscarTarifasExistentes() {
			tarifas = sedeActual.MostrarTarifasExistentes();
		}

		public static List<Tarifa> MostrarTarifas() {
			return tarifas;
		}

		public static DateTime GetFechaActual() {
			return DateTime.Now;
		}

		public static Hora CalcularDuracionVisitaCompleta(Tarifa tarifaSeleccionada) {
			return tarifaSeleccionada.GetTipoVisita().EsCompleta() ? sedeActual.MostrarDuracionDeVisita() :
			new Hora(0);
		}

		public static bool ValidarCantidadDeEntradas(int cantidadEntradasUsuario) {
			int cantidadMaximaSede = sedeActual.GetCantidadMaximaVisitantes();
			int cantidadConfirmados = Persistencia.FetchCantidadAlumnosConfirmados(sedeActual);
			int cantidadReservas = Persistencia.FetchCantidadEntradasReservadas(sedeActual);

			bool superarCantidadMaxima = (cantidadConfirmados + cantidadReservas + cantidadEntradasUsuario) > cantidadMaximaSede;

			return superarCantidadMaxima;
		}

		public static void ConfirmarVenta(int cantidadEntradas, Tarifa tarifaSeleccionada) {
			montoAdicionalPorGuia = tarifaSeleccionada.GetMontoAdicional();

			int numeroDeEntrada = Persistencia.FetchUltimoNumeroEntrada(sedeActual) + 1;

			RegistrarVenta(numeroDeEntrada, cantidadEntradas, tarifaSeleccionada);
		}

		private static void RegistrarVenta(int numeroDeEntrada, int cantidadEntradas, Tarifa tarifaSeleccionada) {
			for (int i = 0; i < cantidadEntradas; i++) {
				// Patron Creador: el gestor cuenta con toda la informacion necesaria para inicializar
				// la entidad nueva:Entrada

				var nuevaEntrada = new Entrada();
				nuevaEntrada.SetTarifa(tarifaSeleccionada);
				nuevaEntrada.SetSede(sedeActual);
				nuevaEntrada.SetNumero(numeroDeEntrada);
				nuevaEntrada.SetMonto(tarifaSeleccionada.GetMonto() + montoAdicionalPorGuia);
				Persistencia.RegistrarEntrada(nuevaEntrada);
				numeroDeEntrada++;
			}
		}

		public static int GetCantidadDeVisitantes() {
			int cantidadConfirmados = Persistencia.FetchCantidadAlumnosConfirmados(sedeActual);
			int cantidadReservas = Persistencia.FetchCantidadEntradasReservadas(sedeActual);
			return cantidadConfirmados + cantidadReservas;
		}

		public static int GetCantidadMaximaVisitantes() {
			return sedeActual.GetCantidadMaximaVisitantes();
		}

		public static List<Entrada> ListarEntradasSedeEnFecha() {
			return Persistencia.FetchEntradasDeFecha(sedeActual, GetFechaActual());
		}
	}
}
