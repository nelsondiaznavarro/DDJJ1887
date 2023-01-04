/*
 * Created by SharpDevelop.
 * User: rjc
 * Date: 29-12-2022
 * Time: 11:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace DDJJ1887
{
	/// <summary>
	/// Description of Errores.
	/// </summary>
	public class errores
	{
		private string _xmlsalida = "";
		
		private string _xmlerrores = "";
		
		public errores()
		{
			
		}
		
		public void escribir_error(string error)
		{
			_xmlerrores += error + "\n\r";
		}
		
		public void limpiar_errores()
		{
			_xmlerrores = "";
		}
		
		public string recuperar_errores()
		{
			_xmlsalida = "<tabla>\n\r<fila>" +  _xmlerrores + "</fila>\n\r</tabla>";
			return _xmlsalida;
		}
		
	}
}
