﻿/*
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
			ConectorActiveMQ sa = new ConectorActiveMQ();
			sa.enviarMensaje ("COLA_SHARP", "Soy un mensajito");
			//Console.Write(sa.hayNuevo("COLA_SHARP"));
		}
	}
}