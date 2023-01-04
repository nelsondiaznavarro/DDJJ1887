/*
 * Created by SharpDevelop.
 * User: rjc
 * Date: 26-12-2022
 * Time: 13:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using rjc;
using System.Xml;
using System.IO;
namespace DDJJ1887
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			
			string rut_empresa = "";
			string verificador = "";
			string rut_representante = "";
			string dv_representante = "";
			string xmlprueba = "";
			
			string folio_global = "";
			errores miserrores = new errores();
			
			
			miserrores.limpiar_errores();
			try
			{
				 StreamReader sr = new StreamReader(@"C:\Desarrollo\PruebaDDJJ1887\xmlTipoRegistroCero.xml");
				 xmlprueba = sr.ReadToEnd();
				 sr.Close();
			}catch(Exception ex)
			{
				Console.Write("Error al leer el XML presione una tecla para terminar . . . ");
				
				miserrores.escribir_error("<error>" + "Carga XML Registro 0" + ";" + "" + ";" + ex.Message + "</error>");
				Console.WriteLine (miserrores.recuperar_errores());
			}
			
			//Console.WriteLine (xmlprueba);
			//
			if (string.IsNullOrWhiteSpace(xmlprueba))
			{
				Console.Write("Archivo vacio presione una tecla para terminar . . . ");
				miserrores.escribir_error("<error>" + "Carga XML Registro 0" + ";" + "" + ";" + "Archivo vacio" + "</error>");
				Console.WriteLine (miserrores.recuperar_errores());
			}
			
			
			Xml MiXml = null;
			
			
			try
			{
				 MiXml = new Xml(xmlprueba);
			}catch (Exception ex)
			{
				miserrores.escribir_error("<error>" + "Carga XML Registro 0" + ";" + "" + ";" + ex.Message + "</error>");
				Console.WriteLine ( miserrores.recuperar_errores());
			}
			
			
			//Instancio e inicializo la clase registro tipo 0
			registrotipo0 miRegistroTipo0 = new registrotipo0();
			registrotipo0.errores = miserrores;
			
			miRegistroTipo0.tipo_registro = MiXml.get("tipo_registro",0);
			miRegistroTipo0.ano_tributario = MiXml.get("ano_tributario",0);
			miRegistroTipo0.numero_formulario = MiXml.get("numero_formulario",0);
			miRegistroTipo0.numero_rut = MiXml.get("numero_de_rut",0);
			miRegistroTipo0.digito_verificador = MiXml.get("digito_verificador",0);
			miRegistroTipo0.total_registros = MiXml.get("total_registros",0);
			miRegistroTipo0.codigo_empresa = MiXml.get("codigo_empresa",0);
			miRegistroTipo0.numero_cliente = MiXml.get("numero_cliente",0);
			miRegistroTipo0.checksum_declarante = "0000000000"; //no se usa
			miRegistroTipo0.checksum_sii = "0000000000";		//no se usa
			miRegistroTipo0.codigo_prestacion = MiXml.get("codigo_prestacion",0);
			miRegistroTipo0.tipo_declaracion = MiXml.get("tipo_declaracion",0);
			miRegistroTipo0.folio = MiXml.get("folio",0);
			miRegistroTipo0.dia = MiXml.get("dia",0);
			miRegistroTipo0.mes = MiXml.get("mes",0);
			miRegistroTipo0.ano = MiXml.get("ano",0);
			miRegistroTipo0.hora = MiXml.get("hora",0);
			miRegistroTipo0.minuto = MiXml.get("minuto",0);
			miRegistroTipo0.segundo = MiXml.get("segundo",0);
			miRegistroTipo0.numero_version = MiXml.get("numero_version",0);
			miRegistroTipo0.numero_atencion = MiXml.get("numero_atencion",0);

			string resultado = miRegistroTipo0.retorna_registro_tipo_0(2023);
			
			//obtener folio para otros registros
			folio_global = miRegistroTipo0.folio;
			
			
			//Escribir archivo de salida
			StreamWriter outputFile = new StreamWriter(@"C:\Desarrollo\PruebaDDJJ1887\" +  miRegistroTipo0.numero_rut + "." + miRegistroTipo0.numero_formulario);
			//grabar registro 0
			outputFile.WriteLine (resultado);
			
			//Matar instancia de objeto 
			miRegistroTipo0 = null;
			
			MiXml = null;
			
			
			try
			{
				 StreamReader sr = new StreamReader(@"C:\Desarrollo\Documentacion DDJJ\archivo_empresa.xml");
				 xmlprueba = sr.ReadToEnd();
				 sr.Close();
			}catch(Exception ex)
			{
				miserrores.escribir_error("<error>" + "Carga XML Registro 1" + ";" + "" + ";" + ex.Message + "</error>");
				Console.WriteLine ( miserrores.recuperar_errores());
			}
			
			
			try
			{
			 MiXml = new Xml(xmlprueba);
			}catch(Exception ex)
			{
				miserrores.escribir_error("<error>" + "Carga XML Registro 1" + ";" + "" + ";" + ex.Message + "</error>");
				Console.WriteLine ( miserrores.recuperar_errores());
			}
			
			
			registrotipo1_1 miregistrotipo1_1 = new registrotipo1_1();
			
			miregistrotipo1_1.errores = miserrores;
			
			miregistrotipo1_1.ano_tributario = "2023";
			miregistrotipo1_1.numero_formulario = "1887";
			
			
			miregistrotipo1_1.tipo_registro = "";
			miregistrotipo1_1.determina_orden_preced = "1";
			miregistrotipo1_1.codigo_presentacion = "I";
			miregistrotipo1_1.n_de_folio = folio_global;
			miregistrotipo1_1.tipo_declaracion = "O";  //solicitar
			miregistrotipo1_1.numero_rut_anterior = "00000000";
			miregistrotipo1_1.digito_verificador_anterior = "0";
			miregistrotipo1_1.codigo_presentacion = "O"; //solicitar
			miregistrotipo1_1.n_de_folio_anterior = "0";
			miregistrotipo1_1.razon_social = MiXml.get("razon_social",0);
			miregistrotipo1_1.numero_rut_declarante = MiXml.get("rut",0);
			miregistrotipo1_1.digito_verificador_declarante = MiXml.get("dvr",0);
			rut_empresa =  MiXml.get("rut",0);
			verificador = MiXml.get("dvr",0);
			
			rut_representante = MiXml.get("rut_rep_legal",0);
			dv_representante = MiXml.get("dvr_rep_legal",0);
			//recupero la linea 
			
			string resultado1_1 = miregistrotipo1_1.retorna_registro_tipo_1_1(2023);
			
			//mato la instancia
			miregistrotipo1_1 = null;
			
			outputFile.WriteLine (resultado1_1);
			
			
			
			registrotipo1_2 miregistrotipo1_2 = new registrotipo1_2();
			
			miregistrotipo1_2.errores = miserrores;
			miregistrotipo1_2.tipo_registro = "1";
			miregistrotipo1_2.determina_orden_preced = "2";
			
			miregistrotipo1_2.direccion_postal = MiXml.get("direccion",0);
			miregistrotipo1_2.comuna = MiXml.get("comuna",0);
			miregistrotipo1_2.correo_electronico = MiXml.get("correo_electronico",0); //No esta en el xml
			miregistrotipo1_2.codigo_pais = "56";
			miregistrotipo1_2.cod_area_ciudad =  MiXml.get("cod_area_ciudad",0);
			miregistrotipo1_2.telefono = MiXml.get("telefono",0);
			
			//aca van 248 blancos
			
			//genera salida
			string resultado1_2 = miregistrotipo1_2.retorna_registro_tipo_1_2(2023);
			
			//cierra instalnacia
			miregistrotipo1_2 = null;
			
			outputFile.WriteLine (resultado1_2);
			
			
			
			registrotipo1_3 miregistrotipo1_3 = new registrotipo1_3();
			
			miregistrotipo1_3.errores = miserrores;
			
			miregistrotipo1_3.tipo_registro = "1";
			miregistrotipo1_3.determina_orden_preced = "3";
			
			miregistrotipo1_3.codigo_pais = "56";
			miregistrotipo1_3.cod_area_ciudad = MiXml.get("cod_area_ciudad",0);
			miregistrotipo1_3.telefono = MiXml.get("telefono",0);
			
			
			miregistrotipo1_3.codigo_empresa = "74";
			miregistrotipo1_3.numero_cliente = "999";
			miregistrotipo1_3.unidad = "0";
			miregistrotipo1_3.numero_caja = "0";
			miregistrotipo1_3.numero_paquete = "0";
			
			//308 blancos
			
			//genera salida
			string resultado1_3 = miregistrotipo1_3.retorna_registro_tipo_1_3(2023);
			
			//cierra instalnacia
			miregistrotipo1_3 = null;
			
			MiXml = null;
			outputFile.WriteLine (resultado1_3);
			
			
			try
			{
				 StreamReader sr = new StreamReader(@"C:\Desarrollo\Documentacion DDJJ\archivo_detalle.xml");
				 xmlprueba = sr.ReadToEnd();
				 sr.Close();
			}catch(Exception ex)
			{
				Console.Write("Error al leer el XML presione una tecla para terminar . . . ");
				miserrores.escribir_error("<error>" + "Carga XML Registro 1" + ";" + "" + ";" + ex.Message + "</error>");
				Console.WriteLine ( miserrores.recuperar_errores());
			}
			
			
			try{
				MiXml = new Xml(xmlprueba);
			}
			catch(Exception ex)
			{
				miserrores.escribir_error("<error>" + "Carga XML Registro 1" + ";" + "" + ";" + ex.Message + "</error>");
				Console.WriteLine ( miserrores.recuperar_errores());
			}
			
			int cantidad_detalle = MiXml.count();
			
			for (int contador = 0 ;contador< cantidad_detalle;contador++)
			{
					registrotipo2 miregistrotipo2 = new registrotipo2();
					
					miregistrotipo2.errores = miserrores;
					
					miregistrotipo2.tipo_registro = "2";
					
					
					miregistrotipo2.numero_formulario = "1887";
					
					miregistrotipo2.codigo_presentacion = "13";
					miregistrotipo2.n_de_folio = "0000008";
					
					miregistrotipo2.numero_rut =rut_empresa;
					miregistrotipo2.digito_verificador =verificador;
					
					miregistrotipo2.numero_rut_receptor = MiXml.get("rut_trabajador",contador).Split('-')[0].ToString();
					miregistrotipo2.digito_verificador_receptor = MiXml.get("rut_trabajador",contador).Split('-')[1].ToString();
					
					miregistrotipo2.renta_total_neta = MiXml.get("renta_imponible",contador);
					miregistrotipo2.imp_uni_sgda_cat_ret = MiXml.get("impuesto",contador);
					miregistrotipo2.renta_total_no_grabada = MiXml.get("renta_no_grabada",contador);
					miregistrotipo2.renta_total_exenta = MiXml.get("renta_exenta",contador);
					miregistrotipo2.rebaja_zona_exenta = MiXml.get("rebaja_zona",contador);
					miregistrotipo2.prestamos_tasa_0_2020_2021 = MiXml.get("prestamo_solidario",contador);
					miregistrotipo2.prestamos_enero = MiXml.get("m01",contador)=="" ? "0" :MiXml.get("m01",contador) ;
					miregistrotipo2.prestamos_febrero =MiXml.get("m02",contador)=="" ? "0" :MiXml.get("m02",contador) ;
					miregistrotipo2.prestamos_marzo = MiXml.get("m03",contador)=="" ? "0" :MiXml.get("m03",contador) ;
					miregistrotipo2.prestamos_abril = MiXml.get("m04",contador)=="" ? "0" :MiXml.get("m04",contador) ;
					miregistrotipo2.prestamos_mayo = MiXml.get("m05",contador)=="" ? "0" :MiXml.get("m05",contador) ;
					miregistrotipo2.prestamos_junio = MiXml.get("m06",contador)=="" ? "0" :MiXml.get("m06",contador) ;
					miregistrotipo2.prestamos_julio = MiXml.get("m07",contador)=="" ? "0" :MiXml.get("m07",contador) ;
					miregistrotipo2.prestamos_agosto = MiXml.get("m08",contador)=="" ? "0" :MiXml.get("m08",contador) ;
					miregistrotipo2.prestamos_septiembre = MiXml.get("m09",contador)=="" ? "0" :MiXml.get("m09",contador) ;
					miregistrotipo2.prestamos_octubre = MiXml.get("m10",contador)=="" ? "0" :MiXml.get("m10",contador) ;
					miregistrotipo2.prestamos_noviembre = MiXml.get("m11",contador)=="" ? "0" :MiXml.get("m11",contador) ;
					miregistrotipo2.prestamos_diciembre = MiXml.get("m12",contador)=="" ? "0" :MiXml.get("m12",contador) ;
					
					miregistrotipo2.numero_certificado =  MiXml.get("certificado",contador);
					
					
					
					miregistrotipo2.monto_ingreso_enero = MiXml.get("ingreso01",contador)=="" ? "0" :MiXml.get("ingreso01",contador) ;
					miregistrotipo2.monto_ingreso_febrero = MiXml.get("ingreso02",contador)=="" ? "0" :MiXml.get("ingreso02",contador) ;
					miregistrotipo2.monto_ingreso_marzo = MiXml.get("ingreso03",contador)=="" ? "0" :MiXml.get("ingreso03",contador) ;
					miregistrotipo2.monto_ingreso_abril =MiXml.get("ingreso04",contador)=="" ? "0" :MiXml.get("ingreso04",contador) ;
					miregistrotipo2.monto_ingreso_mayo = MiXml.get("ingreso05",contador)=="" ? "0" :MiXml.get("ingreso05",contador) ;
					miregistrotipo2.monto_ingreso_junio = MiXml.get("ingreso06",contador)=="" ? "0" :MiXml.get("ingreso06",contador) ;
					miregistrotipo2.monto_ingreso_julio = MiXml.get("ingreso07",contador)=="" ? "0" :MiXml.get("ingreso07",contador) ;
					miregistrotipo2.monto_ingreso_agosto = MiXml.get("ingreso08",contador)=="" ? "0" :MiXml.get("ingreso08",contador) ;
					miregistrotipo2.monto_ingreso_septiembre = MiXml.get("ingreso09",contador)=="" ? "0" :MiXml.get("ingreso09",contador) ;
					miregistrotipo2.monto_ingreso_octubre = MiXml.get("ingreso10",contador)=="" ? "0" :MiXml.get("ingreso10",contador) ;
					miregistrotipo2.monto_ingreso_noviembre = MiXml.get("ingreso11",contador)=="" ? "0" :MiXml.get("ingreso11",contador) ;
					miregistrotipo2.monto_ingreso_diciembre = MiXml.get("ingreso12",contador)=="" ? "0" :MiXml.get("ingreso12",contador) ;
					
					//59 blancos
					
					
					//genera salida
					
					string resultado2 = miregistrotipo2.retorna_registro_tipo_2(2023);
					
					//cierra instalnacia
					miregistrotipo2 = null;
					
					
					outputFile.WriteLine (resultado2);
					
			
			}
				
			
			
			
			
			
			try
			{
				 StreamReader sr = new StreamReader(@"C:\Desarrollo\Documentacion DDJJ\archivo_totales.xml");
				 xmlprueba = sr.ReadToEnd();
				 sr.Close();
			}catch(Exception ex)
			{
				Console.Write("Error al leer el XML presione una tecla para terminar . . . ");
				miserrores.escribir_error("<error>" + "Carga XML Registro 3 1" + ";" + "" + ";" + ex.Message + "</error>");
				Console.WriteLine ( miserrores.recuperar_errores());
			}
			
			
			try{
				MiXml = new Xml(xmlprueba);
			}
			catch(Exception ex)
			{
				miserrores.escribir_error("<error>" + "Carga XML Registro 3 1" + ";" + "" + ";" + ex.Message + "</error>");
				Console.WriteLine ( miserrores.recuperar_errores());
			}
			
			
	
			
			registrotipo3_1 miregistrotipo3_1 = new registrotipo3_1();
			
			miregistrotipo3_1.errores = miserrores;
			miregistrotipo3_1.tipo_registro = "3";
			miregistrotipo3_1.numero_formulario = "1887";
			miregistrotipo3_1.determina_orden_preced = "1";
			
			miregistrotipo3_1.codigo_presentacion = "13";
			miregistrotipo3_1.folio = "0000008";
			
			miregistrotipo3_1.numero_rut = rut_empresa;
			miregistrotipo3_1.digito_verificador = verificador;
			miregistrotipo3_1.renta_total_neta_pagada =MiXml.get("renta_imponible",0);
			miregistrotipo3_1.imp_uni_ret_seg_cat = MiXml.get("imp_seg_categoria",0);
			miregistrotipo3_1.imp_uni_ret_seg_cat_comp_ene_abr =  MiXml.get("impuesto",0);
			miregistrotipo3_1.renta_total_no_pagada = MiXml.get("renta_no_grabada",0);
			miregistrotipo3_1.renta_total_exenta =  MiXml.get("renta_exenta",0);
			miregistrotipo3_1.prestamos_tasa_0 = MiXml.get("prestamo_solidario",0);
			miregistrotipo3_1.total_remuneracion_imp_actual = MiXml.get("renta_imponible",0);
			
			miregistrotipo3_1.monto_ing_men_s_act_ene = MiXml.get("ingreso01",0);
			miregistrotipo3_1.monto_ing_men_s_act_feb = MiXml.get("ingreso02",0);
			miregistrotipo3_1.monto_ing_men_s_act_mar = MiXml.get("ingreso03",0);
			miregistrotipo3_1.monto_ing_men_s_act_abr = MiXml.get("ingreso04",0);
			miregistrotipo3_1.monto_ing_men_s_act_may = MiXml.get("ingreso05",0);
			miregistrotipo3_1.monto_ing_men_s_act_jun = MiXml.get("ingreso06",0);
			miregistrotipo3_1.monto_ing_men_s_act_jul = MiXml.get("ingreso07",0);
			miregistrotipo3_1.monto_ing_men_s_act_ago = MiXml.get("ingreso08",0);
			miregistrotipo3_1.monto_ing_men_s_act_sep = MiXml.get("ingreso09",0);
			miregistrotipo3_1.monto_ing_men_s_act_oct = MiXml.get("ingreso10",0);
			miregistrotipo3_1.monto_ing_men_s_act_nov = MiXml.get("ingreso11",0);
			miregistrotipo3_1.monto_ing_men_s_act_dic = MiXml.get("ingreso12",0);
			
			
			string resultado3_1 = miregistrotipo3_1.retorna_registro_tipo_3_1(2023);
					
		
			
			
			outputFile.WriteLine (resultado3_1);
			
			miregistrotipo3_1 = null;
			
			
			registrotipo3_2 miregistrotipo3_2 = new registrotipo3_2();
			
			miregistrotipo3_2.errores = miserrores;
			miregistrotipo3_2.tipo_registro = "3";
			
			miregistrotipo3_2.determina_orden_preced = "2";
			miregistrotipo3_2.renta_total_neta_pagada = MiXml.get("renta_imponible",0);
			miregistrotipo3_2.imp_unico_retenido = MiXml.get("impuesto",0);
			miregistrotipo3_2.mayor_retencion_solicitada = MiXml.get("mayor_retencion",0);
			miregistrotipo3_2.renta_total_no_grabada = MiXml.get("renta_no_grabada",0);
			miregistrotipo3_2.renta_total_exenta = MiXml.get("renta_exenta",0);
			miregistrotipo3_2.rebaja_zona_extrema =  MiXml.get("rebaja_zona",0);
			miregistrotipo3_2.prestamos_tasa_0_2020_2021 = MiXml.get("prestamo_solidario",0);
			miregistrotipo3_2.total_casos_importados = cantidad_detalle.ToString();
			miregistrotipo3_2.dia_presentacion = DateTime.Now.Day.ToString();
			miregistrotipo3_2.mes_presentacion = DateTime.Now.Month.ToString();
			miregistrotipo3_2.ano_presentacion = DateTime.Now.Year.ToString();
			miregistrotipo3_2.numero_rut_representante = rut_representante ;
			miregistrotipo3_2.digito_verificador = dv_representante;
			
			//206 blancos
			
			
			string resultado3_2 = miregistrotipo3_2.retorna_registro_tipo_3_2(2023);
					
		
			
			
			outputFile.WriteLine (resultado3_2);
			
			//cierra instalnacia
			miregistrotipo3_2 = null;
			
			
			outputFile.Close();
			
			Console.WriteLine ( miserrores.recuperar_errores());
			
//			Console.Write("Listado errores . . . ");
//			Console.Write(miserrores.recuperar_errores());
			
			Console.Write("Press any key to continue . . . ");
			
			
			Console.ReadKey(true);
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
