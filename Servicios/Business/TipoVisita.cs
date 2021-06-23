namespace Servicios.Business {
	public class TipoVisita {
		private string nombre;

		public static implicit operator TipoVisita(AccesoADatos.TipoVisita tarifaBd) {
			TipoVisita nuevo  = new TipoVisita();
			nuevo.nombre = tarifaBd.Nombre;

			return nuevo;
		}
		public string GetNombre() {
			return nombre;
		}

		public bool EsCompleta() {
			return nombre.Equals("Completa");
		}
	}
}
