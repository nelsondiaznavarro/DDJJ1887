/*
 * Created by SharpDevelop.
 * User: rjc
 * Date: 28-12-2022
 * Time: 13:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace DDJJ1887
{
	/// <summary>
	/// Description of RegistroTipo3.
	/// </summary>
	public class registrotipo3_1
	{
		
		
		public registrotipo3_1()
		{
			this.imp_uni_ret_seg_cat_comp_ene_abr = "0";
		}
		
		public  errores errores  {get; set;}
		
		
		public string tipo_registro
	    {
	        get { return _tipo_registro; }
	        set
	        {
	        	int _tipo_registro_paso = 0;
	        	if (string.IsNullOrEmpty(value.ToString()))
	                errores.escribir_error("<fila><error>" + "Registro tipo 3 1" + ";" + "Tipo Registro" + ";" + "valor no puede ser vacio" + "<fila><error>");
	        	if (value.Length != 1)
	        		errores.escribir_error("<fila><error>" + "Registro tipo 3 1" + ";" + "Tipo Registro" + ";" + "valor debe ser un numero de un digito" + "<fila><error>");
	        	if (!int.TryParse(value, out _tipo_registro_paso))
	        	{
	        		errores.escribir_error("<fila><error>" + "Registro tipo 3 1" + ";" + "Tipo Registro" + ";" + "valor debe ser un numero" + "<fila><error>");
	        	}
	        	if ( _tipo_registro_paso != 3)
	        	{
	        		errores.escribir_error("<fila><error>" + "Registro tipo  3 1" + ";" + "Tipo Registro" + ";" + "valor debe ser el numero 3" + "<fila><error>");
	        	}
	        	_tipo_registro = _tipo_registro_paso.ToString();
	        }
	    }
    	private string _tipo_registro;
    	
     	public string determina_orden_preced
	    {
	        get { return _determina_orden_preced; }
	        set
	        {
	        	int _determina_orden_preced_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                errores.escribir_error("<fila><error>" + "Registro tipo 3 1" + ";" + "Orden Preced" + ";" + "valor no puede ser vacio" + "<fila><error>");
	        	if (!int.TryParse(value, out _determina_orden_preced_paso))
	            	errores.escribir_error("<fila><error>" + "Registro tipo 3 1" + ";" + "Orden Preced" + ";" + "valor debe ser numérico" + "<fila><error>");
	        	if (_determina_orden_preced_paso!=1)
	            	errores.escribir_error("<fila><error>" + "Registro tipo 3 1" + ";" + "Orden Preced" + ";" + "valor debe el número 1" + "<fila><error>");
	        	_determina_orden_preced = _determina_orden_preced_paso.ToString();
	        }
	    }
    	private string _determina_orden_preced;
    	
    	public string numero_formulario
	    {
	        get { return _numero_formulario; }
	        set
	        {
	        	int _numero_formulario_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                errores.escribir_error("<fila><error>" + "Registro tipo 3 1" + ";" + "Orden Preced" + ";" + "valor no puede ser vacio" + "<fila><error>");
	        	if (!int.TryParse(value, out _numero_formulario_paso))
	            	errores.escribir_error("<fila><error>" + "Registro tipo 3 1" + ";" + "Orden Preced" + ";" + "valor debe ser numérico" + "<fila><error>");
	        	if (_numero_formulario_paso!=1887)
	            	errores.escribir_error("<fila><error>" + "Registro tipo 3 1" + ";" + "Orden Preced" + ";" + "valor debe el número 1" + "<fila><error>");
	        	_numero_formulario = _numero_formulario_paso.ToString();
	        }
	    }
    	private string _numero_formulario;
    	
    	public string codigo_presentacion
	    {
	        get { return _codigo_presentacion; }
	        set
	        {
	        	
	        	if (string.IsNullOrEmpty(value.ToString()))
	                errores.escribir_error("<fila><error>" + "Registro tipo 3 1" + ";" + "Código Presentación" + ";" + "valor no puede ser vacio" + "<fila><error>");
	        	if (value != "I")
	                errores.escribir_error("<fila><error>" + "Registro tipo 3 1" + ";" + "Código Presentación" + ";" + "valor debe ser la letra I" + "<fila><error>");
	        	_codigo_presentacion = value;
	        }
	    }
    	private string _codigo_presentacion;
    	
    	public string folio
	    {
	        get { return _n_de_folio; }
	        set
	        {
	        	int _folio_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                errores.escribir_error("<fila><error>" + "Registro tipo 3 1" + ";" + "Folio" + ";" + "valor no puede ser vacio" + "<fila><error>");
	        	if (!int.TryParse(value, out _folio_paso) )
	            	errores.escribir_error("<fila><error>" + "Registro tipo 3 1" + ";" + "Folio" + ";" + "valor debe ser numerico" + "<fila><error>");
	        	if (_folio_paso < 1 )
	        		errores.escribir_error("<fila><error>" + "Registro tipo 3 1" + ";" + "Folio" + ";" + "valor debe ser numerico mayor a cero" + "<fila><error>");
	        	_n_de_folio = _folio_paso.ToString().PadLeft(7,'0');
	        }
	    }
    	private string _n_de_folio;
    	
    	
		public string numero_rut
	    {
	        get { return _numero_rut; }
	        set
	        {
	        	int _numero_rut_paso = 0;
	        	if (string.IsNullOrEmpty(value.ToString()))
	                errores.escribir_error("<fila><error>" + "Registro tipo 3 1" + ";" + "Número de RUT" + ";" + "valor no puede ser vacio" + "<fila><error>");
	        	if (!int.TryParse(value, out _numero_rut_paso))
	            	errores.escribir_error("<fila><error>" + "Registro tipo 3 1" + ";" + "Número de RUT" + ";" + "valor debe ser un numero mayor a cero" + "<fila><error>");
	        	
	        	_numero_rut = _numero_rut_paso.ToString().PadLeft(8, '0');
	        }
	    }
    	private string _numero_rut;
    	
    	public string digito_verificador
	    {
	        get { return _digito_verificador; }
	        set
	        {
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                errores.escribir_error("<fila><error>" + "Registro tipo 3 1" + ";" + "Digito Verificador" + ";" + "valor no puede ser vacio" + "<fila><error>");
	        	if (value.Length !=1)
	        		errores.escribir_error("<fila><error>" + "Registro tipo 3 1" + ";" + "Digito Verificador" + ";" + "valor debe ser un caracter" + "<fila><error>");
	        	if (value != validaciones.Digito (int.Parse( this.numero_rut)))
	        		errores.escribir_error("<fila><error>" + "Registro tipo 3 1" + ";" + "Digito Verificador" + ";" + "Rut invalido, error en  Digito Verrificador" + "<fila><error>");
	        	_digito_verificador = value;
	        }
	    }
    	private string _digito_verificador;
    	
    	public string renta_total_neta_pagada
	    {
	        get { return _renta_total_neta; }
	        set
	        {
	        	int _renta_total_neta_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                errores.escribir_error("<fila><error>" + "Registro tipo 3 1" + ";" + "Renta total Neta" + ";" + "valor no puede ser vacio" + "<fila><error>");
	        	if (!int.TryParse(value, out _renta_total_neta_paso))
	        	{
	        		errores.escribir_error("<fila><error>" + "Registro tipo 3 1" + ";" + "Renta total Neta" + ";" + "valor debe ser numérico" + "<fila><error>");
	        	}else
	        	{
	        		if (_renta_total_neta_paso < 1 )
	        		{
	        			errores.escribir_error("<fila><error>" + "Registro tipo 3 1" + ";" + "Renta total Neta" + ";" + "valor debe ser mayor a cero" + "<fila><error>");
	        		}else
	        		{
	        			_renta_total_neta = _renta_total_neta_paso.ToString().PadLeft(15,'0');
	        		}
	        	}
	        }
	    }
    	private string _renta_total_neta;
    	
    	
    	//IMPUESTO UNICO  DE SEGUNDA CATEGORÍA  RETENIDO POR RENTA TOTAL NETA PAGADA DURANTE EL AÑO
    	
    	public string imp_uni_ret_seg_cat
	    {
	        get { return _imp_uni_ret_seg_cat; }
	        set
	        {
	        	int _imp_uni_ret_seg_cat_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                errores.escribir_error("<fila><error>" + "Registro tipo 3 1" + ";" + "IMPUESTO UNICO  DE SEGUNDA CATEGORÍA  RETENIDO POR RENTA TOTAL NETA PAGADA DURANTE EL AÑO" + ";" + "valor no puede ser vacio" + "<fila><error>");
	        	if (!int.TryParse(value, out _imp_uni_ret_seg_cat_paso))
	        	{
	            	errores.escribir_error("<fila><error>" + "Registro tipo 3 1" + ";" + "IMPUESTO UNICO  DE SEGUNDA CATEGORÍA  RETENIDO POR RENTA TOTAL NETA PAGADA DURANTE EL AÑO" + ";" + "valor debe ser numérico" + "<fila><error>");
	        	}else
	        	{
	        		
	        		_imp_uni_ret_seg_cat = _imp_uni_ret_seg_cat_paso.ToString().PadLeft(15,'0');
	        		
	        	}
	        	
	        }
	    }
    	private string _imp_uni_ret_seg_cat;
    	
    	//IMPUESTO UNICO  DE SEGUNDA CATEGORÍA RETENIDO POR RENTAS ACCESORIAS Y/O COMPLEMENTARIA PAGADA ENTRE ENE-ABR. AÑO SGTE. 
    	public string imp_uni_ret_seg_cat_comp_ene_abr
	    {
	        get { return _imp_uni_ret_seg_cat_comp_ene_abr; }
	        set
	        {
	        	int _imp_uni_ret_seg_cat_comp_ene_abr_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                errores.escribir_error("<fila><error>" + "Registro tipo 3 1" + ";" + "IMPUESTO UNICO  DE SEGUNDA CATEGORÍA  RETENIDO POR RENTA TOTAL NETA PAGADA DURANTE EL AÑO Y/O COMPLEMENTARIA PAGADA ENTRE ENE-ABR. AÑO SGTE. " + ";" + "valor no puede ser vacio" + "<fila><error>");
	        	if (!int.TryParse(value, out _imp_uni_ret_seg_cat_comp_ene_abr_paso))
	        	{
	            	errores.escribir_error("<fila><error>" + "Registro tipo 3 1" + ";" + "IMPUESTO UNICO  DE SEGUNDA CATEGORÍA  RETENIDO POR RENTA TOTAL NETA PAGADA DURANTE EL AÑO Y/O COMPLEMENTARIA PAGADA ENTRE ENE-ABR. AÑO SGTE. " + ";" + "valor debe ser numérico" + "<fila><error>");
	        	}else
	        	{
	        		
	        			_imp_uni_ret_seg_cat_comp_ene_abr = _imp_uni_ret_seg_cat_comp_ene_abr_paso.ToString().PadLeft(15,'0');
	        		
	        	}
	        	
	        	
	        }
	    }
    	private string _imp_uni_ret_seg_cat_comp_ene_abr;
    	
    	public string renta_total_no_grabada
	    {
	        get { return _renta_total_no_grabada; }
	        set
	        {
	        	int _renta_total_no_grabada_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                errores.escribir_error("<fila><error>" + "Registro tipo 3 1" + ";" + "Renta total no grabada" + ";" + "valor no puede ser vacio" + "<fila><error>");
	        	if (!int.TryParse(value, out _renta_total_no_grabada_paso))
	            	errores.escribir_error("<fila><error>" + "Registro tipo 3 1" + ";" + "Renta total no grabada" + ";" + "valor debe ser numérico" + "<fila><error>");
	        	_renta_total_no_grabada = _renta_total_no_grabada_paso.ToString().PadLeft(15,'0');
	        }
	    }
    	private string _renta_total_no_grabada;
    	
    	public string renta_total_exenta
	    {
	        get { return _renta_total_exenta; }
	        set
	        {
	        	int _renta_total_exenta_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                errores.escribir_error("<fila><error>" + "Registro tipo 3 1" + ";" + "Renta total exenta" + ";" + "valor no puede ser vacio" + "<fila><error>");
	        	if (!int.TryParse(value, out _renta_total_exenta_paso))
	            	errores.escribir_error("<fila><error>" + "Registro tipo 3 1" + ";" + "Renta total exenta" + ";" + "valor debe ser numérico" + "<fila><error>");
	        	_renta_total_exenta = _renta_total_exenta_paso.ToString().PadLeft(15,'0');
	        }
	    }
    	private string _renta_total_exenta;
    	
    	public string rebaja_zona_extrema
	    {
	        get { return _rebaja_zona_extrema; }
	        set
	        {
	        	int _rebaja_zona_extrema_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                errores.escribir_error("<fila><error>" + "Registro tipo 3 1" + ";" + "Rebaja Zona Extrema" + ";" + "valor no puede ser vacio" + "<fila><error>");
	        	if (!int.TryParse(value, out _rebaja_zona_extrema_paso))
	            	errores.escribir_error("<fila><error>" + "Registro tipo 3 1" + ";" + "Rebaja Zona Extrema" + ";" + "valor debe ser numérico" + "<fila><error>");
	        	_rebaja_zona_extrema = _rebaja_zona_extrema_paso.ToString().PadLeft(15,'0');
	        }
	    }
    	private string _rebaja_zona_extrema;
    	
    	public string leyes_sociales
	    {
	        get { return _leyes_sociales; }
	        set
	        {
	        	int _leyes_sociales_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                errores.escribir_error("<fila><error>" + "Registro tipo 3 1" + ";" + "Leyes sociales" + ";" + "valor no puede ser vacio" + "<fila><error>");
	        	if (!int.TryParse(value, out _leyes_sociales_paso))
	            	errores.escribir_error("<fila><error>" + "Registro tipo 3 1" + ";" + "Leyes sociales" + ";" + "valor debe ser numérico" + "<fila><error>");
	        	_leyes_sociales = _leyes_sociales_paso.ToString().PadLeft(15,'0');
	        }
	    }
    	private string _leyes_sociales;
    	
    	public string prestamos_tasa_0
	    {
	        get { return _prestamos_tasa_0; }
	        set
	        {
	        	int _prestamos_tasa_0_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                errores.escribir_error("<fila><error>" + "Registro tipo 3 1" + ";" + "Prestamos tasa 0" + ";" + "valor no puede ser vacio" + "<fila><error>");
	        	if (!int.TryParse(value, out _prestamos_tasa_0_paso))
	            	errores.escribir_error("<fila><error>" + "Registro tipo 3 1" + ";" + "Prestamos tasa 0" + ";" + "valor debe ser numérico" + "<fila><error>");
	        	_prestamos_tasa_0 = _prestamos_tasa_0_paso.ToString().PadLeft(18,'0');
	        }
	    }
    	private string _prestamos_tasa_0;
    	
    	public string total_remuneracion_imp_actual
	    {
	        get { return _total_remuneracion_imp_actual; }
	        set
	        {
	        	int _total_remuneracion_imp_actual_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                errores.escribir_error("<fila><error>" + "Registro tipo 3 1" + ";" + "Total Remuneracion imponible" + ";" + "valor no puede ser vacio" + "<fila><error>");
		        	if (!int.TryParse(value, out _total_remuneracion_imp_actual_paso))
		        	{
		        		if (_renta_total_neta_paso < 1 )
		        		{
		        			errores.escribir_error("<fila><error>" + "Registro tipo 3 1" + ";" + "Renta total Neta" + ";" + "valor debe ser mayor a cero" + "<fila><error>");
		        		}else
		        		{
		        			_total_remuneracion_imp_actual = _total_remuneracion_imp_actual_paso.ToString().PadLeft(15,'0');
		        		}
		        	}
		        	
	        	}
	            	
	        	
	        }
	    
    	private string _total_remuneracion_imp_actual;
    	
    	//MONTO INGRESO MENSUAL (SIN ACTUALIZAR)
    	public string monto_ing_men_s_act_ene
	    {
	        get { return _monto_ing_men_s_act_ene; }
	        set
	        {
	        	int _monto_ing_men_s_act_ene_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                errores.escribir_error("<fila><error>" + "Registro tipo 3 1" + ";" + "Monto ingreso sin actualiza Enero" + ";" + "valor no puede ser vacio" + "<fila><error>");
	        	if (!int.TryParse(value, out _monto_ing_men_s_act_ene_paso))
	            	errores.escribir_error("<fila><error>" + "Registro tipo 3 1" + ";" + "Monto ingreso sin actualiza Enero" + ";" + "valor debe ser numérico" + "<fila><error>");
	        	_monto_ing_men_s_act_ene = _monto_ing_men_s_act_ene_paso.ToString().PadLeft(15,'0');
	        }
	    }
    	private string _monto_ing_men_s_act_ene;
    	
    	public string monto_ing_men_s_act_feb
	    {
	        get { return _monto_ing_men_s_act_feb; }
	        set
	        {
	        	int _monto_ing_men_s_act_feb_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                errores.escribir_error("<fila><error>" + "Registro tipo 3 1" + ";" + "Monto ingreso sin actualiza Febrero" + ";" + "valor no puede ser vacio" + "<fila><error>");
	        	if (!int.TryParse(value, out _monto_ing_men_s_act_feb_paso))
	            	errores.escribir_error("<fila><error>" + "Registro tipo 3 1" + ";" + "Monto ingreso sin actualiza Febrero" + ";" + "valor debe ser numérico" + "<fila><error>");
	        	_monto_ing_men_s_act_feb = _monto_ing_men_s_act_feb_paso.ToString().PadLeft(15,'0');
	        }
	    }
    	private string _monto_ing_men_s_act_feb;
    	
    	public string monto_ing_men_s_act_mar
	    {
	        get { return _monto_ing_men_s_act_mar; }
	        set
	        {
	        	int _monto_ing_men_s_act_mar_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                errores.escribir_error("<fila><error>" + "Registro tipo 3 1" + ";" + "Monto ingreso sin actualiza Marzo" + ";" + "valor no puede ser vacio" + "<fila><error>");
	        	if (!int.TryParse(value, out _monto_ing_men_s_act_mar_paso))
	            	errores.escribir_error("<fila><error>" + "Registro tipo 3 1" + ";" + "Monto ingreso sin actualiza Marzo" + ";" + "valor debe ser numérico" + "<fila><error>");
	        	_monto_ing_men_s_act_mar = _monto_ing_men_s_act_mar_paso.ToString().PadLeft(15,'0');
	        }
	    }
    	private string _monto_ing_men_s_act_mar;
    	
    	public string monto_ing_men_s_act_abr
	    {
	        get { return _monto_ing_men_s_act_abr; }
	        set
	        {
	        	int _monto_ing_men_s_act_abr_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                errores.escribir_error("<fila><error>" + "Registro tipo 3 1" + ";" + "Monto ingreso sin actualiza Abril" + ";" + "valor no puede ser vacio" + "<fila><error>");
	        	if (!int.TryParse(value, out _monto_ing_men_s_act_abr_paso))
	            	errores.escribir_error("<fila><error>" + "Registro tipo 3 1" + ";" + "Monto ingreso sin actualiza Abril" + ";" + "valor debe ser numérico" + "<fila><error>");
	        	_monto_ing_men_s_act_abr = _monto_ing_men_s_act_abr_paso.ToString().PadLeft(15,'0');
	        }
	    }
    	private string _monto_ing_men_s_act_abr;
    	
    	public string monto_ing_men_s_act_may
	    {
	        get { return _monto_ing_men_s_act_may; }
	        set
	        {
	        	int _monto_ing_men_s_act_may_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                errores.escribir_error("<fila><error>" + "Registro tipo 3 1" + ";" + "Monto ingreso sin actualiza Mayo" + ";" + "valor no puede ser vacio" + "<fila><error>");
	        	if (!int.TryParse(value, out _monto_ing_men_s_act_may_paso))
	            	errores.escribir_error("<fila><error>" + "Registro tipo 3 1" + ";" + "Monto ingreso sin actualiza Mayo" + ";" + "valor debe ser numérico" + "<fila><error>");
	        	_monto_ing_men_s_act_may = _monto_ing_men_s_act_may_paso.ToString().PadLeft(15,'0');
	        }
	    }
    	private string _monto_ing_men_s_act_may;
    	
    	public string monto_ing_men_s_act_jun
	    {
	        get { return _monto_ing_men_s_act_jun; }
	        set
	        {
	        	int _monto_ing_men_s_act_jun_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                errores.escribir_error("<fila><error>" + "Registro tipo 3 1" + ";" + "Monto ingreso sin actualiza Junio" + ";" + "valor no puede ser vacio" + "<fila><error>");
	        	if (!int.TryParse(value, out _monto_ing_men_s_act_jun_paso))
	            	errores.escribir_error("<fila><error>" + "Registro tipo 3 1" + ";" + "Monto ingreso sin actualiza Junio" + ";" + "valor debe ser numérico" + "<fila><error>");
	        	_monto_ing_men_s_act_jun = _monto_ing_men_s_act_jun_paso.ToString().PadLeft(15,'0');
	        }
	    }
    	private string _monto_ing_men_s_act_jun;
    	
    	public string monto_ing_men_s_act_jul
	    {
	        get { return _monto_ing_men_s_act_jul; }
	        set
	        {
	        	int _monto_ing_men_s_act_jul_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                errores.escribir_error("<fila><error>" + "Registro tipo 3 1" + ";" + "Monto ingreso sin actualiza Julio" + ";" + "valor no puede ser vacio" + "<fila><error>");
	        	if (!int.TryParse(value, out _monto_ing_men_s_act_jul_paso))
	            	errores.escribir_error("<fila><error>" + "Registro tipo 3 1" + ";" + "Monto ingreso sin actualiza Julio" + ";" + "valor debe ser numérico" + "<fila><error>");
	        	_monto_ing_men_s_act_jul = _monto_ing_men_s_act_jul_paso.ToString().PadLeft(15,'0');
	        }
	    }
    	private string _monto_ing_men_s_act_jul;
    	
    	public string monto_ing_men_s_act_ago
	    {
	        get { return _monto_ing_men_s_act_ago; }
	        set
	        {
	        	int _monto_ing_men_s_act_ago_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                errores.escribir_error("<fila><error>" + "Registro tipo 3 1" + ";" + "Monto ingreso sin actualiza Agosto" + ";" + "valor no puede ser vacio" + "<fila><error>");
	        	if (!int.TryParse(value, out _monto_ing_men_s_act_ago_paso))
	            	errores.escribir_error("<fila><error>" + "Registro tipo 3 1" + ";" + "Monto ingreso sin actualiza Agosto" + ";" + "valor debe ser numérico" + "<fila><error>");
	        	_monto_ing_men_s_act_ago = _monto_ing_men_s_act_ago_paso.ToString().PadLeft(15,'0');
	        }
	    }
    	private string _monto_ing_men_s_act_ago;
    	
    	public string monto_ing_men_s_act_sep
	    {
	        get { return _monto_ing_men_s_act_sep; }
	        set
	        {
	        	int _monto_ing_men_s_act_sep_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                errores.escribir_error("<fila><error>" + "Registro tipo 3 1" + ";" + "Monto ingreso sin actualiza Septiembre" + ";" + "valor no puede ser vacio" + "<fila><error>");
	        	if (!int.TryParse(value, out _monto_ing_men_s_act_sep_paso))
	            	errores.escribir_error("<fila><error>" + "Registro tipo 3 1" + ";" + "Monto ingreso sin actualiza Septiembre" + ";" + "valor debe ser numérico" + "<fila><error>");
	        	_monto_ing_men_s_act_sep = _monto_ing_men_s_act_sep_paso.ToString();
	        }
	    }
    	private string _monto_ing_men_s_act_sep;
    	
    	public string monto_ing_men_s_act_oct
	    {
	        get { return _monto_ing_men_s_act_oct; }
	        set
	        {
	        	int _monto_ing_men_s_act_oct_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                errores.escribir_error("<fila><error>" + "Registro tipo 3 1" + ";" + "Monto ingreso sin actualiza Octubre" + ";" + "valor no puede ser vacio" + "<fila><error>");
	        	if (!int.TryParse(value, out _monto_ing_men_s_act_oct_paso))
	            	errores.escribir_error("<fila><error>" + "Registro tipo 3 1" + ";" + "Monto ingreso sin actualiza Octubre" + ";" + "valor debe ser numérico" + "<fila><error>");
	        	_monto_ing_men_s_act_oct = _monto_ing_men_s_act_oct_paso.ToString();
	        }
	    }
    	private string _monto_ing_men_s_act_oct;
    	
    	public string monto_ing_men_s_act_nov
	    {
	        get { return _monto_ing_men_s_act_nov; }
	        set
	        {
	        	int _monto_ing_men_s_act_nov_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                errores.escribir_error("<fila><error>" + "Registro tipo 3 1" + ";" + "Monto ingreso sin actualiza Noviembre" + ";" + "valor no puede ser vacio" + "<fila><error>");
	        	if (!int.TryParse(value, out _monto_ing_men_s_act_nov_paso))
	            	errores.escribir_error("<fila><error>" + "Registro tipo 3 1" + ";" + "Monto ingreso sin actualiza Noviembre" + ";" + "valor debe ser numérico" + "<fila><error>");
	        	_monto_ing_men_s_act_nov = _monto_ing_men_s_act_nov_paso.ToString();
	        }
	    }
    	private string _monto_ing_men_s_act_nov;
    	
    	public string monto_ing_men_s_act_dic
	    {
	        get { return _monto_ing_men_s_act_dic; }
	        set
	        {
	        	int _monto_ing_men_s_act_dic_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                errores.escribir_error("<fila><error>" + "Registro tipo 3 1" + ";" + "Monto ingreso sin actualiza Diciembre" + ";" + "valor no puede ser vacio" + "<fila><error>");
	        	if (!int.TryParse(value, out _monto_ing_men_s_act_dic_paso))
	            	errores.escribir_error("<fila><error>" + "Registro tipo 3 1" + ";" + "Monto ingreso sin actualiza Diciembre" + ";" + "valor debe ser numérico" + "<fila><error>");
	        	_monto_ing_men_s_act_dic = _monto_ing_men_s_act_dic_paso.ToString();
	        }
	    }
    	private string _monto_ing_men_s_act_dic;
    	
    	//MONTO INGRESO MENSUAL (SIN ACTUALIZAR)
	
    	
    	
    	
    	
    	public string retorna_registro_tipo_3_1(int anodj)
    	{
    		if (anodj == 2023)
    		{
    		string salida = this.tipo_registro + this.determina_orden_preced + this.numero_formulario + this.codigo_presentacion + this.folio
    						+ this.numero_rut + this.digito_verificador + this.renta_total_neta_pagada + this.imp_uni_ret_seg_cat + this.imp_uni_ret_seg_cat_comp_ene_abr 
							+ this.renta_total_no_grabada + this.renta_total_exenta + this.rebaja_zona_extrema + this.leyes_sociales + this.prestamos_tasa_0 + this.total_remuneracion_imp_actual
							+ this.monto_ing_men_s_act_ene + this.monto_ing_men_s_act_feb +     this.monto_ing_men_s_act_mar + this.monto_ing_men_s_act_abr + this._monto_ing_men_s_act_may 
    						+ this.monto_ing_men_s_act_jun + this.monto_ing_men_s_act_jul	+ this.monto_ing_men_s_act_ago + this._monto_ing_men_s_act_sep + this.monto_ing_men_s_act_oct		
    						+ this.monto_ing_men_s_act_nov + this.monto_ing_men_s_act_dic	;
    			return salida ;
    		}else
    		{
    			errores.escribir_error("<fila><error>" + "DDJJ 1887" + ";" + "retorna_registro_tipo_3_1" + ";" + "año no soportado para esta version" + "<fila><error>");
    			return "";
    		}
    	}
    	
	}


	public class registrotipo3_2
	{
		public registrotipo3_2()
		{
			//Inicializacion de valores constantes
			this.dia_presentacion = "00";
			this.mes_presentacion = "   ";
			this.ano_presentacion = "0000";
		}
		
		
		public  errores errores  {get; set;}
		
		public string tipo_registro
	    {
	        get { return _tipo_registro; }
	        set
	        {
	        	int _tipo_registro_paso = 0;
	        	if (string.IsNullOrEmpty(value.ToString()))
	                errores.escribir_error("<fila><error>" + "Registro tipo 3 2" + ";" + "Tipo Registro" + ";" + "valor no puede ser vacio" + "<fila><error>");
	        	if (value.Length != 1)
	        		errores.escribir_error("<fila><error>" + "Registro tipo 3 1" + ";" + "Tipo Registro" + ";" + "valor debe ser un numero de un digito" + "<fila><error>");
	        	if (!int.TryParse(value, out _tipo_registro_paso))
	        	{
	        		errores.escribir_error("<fila><error>" + "Registro tipo 3 2" + ";" + "Tipo Registro" + ";" + "valor debe ser un numero" + "<fila><error>");
	        	}
	        	if ( _tipo_registro_paso != 3)
	        	{
	        		errores.escribir_error("<fila><error>" + "Registro tipo  3 2" + ";" + "Tipo Registro" + ";" + "valor debe ser el numero 3" + "<fila><error>");
	        	}
	        	_tipo_registro = _tipo_registro_paso.ToString();
	        }
	    }
    	private string _tipo_registro;
    	
     	public string determina_orden_preced
	    {
	        get { return _determina_orden_preced; }
	        set
	        {
	        	int _determina_orden_preced_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                errores.escribir_error("<fila><error>" + "Registro tipo 3 2" + ";" + "Orden Preced" + ";" + "valor no puede ser vacio" + "<fila><error>");
	        	if (!int.TryParse(value, out _determina_orden_preced_paso))
	            	errores.escribir_error("<fila><error>" + "Registro tipo 3 2" + ";" + "Orden Preced" + ";" + "valor debe ser numérico" + "<fila><error>");
	        	if (_determina_orden_preced_paso!=2)
	            	errores.escribir_error("<fila><error>" + "Registro tipo 3 2" + ";" + "Orden Preced" + ";" + "valor debe el número 2" + "<fila><error>");
	        	_determina_orden_preced = _determina_orden_preced_paso.ToString();
	        }
	    }
    	private string _determina_orden_preced;
    	
    	public string tipo_declaracion
	    {
	        get { return _tipo_declaracion; }
	        set
	        {
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                errores.escribir_error("<fila><error>" + "Registro tipo 3 2" + ";" + "Tipo de Declaración" + ";" + "valor no puede ser vacio" + "<fila><error>");
	        	if (value != "O" && value != "R")
	                errores.escribir_error("<fila><error>" + "Registro tipo 3 2" + ";" + "Código Prestación" + ";" + "valor debe ser la letra O o letra R" + "<fila><error>");
	        	_tipo_declaracion = value;
	        }
	    }
    	private string _tipo_declaracion;
    	
    	
    	public string renta_total_neta_pagada
	    {
	        get { return _renta_total_neta_pagada; }
	        set
	        {
	        	int _renta_total_neta_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                errores.escribir_error("<fila><error>" + "Registro tipo 3 2" + ";" + "Renta total Neta" + ";" + "valor no puede ser vacio" + "<fila><error>");
	        	if (!int.TryParse(value, out _renta_total_neta_paso))
	        	{
	        		errores.escribir_error("<fila><error>" + "Registro tipo 3 2" + ";" + "Renta total Neta" + ";" + "valor debe ser numérico" + "<fila><error>");
	        	}else
	        	{
	        		if (_renta_total_neta_paso < 0 )
	        		{
	        			errores.escribir_error("<fila><error>" + "Registro tipo 3 2" + ";" + "Renta total Neta" + ";" + "valor debe ser mayor a cero" + "<fila><error>");
	        		}else
	        		{
	        			_renta_total_neta_pagada = _renta_total_neta_paso.ToString().PadLeft(15,'0');
	        		}
	        	}
	        }
	    }
    	private string _renta_total_neta_pagada;
    	
    	public string imp_unico_retenido
	    {
	        get { return _imp_unico_retenido; }
	        set
	        {
	        	int _imp_unico_retenido_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                errores.escribir_error("<fila><error>" + "Registro tipo 3 2" + ";" + "Impuesto Unico Retenido" + ";" + "valor no puede ser vacio" + "<fila><error>");
	        	if (!int.TryParse(value, out _imp_unico_retenido_paso))
	        	{
	            	errores.escribir_error("<fila><error>" + "Registro tipo 3 2" + ";" + "Impuesto Unico Retenido" + ";" + "valor debe ser numérico" + "<fila><error>");
	        	}else
	        	{
	        		
	        		_imp_unico_retenido = _imp_unico_retenido_paso.ToString().PadLeft(15,'0');
	        		
	        	}
	        }
	    }
    	private string _imp_unico_retenido;
    	
    	
    	public string mayor_retencion_solicitada
	    {
	        get { return _mayor_retencion_solicitada; }
	        set
	        {
	        	int _mayor_retencion_solicitada_paso = 0;
	        	
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                errores.escribir_error("<fila><error>" + "Registro tipo 3 2" + ";" + "Mayor retención Solicitada" + ";" + "valor no puede ser vacio" + "<fila><error>");
	        	if (!int.TryParse(value, out _mayor_retencion_solicitada_paso))
	        	{
	            	errores.escribir_error("<fila><error>" + "Registro tipo 3 2" + ";" + "Mayor retención Solicitad" + ";" + "valor debe ser numérico" + "<fila><error>");
	        	}else
	        	{
	        		
	        		_mayor_retencion_solicitada = _mayor_retencion_solicitada_paso.ToString().PadLeft(15,'0');
	        		
	        	}
	        }
	    }
    	private string _mayor_retencion_solicitada;
    	
    	
    	public string renta_total_no_grabada
	    {
	        get { return _renta_total_no_grabada; }
	        set
	        {
	        	int _renta_total_no_grabada_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                errores.escribir_error("<fila><error>" + "Registro tipo 3 2" + ";" + "Renta total no grabada" + ";" + "valor no puede ser vacio" + "<fila><error>");
	        	if (!int.TryParse(value, out _renta_total_no_grabada_paso))
	            	errores.escribir_error("<fila><error>" + "Registro tipo 3 2" + ";" + "Renta total no grabada" + ";" + "valor debe ser numérico" + "<fila><error>");
	        	_renta_total_no_grabada = _renta_total_no_grabada_paso.ToString().PadLeft(15,'0');
	        }
	    }
    	private string _renta_total_no_grabada;
    	
    	public string renta_total_exenta
	    {
	        get { return _renta_total_exenta; }
	        set
	        {
	        	int _renta_total_exenta_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                errores.escribir_error("<fila><error>" + "Registro tipo 3 2" + ";" + "Renta total Exenta" + ";" + "valor no puede ser vacio" + "<fila><error>");
	        	if (!int.TryParse(value, out _renta_total_exenta_paso))
	            	errores.escribir_error("<fila><error>" + "Registro tipo 3 2" + ";" + "Renta total Exenta" + ";" + "valor debe ser numérico" + "<fila><error>");
	        	_renta_total_exenta = _renta_total_exenta_paso.ToString().PadLeft(15,'0');
	        }
	    }
    	private string _renta_total_exenta;
    	
    	
    	public string rebaja_zona_extrema
	    {
	        get { return _rebaja_zona_extrema; }
	        set
	        {
	        	int _rebaja_zona_extrema_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                errores.escribir_error("<fila><error>" + "Registro tipo 3 2" + ";" + "Rebaja zona extrema" + ";" + "valor no puede ser vacio" + "<fila><error>");
	        	if (!int.TryParse(value, out _rebaja_zona_extrema_paso))
	            	errores.escribir_error("<fila><error>" + "Registro tipo 3 2" + ";" + "Rebaja zona extrema" + ";" + "valor debe ser numérico" + "<fila><error>");
	        	_rebaja_zona_extrema = _rebaja_zona_extrema_paso.ToString().PadLeft(15,'0');
	        }
	    }
    	private string _rebaja_zona_extrema;
    	
    	public string prestamos_tasa_0_2020_2021
	    {
	        get { return _prestamos_tasa_0_2020_2021; }
	        set
	        {
	        	int _prestamos_tasa_0_2020_2021_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                errores.escribir_error("<fila><error>" + "Registro tipo 3 2" + ";" + "Prestamos tasa 0 2020 2021" + ";" + "valor no puede ser vacio" + "<fila><error>");
	        	if (!int.TryParse(value, out _prestamos_tasa_0_2020_2021_paso))
	            	errores.escribir_error("<fila><error>" + "Registro tipo 3 2" + ";" + "Prestamos tasa 0 2020 2021" + ";" + "valor debe ser numérico" + "<fila><error>");
	        	_prestamos_tasa_0_2020_2021 = _prestamos_tasa_0_2020_2021_paso.ToString().PadLeft(18,'0');
	        }
	    }
    	private string _prestamos_tasa_0_2020_2021;
    	
    	public string total_casos_importados
	    {
	        get { return _total_casos_importados; }
	        set
	        {
	        	int _total_casos_importados_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                errores.escribir_error("<fila><error>" + "Registro tipo 3 2" + ";" + "Total casos importados" + ";" + "valor no puede ser vacio" + "<fila><error>");
	        	if (!int.TryParse(value, out _total_casos_importados_paso))
	            	errores.escribir_error("<fila><error>" + "Registro tipo 3 2" + ";" + "Total casos importados" + ";" + "valor debe ser numérico" + "<fila><error>");
	        	if (this.tipo_declaracion == "O")
	        	{
	        		if (_total_casos_importados_paso < 1)
	        		{
	        			errores.escribir_error("<fila><error>" + "Registro tipo 3 2" + ";" + "Total casos importados" + ";" + "Si tipo declaración es Original debe ser mayor que 0" + "<fila><error>");
	        		}
	        		_total_casos_importados = _total_casos_importados_paso.ToString().PadLeft(15,'0');
	        
	        	}else
	        	{
	        		_total_casos_importados = _total_casos_importados_paso.ToString().PadLeft(15,'0');
	        	}
	        }
	    }
    	private string _total_casos_importados;
    	
    	
    	public string dia_presentacion
	    {
	        get { return _dia_presentacion; }
	        set
	        {
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                errores.escribir_error("<fila><error>" + "Registro tipo 3 2" + ";" + "Dia Presentación" + ";" + "valor no puede ser vacio" + "<fila><error>");
//	        	if (!int.TryParse(s, out _dia))
//	            	throw new ArgumentException("valor debe ser un numero");
	        	_dia_presentacion = value;
	        }
	    }
    	private string _dia_presentacion;
    	
    	public string mes_presentacion
	    {
	        get { return _mes_presentacion; }
	        set
	        {
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                errores.escribir_error("<fila><error>" + "Registro tipo 3 2" + ";" + "Mes Presentación" + ";" + "valor no puede ser vacio" + "<fila><error>");
//	        	if (!int.TryParse(s, out _mes))
//	            	throw new ArgumentException("valor debe ser un numero");
	        	_mes_presentacion = value;
	        }
	    }
    	private string _mes_presentacion;
    	
    	public string ano_presentacion
	    {
	        get { return _ano_presentacion; }
	        set
	        {
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                errores.escribir_error("<fila><error>" + "Registro tipo 3 2" + ";" + "Año Presentación" + ";" + "valor no puede ser vacio" + "<fila><error>");
//	        	if (!int.TryParse(s, out _ano))
//	            	throw new ArgumentException("valor debe ser un numero");
	        	_ano_presentacion = value;
	        }
	    }
    	private string _ano_presentacion;
    	
    	public string numero_rut_representante
	    {
	        get { return _numero_rut_representante; }
	        set
	        {
	        	int _numero_rut_representante_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                errores.escribir_error("<fila><error>" + "Registro tipo 3 2" + ";" + "Rut representante" + ";" + "valor no puede ser vacio" + "<fila><error>");
	        	if (!int.TryParse(value, out _numero_rut_representante_paso))
	            	errores.escribir_error("<fila><error>" + "Registro tipo 3 2" + ";" + "Rut representante" + ";" + "valor debe ser numérico" + "<fila><error>");
	        	_numero_rut_representante = _numero_rut_representante_paso.ToString().PadLeft(8, '0');
	        }
	    }
    	private string _numero_rut_representante;
    	
    	public string digito_verificador
	    {
	        get { return _digito_verificador; }
	        set
	        {
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                errores.escribir_error("<fila><error>" + "Registro tipo 3 2" + ";" + "Digito Verificador" + ";" + "valor no puede ser vacio" + "<fila><error>");
	        	if (value.Length !=1)
	        		errores.escribir_error("<fila><error>" + "Registro tipo 3 2" + ";" + "Digito Verificador" + ";" + "valor debe ser un caracter" + "<fila><error>");
	        	if (value != validaciones.Digito (int.Parse( numero_rut_representante)))
	        		errores.escribir_error("<fila><error>" + "Registro tipo 3 2" + ";" + "Digito Verificador" + ";" + "Rut invalido, error en  Digito Verrificador" + "<fila><error>");
	        	_digito_verificador = value;
	        }
	    }
    	private string _digito_verificador;
    	
    	
    	
    	
    	public string retorna_registro_tipo_3_2(int anodj)
    	{
    		if (anodj == 2023)
    		{
    		string salida = this.tipo_registro + this.determina_orden_preced + this.renta_total_neta_pagada + this.imp_unico_retenido + this.mayor_retencion_solicitada
    						+ this.renta_total_no_grabada + this.renta_total_exenta + this.rebaja_zona_extrema + this.prestamos_tasa_0_2020_2021 + this.total_casos_importados 
							+ this.dia_presentacion + this.mes_presentacion + this.ano_presentacion + this.numero_rut_representante + this.digito_verificador ;
    			return salida + "".PadRight(206 );
    		}else
    		{
    			errores.escribir_error("<fila><error>" + "DDJJ 1887" + ";" + "retorna_registro_tipo_3_2" + ";" + "año no soportado para esta version" + "<fila><error>");
    			return "";
    		}
    	}
    	
	}
}

