﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Business {
	public class Sede {
		public int Id { get; set; }

		public int _cantidadMaximaVisitantes { get; set; }


		public int GetCantidadMaximaVisitantes()
		{
			return _cantidadMaximaVisitantes;
		}
	}
}