using Base.Business;
using System;
using System.Windows.Forms;

namespace DSI2021 {
	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			GestorRegistroVenta.Init();
			Application.Run(new MainMenu());
		}
	}
}
