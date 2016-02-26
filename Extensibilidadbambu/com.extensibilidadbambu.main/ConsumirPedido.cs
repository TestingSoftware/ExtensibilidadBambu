using System;
using Extensibilidadbambu.com.extensibilidadbambu.activemq;
using Extensibilidadbambu.com.extensibilidadbambu.librerias;

namespace Extensibilidadbambu
{
	public class ConsumirPedido
	{
		public void Launcher(String colaPedido, String urlRest)
		{
			Rest rest = new Rest ();
			String[] listaPedidos = rest.obtener (new Configuracion().urlNimbus() ,urlRest);

			ConectorActiveMQ connector = new ConectorActiveMQ ();
			foreach (String elemento in listaPedidos) 
			{
				connector.enviarMensaje (colaPedido, elemento);
			}
		}
	}
}

