using AccesoADatos.Repositorios;
using Base.Business;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Base.Data.Servicios {
	public class ServicioEntrada {
		private readonly RepositorioEntrada repositorioEntrada = new RepositorioEntrada();

		public int GetCantidadEntradasReservadas(Sede sede) {
			var listadoEntradas = repositorioEntrada.ListarEntradasPorSede(sede.id);
			var listadoEntradasBusiness = listadoEntradas.Select(x => (Entrada)x).ToList();
			int cantidad = 0;
			
			foreach (Entrada entrada in listadoEntradasBusiness)
				if (entrada.ValidarHorarioEntrada(DateTime.Now))
					cantidad++;

			return cantidad;
		}

		public int FetchUltimoNumero(Sede sede) {
			var listadoEntradas = repositorioEntrada.Listar();
			List<Entrada> listadoEntradasBusiness = listadoEntradas.Select(x => (Entrada)x).ToList();
			Entrada ultimaEntrada = listadoEntradas[listadoEntradas.Count - 1];

			return ultimaEntrada.GetNumero();
		}

		public bool RegistrarEntrada(Entrada nuevaEntrada) {
			var entidadDb = new AccesoADatos.Entrada();
			entidadDb.FechaVenta = DateTime.Now;
			entidadDb.Monto = nuevaEntrada.GetMonto();
			entidadDb.Numero = nuevaEntrada.GetNumero().ToString();
			entidadDb.IdSede = nuevaEntrada.GetSede().id;
			entidadDb.IdTarifa = nuevaEntrada.GetTarifa().GetNumeroTarifa();

			repositorioEntrada.GuardarEntidad(entidadDb);

			return true;
		}

		public List<Entrada> ListarEntradasDelDia(Sede sede, DateTime dia) {
			var listadoEntradas = repositorioEntrada.ListarEntradasPorSede(sede.id).Select(x => (Entrada)x)
				.Where( y=> y.EsFecha(dia)).ToList();
		  
			return listadoEntradas;
		}
	}
}
