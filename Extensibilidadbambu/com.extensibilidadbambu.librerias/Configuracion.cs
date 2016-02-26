using System;
using System.Configuration;

namespace Extensibilidadbambu
{
	public class Configuracion
	{

		private const string COLA_CONEXION = "cola.conexion";
		private const string COLA_PEDIDO_NOMBRE = "cola.pedido.nombre";
		private const string REST_PEDIDO_URL = "rest.pedido.url";
		private const string URL_NIMBUS = "url.nimbus";
		private const string ITEMS_BAMBU = "item.nimbus";

		public Configuracion ()
		{
		}

		public String colaConexion()
		{
			return ConfigurationManager.AppSettings [COLA_CONEXION];
		}

		public String colaPedidoNombre()
		{
			return ConfigurationManager.AppSettings [COLA_PEDIDO_NOMBRE];
		}

		public String restPedidoURL()
		{
			return ConfigurationManager.AppSettings [REST_PEDIDO_URL];
		}

		public String urlNimbus()
		{
			return ConfigurationManager.AppSettings [URL_NIMBUS];
		}
		public String itemsNimbus()
		{
			return ConfigurationManager.AppSettings [ITEMS_BAMBU];
		}
	}
}

