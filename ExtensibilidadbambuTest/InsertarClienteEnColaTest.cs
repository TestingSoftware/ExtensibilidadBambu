using NUnit.Framework;
using System;
using Extensibilidadbambu.com.extensibilidadbambu.main;
using Extensibilidadbambu.com.extensibilidadbambu.activemq;
using Extensibilidadbambu.com.extensibilidadbambu.librerias;
using Extensibilidadbambu;

namespace ExtensibilidadbambuTest
{
	[TestFixture ()]
	public class InsertarClienteEnColaTest
	{
		[Test ()]
		public void TestCase ()
		{
			Configuracion configuracion = new Configuracion ();
			string urlNimbus = configuracion.urlNimbus ();
			string itemsAObtenerNimbus = configuracion.itemsNimbus ();

			InsertarClienteEnCola insertarClienteEnCola = new InsertarClienteEnCola ();
			insertarClienteEnCola.Launcher ("TEST", urlNimbus, itemsAObtenerNimbus);

			Rest rest = new Rest ();
			String[] listaClientes = rest.obtener (urlNimbus, itemsAObtenerNimbus);
			ConectorActiveMQ conectorActiveMQ = new ConectorActiveMQ ();

			foreach (string cliente in listaClientes)
				Assert.AreEqual (cliente, conectorActiveMQ.hayNuevo("TEST"));

		}
	}
}