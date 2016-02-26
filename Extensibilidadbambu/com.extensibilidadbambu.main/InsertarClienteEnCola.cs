using System;
using Extensibilidadbambu.com.extensibilidadbambu.librerias;
using Extensibilidadbambu.com.extensibilidadbambu.activemq;


namespace Extensibilidadbambu.com.extensibilidadbambu.main
{
	public class InsertarClienteEnCola
	{
		public InsertarClienteEnCola ()
		{
		}

		public void Launcher(String cola, String urlNimbus, String itemsAObtenerNimbus)
		{
			Rest rest = new Rest();
			String[] listaClientes = rest.obtener (urlNimbus, itemsAObtenerNimbus);

			ConectorActiveMQ connector = new ConectorActiveMQ ();
			foreach (String elemento in listaClientes) 
			{
				connector.enviarMensaje (cola, elemento);
			}
		}
	}
}