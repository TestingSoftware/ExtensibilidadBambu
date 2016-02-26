using NUnit.Framework;
using System;
using Extensibilidadbambu.com.extensibilidadbambu.launchers;
using Extensibilidadbambu.com.extensibilidadbambu.librerias;
using Extensibilidadbambu;
using Extensibilidadbambu.com.extensibilidadbambu.activemq;

namespace ExtensibilidadbambuTest
{
	[TestFixture]
	public class ConsumirEInsertarPedidos
	{
		[Test]
		public void TestCase ()
		{
			String cola = "TEST_PEDIDO";
			Rest rest = new Rest ();

			String[] listaPedidos = rest.obtener (new Configuracion().urlNimbus(),
				new Configuracion().restPedidoURL());
			ConsumirPedido consumirPedido = new ConsumirPedido ();
			consumirPedido.Launcher (cola, new Configuracion().restPedidoURL());

			int i = 0;
			ConectorActiveMQ camq = new ConectorActiveMQ ();
			while (camq.hayNuevo (cola) != null)
			{
				i++;
			}
			Assert.AreEqual(listaPedidos.Length, i);
		}
	}
}

