using Base.Data;
using Servicios.Patrones.EstrategiasConcretas;
using Servicios.Patrones.Interfaces;
using System;
using System.Collections.Generic;

namespace Base.Business {
	public static class GestorRegistroVenta {
		private static decimal montoAdicionalPorGuia;
		private static Sede sedeActual;
		private static List<Tarifa> tarifas;
		private static List<Exposicion> exposiciones;
		private static IEstrategiaDuracionEstimada strategiaDeCalculoDeDuracion;

		public static void Init() {
			sedeActual = Persistencia.FetchSede(1); // Constante
		}

		// Patron Controlador, al existir un objeto de fabricacion pura (tipo controlador) nos va a permitir
		// mantener la separacion entre la capa de presentacion y la capa de logica de negocio.
		
		// Patron Bajo Acomplamiento: el metodo opcionRegistrarVenta esta cumpliendo este patron ya que la
		// unica relacion que tiene la clase boundary es con el gestor
		public static void OpcionRegistrarVenta() {
			BuscarTarifasExistentes();
			BuscarExposicionesSede();
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

		public static Hora CalcularDuracionVisitaCompleta(Tarifa tarifaSeleccionada, List<Exposicion> exposiciones) {

			if (tarifaSeleccionada.GetTipoVisita().EsCompleta())
				strategiaDeCalculoDeDuracion = new EstrategiaVisitaCompleta();
			else
				strategiaDeCalculoDeDuracion = new EstrategiaVisitaExposicion();


			return strategiaDeCalculoDeDuracion.CalcularDuracionDeVisita(sedeActual, exposiciones);
		}

		public static bool ValidarCantidadDeEntradas(int cantidadEntradasUsuario) {
			int cantidadConfirmados = Persistencia.FetchCantidadAlumnosConfirmados(sedeActual);
			int cantidadReservas = Persistencia.FetchCantidadEntradasReservadas(sedeActual);
			int cantidadMaximaSede = sedeActual.GetCantidadMaximaVisitantes();

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

		private static void BuscarExposicionesSede()
		{
			exposiciones = sedeActual.MostrarExposiciones();
		}

		public static List<Exposicion> MostrarExposiciones()
		{
			return exposiciones;
		}
	}
}
