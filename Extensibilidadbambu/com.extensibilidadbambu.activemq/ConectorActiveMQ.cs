/*
 * Created by SharpDevelop.
 * User: Dalaian
 * Date: 24/02/2016
 * Time: 03:54 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using Apache.NMS;
using Apache.NMS.Util;

namespace Extensibilidadbambu.com.extensibilidadbambu.activemq
{
	/// <summary>
	/// Description of ConectorActiveMQ.
	/// </summary>
	public class ConectorActiveMQ
	{
		private String URI = "tcp://activemq:61616";

		public ConectorActiveMQ()
		{
			
		}

		public void enviarMensaje(String cola, String mensaje)
		{
			Uri connecturi = new Uri(URI);
			IConnectionFactory factory = new NMSConnectionFactory(connecturi);

			using(IConnection connection = factory.CreateConnection())
			using(ISession session = connection.CreateSession())
			{
				IDestination destination = SessionUtil.GetDestination(session, String.Format("queue://{0}", cola));

				using(IMessageProducer producer = session.CreateProducer(destination))
				{
					connection.Start();
					//producer.Persistent = true;

					// Send a message
					ITextMessage request = session.CreateTextMessage(mensaje);
					producer.Send(request);
				}
			}
		}

		public String hayNuevo(String cola)
		{
			String mensaje = null;
			Uri connecturi = new Uri(URI);
			IConnectionFactory factory = new NMSConnectionFactory(connecturi);

			using(IConnection connection = factory.CreateConnection())
			using(ISession session = connection.CreateSession())
			{
				IDestination destination = SessionUtil.GetDestination(session, String.Format("queue://{0}", cola));

				using(IMessageConsumer consumer = session.CreateConsumer(destination))
				{
					connection.Start();
					//producer.Persistent = true;

					// Consume a message
					ITextMessage message = consumer.Receive(new TimeSpan(0,0,1)) as ITextMessage;
					if(message != null)
					{
						mensaje = message.Text;
					}
				}
			}
			return mensaje;
		}
	}
}
