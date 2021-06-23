namespace Servicios.Business {
	public class TipoEntrada {
		private string nombre;

		public static implicit operator TipoEntrada(AccesoADatos.TipoEntrada tarifaBd) {
			TipoEntrada nuevo  = new TipoEntrada();
			nuevo.nombre = tarifaBd.Nombre;
			
			return nuevo;
		}

		public string GetNombre() {
			return nombre;
		}

		public bool EsPublicoGeneral() {
			return nombre.Equals("Publico General");
		}

		public bool EsDiscapacitado() {
			return nombre.Equals("Discapacitado");
		}
	}
}
