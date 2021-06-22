using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Business {
	public class Entrada {
		private Sede sede;
		private DateTime fechaVenta;
		private decimal _monto;
		private int _numero;
		public int Id { get; set; }

		private Tarifa _tarifa;


		public static implicit operator Entrada(AccesoADatos.Entrada entidadBd)
		{
			var nuevo = new Entrada();
			nuevo.fechaVenta = entidadBd.FechaVenta.Value;
			nuevo._monto = entidadBd.Monto ?? 0;
			nuevo._numero = int.Parse(entidadBd.Numero);
			nuevo.Id = entidadBd.Id;
			nuevo.sede = entidadBd.Sede;
			nuevo._tarifa = entidadBd.Tarifa;
			return nuevo;
		}
		

		public Sede GetSede() {
			return sede;
		}

		public void SetSede(Sede sedeActual)
		{
			sede = sedeActual;
		}

		public bool ValidarHorarioEntrada(DateTime actual) {
			return actual.Date == fechaVenta.Date;
		}


		public int GetNumero()
		{
			return _numero;
		}

		public DateTime GetFechaVenta()
		{
			return fechaVenta;
		}


		public void SetNumero(int numeroEntrada)
		{
			_numero = numeroEntrada;
		}

		public decimal GetMonto()
		{
			
				return _monto;
			
		}
		public void SetMonto( decimal monto)
		{
			_monto = monto;

		}

		public Tarifa GetTarifa()
		{
			return _tarifa;
		}

		public void SetTarifa(Tarifa tarifa)
		{
			_tarifa = tarifa;
		}

		public bool EsFecheActual(DateTime fecha)
		{
			return fechaVenta.Date == fecha.Date;
		}
	}
}
