using System;
using System.Configuration;

namespace Extensibilidadbambu
{
	public class Configuracion
	{

		private const string COLA_CONEXION = "cola.conexion";

		public Configuracion ()
		{
		}

		public String colaConexion()
		{
			return ConfigurationManager.AppSettings [COLA_CONEXION];
		}
	}
}

