/*
 * Created by SharpDevelop.
 * User: Dalaian
 * Date: 24/02/2016
 * Time: 03:52 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using Extensibilidadbambu.com.extensibilidadbambu.activemq;

namespace Extensibilidadbambu
{
	class Program
	{
		public static void Main(string[] args)
		{
			bool quedarse = true;

			do {
				System.Console.WriteLine ("Lista de mains\n" +
					"   1 - Consumir Pedido\n" +
					"Cualquier otro número o letra cerrará el programa...");
				try {
					int i = int.Parse (System.Console.ReadLine ());
					switch (i) {
					case 0:
						{
							quedarse = false;
							break;
						}
					case 1:
						{
							ConsumirPedido cp = new ConsumirPedido ();
							cp.Launcher (new Configuracion ().colaPedidoNombre (), new Configuracion ().restPedidoURL ());
							System.Console.WriteLine ("Consumí pedidos y los inserté en la cola...");
							break;
						}

					default:
						{
							quedarse = false;
							break;
						}
					}
				} catch {
					quedarse = false;
				}
			} while (quedarse);

		}
	}
}