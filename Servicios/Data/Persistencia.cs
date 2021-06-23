using Base.Business;
using Base.Data.Servicios;
using System;
using System.Collections.Generic;

namespace Base.Data {
	public static class Persistencia {
		public static Sede FetchSede(int id) {
			ServicioSede servicioSede = new ServicioSede();
			return servicioSede.FetchSede(id);
		}

		public static List<Tarifa> FetchTarifasPorSede(Sede sede) {
			ServicioSede servicioSede = new ServicioSede();
			return servicioSede.FetchTarifasPorSede(sede);
		}

		public static int FetchCantidadAlumnosConfirmados(Sede sede) {
			ServicioReservas servicioReservas = new ServicioReservas();
			return servicioReservas.FetchCantidadAlumnosConfirmados(sede);
		}

		public static int FetchCantidadEntradasReservadas(Sede sede) {
			ServicioEntrada servicioEntrada = new ServicioEntrada();
			return servicioEntrada.GetCantidadEntradasReservadas(sede);
		}

		public static int FetchUltimoNumeroEntrada(Sede sede) {
			ServicioEntrada servicioEntrada = new ServicioEntrada();
			return servicioEntrada.FetchUltimoNumero(sede);
		}

		public static bool RegistrarEntrada(Entrada nuevaEntrada) {
			ServicioEntrada servicioEntrada = new ServicioEntrada();
			return servicioEntrada.RegistrarEntrada(nuevaEntrada);
		}

		public static List<Entrada> FetchEntradasDeFecha(Sede sede, DateTime dia) {
			ServicioEntrada servicioEntrada = new ServicioEntrada();
			return servicioEntrada.ListarEntradasDelDia(sede, dia);
		}

		public static List<Exposicion> FetchExposicionesPorSede(Sede sede) {
			ServicioExposiciones servicioExposiciones = new ServicioExposiciones();
			return servicioExposiciones.GetExposicionesPorSede(sede);
		}
	}
}
