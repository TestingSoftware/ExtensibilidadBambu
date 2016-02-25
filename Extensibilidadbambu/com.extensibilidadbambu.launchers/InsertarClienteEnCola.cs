using System;
namespace Extensibilidadbambu.com.extensibilidadbambu.launchers
{
	public class InsertarClienteEnCola
	{
		public InsertarClienteEnCola ()
		{
		}

		public void Main()
		{
			//TODO colocar las URL en un archivo de configuración aparte.
			com.extensibilidadbambu.librerias.Rest rest = new com.extensibilidadbambu.librerias.Rest ();
			String[] listaClientes = rest.obtener (@"https://site.nimbus.ncubo.com","/UIQA/newbikes/busqueda/productos?catalogo=catalogoGeneral&valorDeBusqueda=*&indiceInicial=0&tamano=10");

			com.extensibilidadbambu.activemq.ConectorActiveMQ connector = new com.extensibilidadbambu.activemq.ConectorActiveMQ ();
			foreach (String elemento in listaClientes) 
			{
				connector.enviarMensaje ("TEST", elemento);
			}
		}
	}
}

