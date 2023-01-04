/*
 * Created by SharpDevelop.
 * User: rjc
 * Date: 04-01-2023
 * Time: 9:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace DDJJ1887
{
	/// <summary>
	/// Description of validaciones.
	/// </summary>
	public class validaciones
	{
		public validaciones()
		{
		}
		
		
		public static string Digito(int rut) 
		{
			int suma = 0;
			int multiplicador = 1;
			while (rut != 0) {
				multiplicador++;
				if (multiplicador == 8)
					multiplicador = 2;
				suma += (rut % 10) * multiplicador;
				rut = rut / 10;
			}
			suma = 11 - (suma % 11);
			if (suma == 11)	{
				return "0";
			} else if (suma == 10) {
				return "K";
			} else {
				return suma.ToString();
			}
		}
		
		
	}
}
