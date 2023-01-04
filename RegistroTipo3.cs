﻿/*
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
		private string _blancos = "".PadLeft(206, '0');
		
		public registrotipo3_1()
		{
		}
		
		public  errores errores  {get; set;}
		
		
		public string tipo_registro
	    {
	        get { return _tipo_registro; }
	        set
	        {
	        	int _tipo_registro_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                throw new ArgumentException("Valor no puede ser vacio");
	        	if (!int.TryParse(value, out _tipo_registro_paso))
	            	throw new ArgumentException("valor debe ser un numero");
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
	                throw new ArgumentException("Valor no puede ser vacio");
	        	if (!int.TryParse(value, out _determina_orden_preced_paso))
	            	throw new ArgumentException("valor debe ser un numero");
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
	                throw new ArgumentException("Valor no puede ser vacio");
	        	if (!int.TryParse(value, out _numero_formulario_paso))
	            	throw new ArgumentException("valor debe ser un numero");
	        	_numero_formulario = _numero_formulario_paso.ToString();
	        }
	    }
    	private string _numero_formulario;
    	
    	public string codigo_presentacion
	    {
	        get { return _codigo_presentacion; }
	        set
	        {
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                throw new ArgumentException("Valor no puede ser vacio");
//	        	if (!int.TryParse(s, out _folio))
//	            	throw new ArgumentException("valor debe ser un numero");
	        	_codigo_presentacion = value;
	        }
	    }
    	private string _codigo_presentacion;
    	
    	public string folio
	    {
	        get { return _folio; }
	        set
	        {
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                throw new ArgumentException("Valor no puede ser vacio");
//	        	if (!int.TryParse(s, out _folio))
//	            	throw new ArgumentException("valor debe ser un numero");
	        	_folio = value;
	        }
	    }
    	private string _folio;
    	
    	
		public string numero_rut
	    {
	        get { return _numero_rut; }
	        set
	        {
	        	int _numero_rut_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                throw new ArgumentException("Valor no puede ser vacio");
	        	if (!int.TryParse(value, out _numero_rut_paso))
	            	throw new ArgumentException("valor debe ser un numero");
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
	                throw new ArgumentException("Valor no puede ser vacio");
	        	_digito_verificador = value;
	        }
	    }
    	private string _digito_verificador;
    	
    	public string renta_total_neta_pagada
	    {
	        get { return _renta_total_neta_pagada; }
	        set
	        {
	        	int _renta_total_neta_pagada_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                throw new ArgumentException("Valor no puede ser vacio");
	        	if (!int.TryParse(value, out _renta_total_neta_pagada_paso))
	            	throw new ArgumentException("valor debe ser un numero");
	        	_renta_total_neta_pagada = _renta_total_neta_pagada_paso.ToString();
	        }
	    }
    	private string _renta_total_neta_pagada;
    	
    	
    	//IMPUESTO UNICO  DE SEGUNDA CATEGORÍA  RETENIDO POR RENTA TOTAL NETA PAGADA DURANTE EL AÑO
    	
    	public string imp_uni_ret_seg_cat
	    {
	        get { return _imp_uni_ret_seg_cat; }
	        set
	        {
	        	int _imp_uni_ret_seg_cat_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                throw new ArgumentException("Valor no puede ser vacio");
	        	if (!int.TryParse(value, out _imp_uni_ret_seg_cat_paso))
	            	throw new ArgumentException("valor debe ser un numero");
	        	_imp_uni_ret_seg_cat = _imp_uni_ret_seg_cat_paso.ToString();
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
	                throw new ArgumentException("Valor no puede ser vacio");
	        	if (!int.TryParse(value, out _imp_uni_ret_seg_cat_comp_ene_abr_paso))
	            	throw new ArgumentException("valor debe ser un numero");
	        	_imp_uni_ret_seg_cat_comp_ene_abr = _imp_uni_ret_seg_cat_comp_ene_abr_paso.ToString();
	        }
	    }
    	private string _imp_uni_ret_seg_cat_comp_ene_abr;
    	
    	public string renta_total_no_pagada
	    {
	        get { return _renta_total_no_pagada; }
	        set
	        {
	        	int _renta_total_no_pagada_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                throw new ArgumentException("Valor no puede ser vacio");
	        	if (!int.TryParse(value, out _renta_total_no_pagada_paso))
	            	throw new ArgumentException("valor debe ser un numero");
	        	_renta_total_no_pagada = _renta_total_no_pagada_paso.ToString();
	        }
	    }
    	private string _renta_total_no_pagada;
    	
    	public string renta_total_exenta
	    {
	        get { return _renta_total_exenta; }
	        set
	        {
	        	int _renta_total_exenta_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                throw new ArgumentException("Valor no puede ser vacio");
	        	if (!int.TryParse(value, out _renta_total_exenta_paso))
	            	throw new ArgumentException("valor debe ser un numero");
	        	_renta_total_exenta = _renta_total_exenta_paso.ToString();
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
	                throw new ArgumentException("Valor no puede ser vacio");
	        	if (!int.TryParse(value, out _rebaja_zona_extrema_paso))
	            	throw new ArgumentException("valor debe ser un numero");
	        	_rebaja_zona_extrema = _rebaja_zona_extrema_paso.ToString();
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
	                throw new ArgumentException("Valor no puede ser vacio");
	        	if (!int.TryParse(value, out _leyes_sociales_paso))
	            	throw new ArgumentException("valor debe ser un numero");
	        	_leyes_sociales = _leyes_sociales_paso.ToString();
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
	                throw new ArgumentException("Valor no puede ser vacio");
	        	if (!int.TryParse(value, out _prestamos_tasa_0_paso))
	            	throw new ArgumentException("valor debe ser un numero");
	        	_prestamos_tasa_0 = _prestamos_tasa_0_paso.ToString();
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
	                throw new ArgumentException("Valor no puede ser vacio");
	        	if (!int.TryParse(value, out _total_remuneracion_imp_actual_paso))
	            	throw new ArgumentException("valor debe ser un numero");
	        	_total_remuneracion_imp_actual = _total_remuneracion_imp_actual_paso.ToString();
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
	                throw new ArgumentException("Valor no puede ser vacio");
	        	if (!int.TryParse(value, out _monto_ing_men_s_act_ene_paso))
	            	throw new ArgumentException("valor debe ser un numero");
	        	_monto_ing_men_s_act_ene = _monto_ing_men_s_act_ene_paso.ToString();
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
	                throw new ArgumentException("Valor no puede ser vacio");
	        	if (!int.TryParse(value, out _monto_ing_men_s_act_feb_paso))
	            	throw new ArgumentException("valor debe ser un numero");
	        	_monto_ing_men_s_act_feb = _monto_ing_men_s_act_feb_paso.ToString();
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
	                throw new ArgumentException("Valor no puede ser vacio");
	        	if (!int.TryParse(value, out _monto_ing_men_s_act_mar_paso))
	            	throw new ArgumentException("valor debe ser un numero");
	        	_monto_ing_men_s_act_mar = _monto_ing_men_s_act_mar_paso.ToString();
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
	                throw new ArgumentException("Valor no puede ser vacio");
	        	if (!int.TryParse(value, out _monto_ing_men_s_act_abr_paso))
	            	throw new ArgumentException("valor debe ser un numero");
	        	_monto_ing_men_s_act_abr = _monto_ing_men_s_act_abr_paso.ToString();
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
	                throw new ArgumentException("Valor no puede ser vacio");
	        	if (!int.TryParse(value, out _monto_ing_men_s_act_may_paso))
	            	throw new ArgumentException("valor debe ser un numero");
	        	_monto_ing_men_s_act_may = _monto_ing_men_s_act_may_paso.ToString();
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
	                throw new ArgumentException("Valor no puede ser vacio");
	        	if (!int.TryParse(value, out _monto_ing_men_s_act_jun_paso))
	            	throw new ArgumentException("valor debe ser un numero");
	        	_monto_ing_men_s_act_jun = _monto_ing_men_s_act_jun_paso.ToString();
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
	                throw new ArgumentException("Valor no puede ser vacio");
	        	if (!int.TryParse(value, out _monto_ing_men_s_act_jul_paso))
	            	throw new ArgumentException("valor debe ser un numero");
	        	_monto_ing_men_s_act_jul = _monto_ing_men_s_act_jul_paso.ToString();
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
	                throw new ArgumentException("Valor no puede ser vacio");
	        	if (!int.TryParse(value, out _monto_ing_men_s_act_ago_paso))
	            	throw new ArgumentException("valor debe ser un numero");
	        	_monto_ing_men_s_act_ago = _monto_ing_men_s_act_ago_paso.ToString();
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
	                throw new ArgumentException("Valor no puede ser vacio");
	        	if (!int.TryParse(value, out _monto_ing_men_s_act_sep_paso))
	            	throw new ArgumentException("valor debe ser un numero");
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
	                throw new ArgumentException("Valor no puede ser vacio");
	        	if (!int.TryParse(value, out _monto_ing_men_s_act_oct_paso))
	            	throw new ArgumentException("valor debe ser un numero");
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
	                throw new ArgumentException("Valor no puede ser vacio");
	        	if (!int.TryParse(value, out _monto_ing_men_s_act_nov_paso))
	            	throw new ArgumentException("valor debe ser un numero");
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
	                throw new ArgumentException("Valor no puede ser vacio");
	        	if (!int.TryParse(value, out _monto_ing_men_s_act_dic_paso))
	            	throw new ArgumentException("valor debe ser un numero");
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
							+ this.renta_total_no_pagada + this.renta_total_exenta + this.rebaja_zona_extrema + this.leyes_sociales + this.prestamos_tasa_0 + this.total_remuneracion_imp_actual
							+ this.monto_ing_men_s_act_ene + this.monto_ing_men_s_act_feb +     this.monto_ing_men_s_act_mar + this.monto_ing_men_s_act_abr + this._monto_ing_men_s_act_may 
    						+ this.monto_ing_men_s_act_jun + this.monto_ing_men_s_act_jul	+ this.monto_ing_men_s_act_ago + this._monto_ing_men_s_act_sep + this.monto_ing_men_s_act_oct		
    						+ this.monto_ing_men_s_act_nov + this.monto_ing_men_s_act_dic	;
    			return salida + "".PadRight(341 - salida.Length);
    		}else
    		{
    			errores.escribir_error("<error>" + "DDJJ 1887" + ";" + "retorna_registro_tipo_3_1" + ";" + "año no soportado para esta version" + "</error>");
    			return "";
    		}
    	}
    	
	}


	public class registrotipo3_2
	{
		public registrotipo3_2()
		{
		}
		
		
		public  errores errores  {get; set;}
		
		public string tipo_registro
	    {
	        get { return _tipo_registro; }
	        set
	        {
	        	int _tipo_registro_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                throw new ArgumentException("Valor no puede ser vacio");
	        	if (!int.TryParse(value, out _tipo_registro_paso))
	            	throw new ArgumentException("valor debe ser un numero");
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
	                throw new ArgumentException("Valor no puede ser vacio");
	        	if (!int.TryParse(value, out _determina_orden_preced_paso))
	            	throw new ArgumentException("valor debe ser un numero");
	        	_determina_orden_preced = _determina_orden_preced_paso.ToString();
	        }
	    }
    	private string _determina_orden_preced;
    	
    	public string renta_total_neta_pagada
	    {
	        get { return _renta_total_neta_pagada; }
	        set
	        {
	        	int _renta_total_neta_pagada_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                throw new ArgumentException("Valor no puede ser vacio");
	        	if (!int.TryParse(value, out _renta_total_neta_pagada_paso))
	            	throw new ArgumentException("valor debe ser un numero");
	        	_renta_total_neta_pagada = _renta_total_neta_pagada_paso.ToString();
	        }
	    }
    	private string _renta_total_neta_pagada;
    	
    	public string imp_unico_retenido
	    {
	        get { return _renta_total_neta_pagada; }
	        set
	        {
	        	int _imp_unico_retenido_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                throw new ArgumentException("Valor no puede ser vacio");
	        	if (!int.TryParse(value, out _imp_unico_retenido_paso))
	            	throw new ArgumentException("valor debe ser un numero");
	        	_imp_unico_retenido = _imp_unico_retenido_paso.ToString();
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
	                throw new ArgumentException("Valor no puede ser vacio");
	        	if (!int.TryParse(value, out _mayor_retencion_solicitada_paso))
	            	throw new ArgumentException("valor debe ser un numero");
	        	_mayor_retencion_solicitada = _mayor_retencion_solicitada_paso.ToString();
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
	                throw new ArgumentException("Valor no puede ser vacio");
	        	if (!int.TryParse(value, out _renta_total_no_grabada_paso))
	            	throw new ArgumentException("valor debe ser un numero");
	        	_renta_total_no_grabada = _renta_total_no_grabada_paso.ToString();
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
	                throw new ArgumentException("Valor no puede ser vacio");
	        	if (!int.TryParse(value, out _renta_total_exenta_paso))
	            	throw new ArgumentException("valor debe ser un numero");
	        	_renta_total_exenta = _renta_total_exenta_paso.ToString();
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
	                throw new ArgumentException("Valor no puede ser vacio");
	        	if (!int.TryParse(value, out _rebaja_zona_extrema_paso))
	            	throw new ArgumentException("valor debe ser un numero");
	        	_rebaja_zona_extrema = _rebaja_zona_extrema_paso.ToString();
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
	                throw new ArgumentException("Valor no puede ser vacio");
	        	if (!int.TryParse(value, out _prestamos_tasa_0_2020_2021_paso))
	            	throw new ArgumentException("valor debe ser un numero");
	        	_prestamos_tasa_0_2020_2021 = _prestamos_tasa_0_2020_2021_paso.ToString();
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
	                throw new ArgumentException("Valor no puede ser vacio");
	        	if (!int.TryParse(value, out _total_casos_importados_paso))
	            	throw new ArgumentException("valor debe ser un numero");
	        	_total_casos_importados = _total_casos_importados_paso.ToString();
	        }
	    }
    	private string _total_casos_importados;
    	
    	
    	public string dia_presentacion
	    {
	        get { return _dia_presentacion; }
	        set
	        {
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                throw new ArgumentException("Valor no puede ser vacio");
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
	                throw new ArgumentException("Valor no puede ser vacio");
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
	                throw new ArgumentException("Valor no puede ser vacio");
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
	                throw new ArgumentException("Valor no puede ser vacio");
	        	if (!int.TryParse(value, out _numero_rut_representante_paso))
	            	throw new ArgumentException("valor debe ser un numero");
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
	                throw new ArgumentException("Valor no puede ser vacio");
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
    			return salida + "".PadRight(206 - salida.Length);
    		}else
    		{
    			errores.escribir_error("<error>" + "DDJJ 1887" + ";" + "retorna_registro_tipo_3_2" + ";" + "año no soportado para esta version" + "</error>");
    			return "";
    		}
    	}
    	
	}
}
