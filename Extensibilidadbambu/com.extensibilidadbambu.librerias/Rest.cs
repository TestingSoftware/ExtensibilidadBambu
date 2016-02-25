using System;
using System.Collections.Generic;
using RestSharp;
using Newtonsoft.Json;
namespace Extensibilidadbambu.com.extensibilidadbambu.librerias
{
	public class Rest
	{
		public Rest ()
		{

		}

		// URL es la url nimbus https://site.nimbus.ncubo.com, items lo que se desea obtener 
		public string[] obtener(String url, String items)
		{
			var cliente = new RestClient (url);
			var peticion = new RestRequest (items, Method.GET);
			var respuesta = cliente.Execute (peticion);
			List<string> clientes = JsonConvert.DeserializeObject<List<string>>(respuesta.Content);
			String[] listaClientes = new string[clientes.Count];
			int contador = 0;
			foreach (String element in clientes) 
			{
				listaClientes [contador] = element;
				contador++;
			}
			return listaClientes;
		}
	}
}