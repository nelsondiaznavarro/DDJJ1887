﻿/*
 * Created by SharpDevelop.
 * User: rjc
 * Date: 28-12-2022
 * Time: 12:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace DDJJ1887
{
	/// <summary>
	/// Description of RegistroTipo2.
	/// </summary>
	public class registrotipo2
	{
		private string _blancos = "".PadLeft(59, '0');
		
		public registrotipo2()
		{
		}
		
		public  errores errores  {get; set;}
		
		public string tipo_registro
	    {
	        get { return _tipo_registro; }
	        set
	        {
	        	int _tipo_registro_paso = 0;
	        	if (string.IsNullOrEmpty(value.ToString()))
	                errores.escribir_error("<error>" + "Registro tipo 2" + ";" + "Tipo Registro" + ";" + "valor no puede ser vacio" + "</error>");
	        	if (value.Length != 1)
	        		errores.escribir_error("<error>" + "Registro tipo 2" + ";" + "Tipo Registro" + ";" + "valor debe ser un numero de un digito" + "</error>");
	        	if (!int.TryParse(value, out _tipo_registro_paso))
	        	{
	        		errores.escribir_error("<error>" + "Registro tipo 2" + ";" + "Tipo Registro" + ";" + "valor debe ser un numero" + "</error>");
	        	}
	        	if ( _tipo_registro_paso != 2)
	        	{
	        		errores.escribir_error("<error>" + "Registro tipo 2" + ";" + "Tipo Registro" + ";" + "valor debe ser el numero 2" + "</error>");
	        	}
	        	_tipo_registro = _tipo_registro_paso.ToString();
	        }
	    }
    	private string _tipo_registro;
    	
    	public string numero_formulario
	    {
	        get { return _numero_formulario; }
	        set
	        {
	        	int _numero_formulario_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	               errores.escribir_error("<error>" + "Registro tipo 2" + ";" + "Número de Formulario" + ";" + "valor no puede ser vacio" + "</error>");
	        	if (!int.TryParse(value, out _numero_formulario_paso))
	            	errores.escribir_error("<error>" + "Registro tipo 2" + ";" + "Número de Formulario" + ";" + "valor debe ser numérico" + "</error>");
	        	if ( _numero_formulario_paso != 1887)
	        		errores.escribir_error("<error>" + "Registro tipo 2" + ";" + "Número de Formulario" + ";" + "valor debe ser el formulario 1887" + "</error>");
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
	                errores.escribir_error("<error>" + "Registro tipo 2" + ";" + "Código Presentación" + ";" + "valor no puede ser vacio" + "</error>");
	        	if (value != "I")
	                errores.escribir_error("<error>" + "Registro tipo 2" + ";" + "Código Presentación" + ";" + "valor debe ser la letra I" + "</error>");
	        	_codigo_presentacion = value;
	        }
	    }
    	private string _codigo_presentacion;
    	
    	public string n_de_folio
	    {
	        get { return _n_de_folio; }
	        set
	        {
	        	int _folio_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                errores.escribir_error("<error>" + "Registro tipo 2" + ";" + "Folio" + ";" + "valor no puede ser vacio" + "</error>");
	        	if (!int.TryParse(value, out _folio_paso) )
	            	errores.escribir_error("<error>" + "Registro tipo 2" + ";" + "Folio" + ";" + "valor debe ser numerico" + "</error>");
	        	if (_folio_paso < 1 )
	        		errores.escribir_error("<error>" + "Registro tipo 2" + ";" + "Folio" + ";" + "valor debe ser numerico mayor a cero" + "</error>");
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
	                errores.escribir_error("<error>" + "Registro tipo 2" + ";" + "Número de RUT" + ";" + "valor no puede ser vacio" + "</error>");
	        	if (!int.TryParse(value, out _numero_rut_paso))
	            	errores.escribir_error("<error>" + "Registro tipo 2" + ";" + "Número de RUT" + ";" + "valor debe ser un numero mayor a cero" + "</error>");
	        	_numero_rut = _numero_rut_paso.ToString().PadLeft(8, '0');
	        }
	    }
    	private string _numero_rut;
    	
    	public string digito_verificador
	    {
	        get { return _digito_verificador; }
	        set
	        {
	        	if (string.IsNullOrEmpty(value.ToString()))
	                errores.escribir_error("<error>" + "Registro tipo 2" + ";" + "Digito Verificador" + ";" + "valor no puede ser vacio" + "</error>");
	        	if (value.Length !=1)
	        		errores.escribir_error("<error>" + "Registro tipo 2" + ";" + "Digito Verificador" + ";" + "valor debe ser un caracter" + "</error>");
	        	if (value != validaciones.Digito (int.Parse( numero_rut)))
	        		errores.escribir_error("<error>" + "Registro tipo 2" + ";" + "Digito Verificador" + ";" + "Rut invalido, error en  Digito Verrificador" + "</error>");
	        	_digito_verificador = value;
	        }
	    }
    	private string _digito_verificador;
    	
    	public string numero_rut_receptor
	    {
	        get { return _numero_rut_receptor; }
	        set
	        {
	        	int _numero_rut_receptor_paso = 0;
	        	if (string.IsNullOrEmpty(value.ToString()))
	                errores.escribir_error("<error>" + "Registro tipo 2" + ";" + "Número de RUT" + ";" + "valor no puede ser vacio" + "</error>");
	        	if (!int.TryParse(value, out _numero_rut_receptor_paso))
	            	errores.escribir_error("<error>" + "Registro tipo 2" + ";" + "Número de RUT" + ";" + "valor debe ser un numero mayor a cero" + "</error>");
	        	_numero_rut_receptor = _numero_rut_receptor_paso.ToString().PadLeft(8, '0');
	        }
	    }
    	private string _numero_rut_receptor;
    	
    	public string digito_verificador_receptor
	    {
	        get { return _digito_verificador_receptor; }
	        set
	        {
	        	if (string.IsNullOrEmpty(value.ToString()))
	                errores.escribir_error("<error>" + "Registro tipo 2" + ";" + "Digito Verificador receptor" + ";" + "valor no puede ser vacio" + "</error>");
	        	if (value.Length !=1)
	        		errores.escribir_error("<error>" + "Registro tipo 2" + ";" + "Digito Verificador receptor" + ";" + "valor debe ser un caracter" + "</error>");
	        	if (value != validaciones.Digito (int.Parse( numero_rut)))
	        		errores.escribir_error("<error>" + "Registro tipo 2" + ";" + "Digito Verificador receptor" + ";" + "Rut invalido, error en  Digito Verrificador" + "</error>");
	        	_digito_verificador_receptor = value;
	        }
	    }
    	private string _digito_verificador_receptor;

    	public string renta_total_neta
	    {
	        get { return _renta_total_neta; }
	        set
	        {
	        	int _renta_total_neta_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                errores.escribir_error("<error>" + "Registro tipo 2" + ";" + "Renta total Neta" + ";" + "valor no puede ser vacio" + "</error>");
	        	if (!int.TryParse(value, out _renta_total_neta_paso))
	        	{
	        		errores.escribir_error("<error>" + "Registro tipo 2" + ";" + "Renta total Neta" + ";" + "valor debe ser numérico" + "</error>");
	        	}else
	        	{
	        		if (_renta_total_neta_paso < 1 )
	        		{
	        			errores.escribir_error("<error>" + "Registro tipo 2" + ";" + "Renta total Neta" + ";" + "valor debe ser mayor a cero" + "</error>");
	        		}else
	        		{
	        			
	        		}
	        	}
	            	
	        	_renta_total_neta = _renta_total_neta_paso.ToString().PadLeft(12,'0');
	        }
	    }
    	private string _renta_total_neta;
    	
    	public string imp_uni_sgda_cat_ret
	    {
	        get { return _imp_uni_sgda_cat_ret; }
	        set
	        {
	        	int _imp_uni_sgda_cat_ret_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                errores.escribir_error("<error>" + "Registro tipo 2" + ";" + "Renta total Neta" + ";" + "valor no puede ser vacio" + "</error>");
	        	if (!int.TryParse(value, out _imp_uni_sgda_cat_ret_paso))
	        	{
	        		errores.escribir_error("<error>" + "Registro tipo 2" + ";" + "Renta total Neta" + ";" + "valor debe ser numérico" + "</error>");
	        	}else
	        	{
	        		if (_imp_uni_sgda_cat_ret_paso < 1 )
	        		{
	        			errores.escribir_error("<error>" + "Registro tipo 2" + ";" + "Renta total Neta" + ";" + "valor debe ser mayor a cero" + "</error>");
	        		}else
	        		{
	        			
	        		}
	        	}
	            	
	        	_imp_uni_sgda_cat_ret = _imp_uni_sgda_cat_ret_paso.ToString().PadLeft(12,'0');
	        }
	    }
    	private string _imp_uni_sgda_cat_ret;
    	
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
    	
    	public string rebaja_zona_exenta
	    {
	        get { return _rebaja_zona_exenta; }
	        set
	        {
	        	int _rebaja_zona_exenta_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                throw new ArgumentException("Valor no puede ser vacio");
	        	if (!int.TryParse(value, out _rebaja_zona_exenta_paso))
	            	throw new ArgumentException("valor debe ser un numero");
	        	_rebaja_zona_exenta = _rebaja_zona_exenta_paso.ToString();
	        }
	    }
    	private string _rebaja_zona_exenta;
    	//Prestamos
   	  	public string prestamos_tasa_0_2020_2021
	    {
	        get { return _prestamos_tasa_0_2020_2021; }
	        set
	        {
	        	if (string.IsNullOrEmpty(value.ToString()))
	                throw new ArgumentException("Valor no puede ser vacio");
	        	_prestamos_tasa_0_2020_2021 = value;
	        }
	    }
    	private string _prestamos_tasa_0_2020_2021;
    	
    	public string prestamos_enero
	    {
	        get { return _prestamos_enero; }
	        set
	        {
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                throw new ArgumentException("Valor no puede ser vacio");
	        	_prestamos_enero = value;
	        }
	    }
    	private string _prestamos_enero;
    	
    	public string prestamos_febrero
	    {
	        get { return _prestamos_febrero; }
	        set
	        {
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                throw new ArgumentException("Valor no puede ser vacio");
	        	_prestamos_febrero = value;
	        }
	    }
    	private string _prestamos_febrero;
    	
    	public string prestamos_marzo
	    {
	        get { return _prestamos_marzo; }
	        set
	        {
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                throw new ArgumentException("Valor no puede ser vacio");
	        	_prestamos_marzo = value;
	        }
	    }
    	private string _prestamos_marzo;
    	
    	public string prestamos_abril
	    {
	        get { return _prestamos_abril; }
	        set
	        {
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                throw new ArgumentException("Valor no puede ser vacio");
	        	_prestamos_abril = value;
	        }
	    }
    	private string _prestamos_abril;
    	
    	public string prestamos_mayo
	    {
	        get { return _prestamos_mayo; }
	        set
	        {
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                throw new ArgumentException("Valor no puede ser vacio");
	        	_prestamos_mayo = value;
	        }
	    }
    	private string _prestamos_mayo;
    	
    	public string prestamos_junio
	    {
	        get { return _prestamos_junio; }
	        set
	        {
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                throw new ArgumentException("Valor no puede ser vacio");
	        	_prestamos_junio = value;
	        }
	    }
    	private string _prestamos_junio;
    	
    	public string prestamos_julio
	    {
	        get { return _prestamos_julio; }
	        set
	        {
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                throw new ArgumentException("Valor no puede ser vacio");
	        	_prestamos_julio = value;
	        }
	    }
    	private string _prestamos_julio;
    	
    	public string prestamos_agosto
	    {
	        get { return _prestamos_agosto; }
	        set
	        {
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                throw new ArgumentException("Valor no puede ser vacio");
	        	_prestamos_agosto = value;
	        }
	    }
    	private string _prestamos_agosto;
    	
    	public string prestamos_septiembre
	    {
	        get { return _prestamos_septiembre; }
	        set
	        {
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                throw new ArgumentException("Valor no puede ser vacio");
	        	_prestamos_septiembre = value;
	        }
	    }
    	private string _prestamos_septiembre;
    	
    	public string prestamos_octubre
	    {
	        get { return _prestamos_octubre; }
	        set
	        {
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                throw new ArgumentException("Valor no puede ser vacio");
	        	_prestamos_octubre = value;
	        }
	    }
    	private string _prestamos_octubre;
    	
    	public string prestamos_noviembre
	    {
	        get { return _prestamos_noviembre; }
	        set
	        {
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                throw new ArgumentException("Valor no puede ser vacio");
	        	_prestamos_noviembre = value;
	        }
	    }
    	private string _prestamos_noviembre;
    	
    	public string prestamos_diciembre
	    {
	        get { return _prestamos_diciembre; }
	        set
	        {
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                throw new ArgumentException("Valor no puede ser vacio");
	        	_prestamos_diciembre = value;
	        }
	    }
    	private string _prestamos_diciembre;
    	//Prestamos
    	public string numero_certificado
	    {
	        get { return _numero_certificado; }
	        set
	        {
	        	int _numero_certificado_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                throw new ArgumentException("Valor no puede ser vacio");
	        	if (!int.TryParse(value, out _numero_certificado_paso))
	            	throw new ArgumentException("valor debe ser un numero");
	        	_numero_certificado = _numero_certificado_paso.ToString();
	        }
	    }
    	private string _numero_certificado;
     	//Monto ingreso mensual
    	public string monto_ingreso_enero
	    {
	        get { return _monto_ingreso_enero; }
	        set
	        {
	        	int _monto_ingreso_enero_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                throw new ArgumentException("Valor no puede ser vacio");
	        	if (!int.TryParse(value, out _monto_ingreso_enero_paso))
	            	throw new ArgumentException("valor debe ser un numero");
	        	_monto_ingreso_enero = _monto_ingreso_enero_paso.ToString();
	        }
	    }
    	private string _monto_ingreso_enero;
    	
    	public string monto_ingreso_febrero
	    {
	        get { return _monto_ingreso_febrero; }
	        set
	        {
	        	int _monto_ingreso_febrero_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                throw new ArgumentException("Valor no puede ser vacio");
	        	if (!int.TryParse(value, out _monto_ingreso_febrero_paso))
	            	throw new ArgumentException("valor debe ser un numero");
	        	_monto_ingreso_febrero = _monto_ingreso_febrero_paso.ToString();
	        }
	    }
    	private string _monto_ingreso_febrero;
    	
    	public string monto_ingreso_marzo
	    {
	        get { return _monto_ingreso_marzo; }
	        set
	        {
	        	int _monto_ingreso_marzo_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                throw new ArgumentException("Valor no puede ser vacio");
	        	if (!int.TryParse(value, out _monto_ingreso_marzo_paso))
	            	throw new ArgumentException("valor debe ser un numero");
	        	_monto_ingreso_marzo = _monto_ingreso_marzo_paso.ToString();
	        }
	    }
    	private string _monto_ingreso_marzo;
    	
    	public string monto_ingreso_abril
	    {
	        get { return _monto_ingreso_abril; }
	        set
	        {
	        	int _monto_ingreso_abril_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                throw new ArgumentException("Valor no puede ser vacio");
	        	if (!int.TryParse(value, out _monto_ingreso_abril_paso))
	            	throw new ArgumentException("valor debe ser un numero");
	        	_monto_ingreso_abril = _monto_ingreso_abril_paso.ToString();
	        }
	    }
    	private string _monto_ingreso_abril;
    	
    	public string monto_ingreso_mayo
	    {
	        get { return _monto_ingreso_mayo; }
	        set
	        {
	        	int _monto_ingreso_mayo_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                throw new ArgumentException("Valor no puede ser vacio");
	        	if (!int.TryParse(value, out _monto_ingreso_mayo_paso))
	            	throw new ArgumentException("valor debe ser un numero");
	        	_monto_ingreso_mayo = _monto_ingreso_mayo_paso.ToString();
	        }
	    }
    	private string _monto_ingreso_mayo;
    	
    	public string monto_ingreso_junio
	    {
	        get { return _monto_ingreso_junio; }
	        set
	        {
	        	int _monto_ingreso_junio_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                throw new ArgumentException("Valor no puede ser vacio");
	        	if (!int.TryParse(value, out _monto_ingreso_junio_paso))
	            	throw new ArgumentException("valor debe ser un numero");
	        	_monto_ingreso_junio = _monto_ingreso_junio_paso.ToString();
	        }
	    }
    	private string _monto_ingreso_junio;
    	
    	public string monto_ingreso_julio
	    {
	        get { return _monto_ingreso_julio; }
	        set
	        {
	        	int _monto_ingreso_julio_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                throw new ArgumentException("Valor no puede ser vacio");
	        	if (!int.TryParse(value, out _monto_ingreso_julio_paso))
	            	throw new ArgumentException("valor debe ser un numero");
	        	_monto_ingreso_julio = _monto_ingreso_julio_paso.ToString();
	        }
	    }
    	private string _monto_ingreso_julio;
    	
    	public string monto_ingreso_agosto
	    {
	        get { return _monto_ingreso_agosto; }
	        set
	        {
	        	int _monto_ingreso_agosto_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                throw new ArgumentException("Valor no puede ser vacio");
	        	if (!int.TryParse(value, out _monto_ingreso_agosto_paso))
	            	throw new ArgumentException("valor debe ser un numero");
	        	_monto_ingreso_agosto = _monto_ingreso_agosto_paso.ToString();
	        }
	    }
    	private string _monto_ingreso_agosto;
    	
    	public string monto_ingreso_septiembre
	    {
	        get { return _monto_ingreso_septiembre; }
	        set
	        {
	        	int _monto_ingreso_septiembre_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                throw new ArgumentException("Valor no puede ser vacio");
	        	if (!int.TryParse(value, out _monto_ingreso_septiembre_paso))
	            	throw new ArgumentException("valor debe ser un numero");
	        	_monto_ingreso_septiembre = _monto_ingreso_septiembre_paso.ToString();
	        }
	    }
    	private string _monto_ingreso_septiembre;
    	
    	public string monto_ingreso_octubre
	    {
	        get { return _monto_ingreso_octubre; }
	        set
	        {
	        	int _monto_ingreso_octubre_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                throw new ArgumentException("Valor no puede ser vacio");
	        	if (!int.TryParse(value, out _monto_ingreso_octubre_paso))
	            	throw new ArgumentException("valor debe ser un numero");
	        	_monto_ingreso_octubre = _monto_ingreso_octubre_paso.ToString();
	        }
	    }
    	private string _monto_ingreso_octubre;
    	
    	public string monto_ingreso_noviembre
	    {
	        get { return _monto_ingreso_noviembre; }
	        set
	        {
	        	int _monto_ingreso_noviembre_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                throw new ArgumentException("Valor no puede ser vacio");
	        	if (!int.TryParse(value, out _monto_ingreso_noviembre_paso))
	            	throw new ArgumentException("valor debe ser un numero");
	        	_monto_ingreso_noviembre = _monto_ingreso_noviembre_paso.ToString();
	        }
	    }
    	private string _monto_ingreso_noviembre;
    	
    	public string monto_ingreso_diciembre
	    {
	        get { return _monto_ingreso_diciembre; }
	        set
	        {
	        	int _monto_ingreso_diciembre_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                throw new ArgumentException("Valor no puede ser vacio");
	        	if (!int.TryParse(value, out _monto_ingreso_diciembre_paso))
	            	throw new ArgumentException("valor debe ser un numero");
	        	_monto_ingreso_diciembre = _monto_ingreso_diciembre_paso.ToString();
	        }
	    }
    	private string _monto_ingreso_diciembre;
    	//Monto ingreso mensual
    	public string retorna_registro_tipo_2(int anodj)
    	{
    		if (anodj == 2023)
    		{
	    		string salida = this.tipo_registro + this.numero_formulario + this.codigo_presentacion + this.n_de_folio + this.numero_rut 
	    			+ this.digito_verificador + this.numero_rut_receptor + this.digito_verificador_receptor + this.renta_total_neta + this.imp_uni_sgda_cat_ret
	    			+ this.mayor_retencion_solicitada + this.renta_total_no_grabada + this.renta_total_exenta + this.rebaja_zona_exenta 
	    			+this.prestamos_tasa_0_2020_2021 + this.prestamos_enero  + this.prestamos_febrero + this.prestamos_marzo + this.prestamos_abril 
	    			+ this.prestamos_mayo + this.prestamos_junio + this.prestamos_julio + this.prestamos_agosto + this.prestamos_septiembre + this.prestamos_octubre 
	    			+ this.prestamos_noviembre + this.prestamos_diciembre + monto_ingreso_enero + monto_ingreso_febrero + monto_ingreso_marzo + monto_ingreso_abril + monto_ingreso_mayo 
	    			+ monto_ingreso_junio + monto_ingreso_julio + monto_ingreso_agosto + monto_ingreso_septiembre + monto_ingreso_octubre + monto_ingreso_noviembre + monto_ingreso_diciembre ;
	
	    		return salida + "".PadRight(308 - salida.Length);
    		}else
    		{
    			errores.escribir_error("<error>" + "DDJJ 1887" + ";" + "retorna_registro_tipo_1_2" + ";" + "año no soportado para esta version" + "</error>");
    			return "";
    		}
    	}
    	
	}
		
		
}

