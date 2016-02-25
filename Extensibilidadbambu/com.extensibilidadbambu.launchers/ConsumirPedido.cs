using System;
using Extensibilidadbambu.com.extensibilidadbambu.activemq;

namespace Extensibilidadbambu
{
	public class ConsumirPedido
	{
		public void Launcher()
		{
			ConectorActiveMQ ca = new ConectorActiveMQ ();
			ca.enviarMensaje("HOLA", "Hola");
		}
	}
}

