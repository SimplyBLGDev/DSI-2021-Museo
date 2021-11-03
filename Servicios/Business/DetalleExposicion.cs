using Base.Data;

namespace Base.Business {
	public class DetalleExposicion {
		private Obra obra;
		private string lugarAsignado;

		public static implicit operator DetalleExposicion(AccesoADatos.DetalleExposicion entidadDb) {
			var nuevo = new DetalleExposicion();
			nuevo.obra = entidadDb.Obra;
			nuevo.lugarAsignado = entidadDb.LugarAsignado;
			return nuevo;
		}

		public string GetLugarAsignado() {
			return lugarAsignado;
		}

		public Hora DuracionVisita() {
			return obra.GetDuracionResumida();
		}

		public Hora DuracionVisitaExtendida()
		{
			return obra.GetDuracionExtendida();
		}

	}
}
