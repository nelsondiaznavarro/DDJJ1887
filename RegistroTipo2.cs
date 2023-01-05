/*
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
			//inicialización de valores fijos
			
		}
		
		public  errores errores  {get; set;}
		
		public string tipo_registro
	    {
	        get { return _tipo_registro; }
	        set
	        {
	        	int _tipo_registro_paso = 0;
	        	if (string.IsNullOrEmpty(value.ToString()))
	                errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Tipo Registro" + ";" + "valor no puede ser vacio" + "</error></fila>");
	        	if (value.Length != 1)
	        		errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Tipo Registro" + ";" + "valor debe ser un numero de un digito" + "</error></fila>");
	        	if (!int.TryParse(value, out _tipo_registro_paso))
	        	{
	        		errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Tipo Registro" + ";" + "valor debe ser un numero" + "</error></fila>");
	        	}
	        	if ( _tipo_registro_paso != 2)
	        	{
	        		errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Tipo Registro" + ";" + "valor debe ser el numero 2" + "</error></fila>");
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
	               errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Número de Formulario" + ";" + "valor no puede ser vacio" + "</error></fila>");
	        	if (!int.TryParse(value, out _numero_formulario_paso))
	            	errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Número de Formulario" + ";" + "valor debe ser numérico" + "</error></fila>");
	        	if ( _numero_formulario_paso != 1887)
	        		errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Número de Formulario" + ";" + "valor debe ser el formulario 1887" + "</error></fila>");
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
	                errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Código Presentación" + ";" + "valor no puede ser vacio" + "</error></fila>");
	        	if (value != "I")
	                errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Código Presentación" + ";" + "valor debe ser la letra I" + "</error></fila>");
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
	                errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Folio" + ";" + "valor no puede ser vacio" + "</error></fila>");
	        	if (!int.TryParse(value, out _folio_paso) )
	            	errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Folio" + ";" + "valor debe ser numerico" + "</error></fila>");
	        	if (_folio_paso < 1 )
	        		errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Folio" + ";" + "valor debe ser numerico mayor a cero" + "</error></fila>");
	        	_n_de_folio = _folio_paso.ToString().PadLeft(7,'0');
	        }
	    }
    	private string _n_de_folio;
    	
    	public string tipo_declaracion
	    {
	        get { return _tipo_declaracion; }
	        set
	        {
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Tipo de Declaración" + ";" + "valor no puede ser vacio" + "</error></fila>");
	        	if (value != "O" && value != "R")
	                errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Código Prestación" + ";" + "valor debe ser la letra O o letra R" + "</error></fila>");
	        	_tipo_declaracion = value;
	        }
	    }
    	private string _tipo_declaracion;
    	
    	public string numero_rut
	    {
	        get { return _numero_rut; }
	        set
	        {
	        	int _numero_rut_paso = 0;
	        	if (string.IsNullOrEmpty(value.ToString()))
	                errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Número de RUT" + ";" + "valor no puede ser vacio" + "</error></fila>");
	        	if (!int.TryParse(value, out _numero_rut_paso))
	            	errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Número de RUT" + ";" + "valor debe ser un numero mayor a cero" + "</error></fila>");
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
	                errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Digito Verificador" + ";" + "valor no puede ser vacio" + "</error></fila>");
	        	if (value.Length !=1)
	        		errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Digito Verificador" + ";" + "valor debe ser un caracter" + "</error></fila>");
	        	if (value != validaciones.Digito (int.Parse( numero_rut)))
	        		errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Digito Verificador" + ";" + "Rut invalido, error en  Digito Verrificador" + "</error></fila>");
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
	        	if (this.tipo_declaracion== "O")
	        	{
		        	
		        	if (string.IsNullOrEmpty(value.ToString()))
		                errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Número de RUT" + ";" + "valor no puede ser vacio" + "</error></fila>");
		        	if (!int.TryParse(value, out _numero_rut_receptor_paso))
		            	errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Número de RUT" + ";" + "valor debe ser un numero mayor a cero" + "</error></fila>");
	        	}else
	        	{
	        		_numero_rut_receptor = _numero_rut_receptor_paso.ToString().PadLeft(8, '0');
	        	}
	        
	        	
	        	
	        }
	    }
    	private string _numero_rut_receptor;
    	
    	public string digito_verificador_receptor
	    {
	        get { return _digito_verificador_receptor; }
	        set
	        {
	        	if (this.tipo_declaracion== "O")
	        	{
	        		if (string.IsNullOrEmpty(value.ToString()))
	                errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Digito Verificador receptor" + ";" + "valor no puede ser vacio" + "</error></fila>");
		        	if (value.Length !=1)
		        		errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Digito Verificador receptor" + ";" + "valor debe ser un caracter" + "</error></fila>");
		        	if (value != validaciones.Digito (int.Parse( numero_rut)))
	        			errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Digito Verificador receptor" + ";" + "Rut invalido, error en  Digito Verrificador" + "</error></fila>");
	        		_digito_verificador_receptor = value;
	        	
	        	}else
	        	{
	        		_digito_verificador_receptor = "0";
	        	}
	        	
	        	
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
	                errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Renta total Neta" + ";" + "valor no puede ser vacio" + "</error></fila>");
	        	if (!int.TryParse(value, out _renta_total_neta_paso))
	        	{
	        		errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Renta total Neta" + ";" + "valor debe ser numérico" + "</error></fila>");
	        	}else
	        	{
	        		if (_renta_total_neta_paso < 1 )
	        		{
	        			errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Renta total Neta" + ";" + "valor debe ser mayor a cero" + "</error></fila>");
	        		}else
	        		{
	        			_renta_total_neta = _renta_total_neta_paso.ToString().PadLeft(12,'0');
	        		}
	        	}
	            	
	        	
	        }
	    }
    	private string _renta_total_neta;
    	
    	public string imp_uni_sgda_cat_ret
	    {
	        get { return _imp_uni_sgda_cat_ret; }
	        set
	        {
	        	int _imp_uni_sgda_cat_ret_paso = 0;
	        	if (string.IsNullOrEmpty(value.ToString()))
	                errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Renta total Neta" + ";" + "valor no puede ser vacio" + "</error></fila>");
	        	if (!int.TryParse(value, out _imp_uni_sgda_cat_ret_paso))
	        	{
	        		errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Renta total Neta" + ";" + "valor debe ser numérico" + "</error></fila>");
	        	}else
	        	{
	        		if (! (_imp_uni_sgda_cat_ret_paso >= 0) )
	        		{
	        			errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Renta total Neta" + ";" + "valor debe ser mayor a cero" + "</error></fila>");
	        		}else
	        		{
	        			_imp_uni_sgda_cat_ret = _imp_uni_sgda_cat_ret_paso.ToString().PadLeft(12,'0');
	        		}
	        	}
	            	
	        	
	        }
	    }
    	private string _imp_uni_sgda_cat_ret;
    	
    	public string mayor_retencion_solicitada
	    {
	        get { return _mayor_retencion_solicitada; }
	        set
	        {
	        	int _mayor_retencion_solicitada_paso = 0;
	        	if (string.IsNullOrEmpty(value.ToString()))
	                errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Mayor retención solicitada" + ";" + "valor no puede ser vacio" + "</error></fila>");
	        	if (!int.TryParse(value, out _mayor_retencion_solicitada_paso))
	        	{
	        		errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Mayor retención solicitada" + ";" + "valor debe ser numérico" + "</error></fila>");
	        	}else
	        	{
	        		_mayor_retencion_solicitada = _mayor_retencion_solicitada_paso.ToString().PadLeft(12,'0');
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
	        	if (string.IsNullOrEmpty(value.ToString()))
	                errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Renta total no grabada" + ";" + "valor no puede ser vacio" + "</error></fila>");
	        	if (!int.TryParse(value, out _renta_total_no_grabada_paso))
	        	{
	        		errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Renta total no grabada" + ";" + "valor debe ser numérico" + "</error></fila>");
	        	}else
	        	{
	        		_renta_total_no_grabada =  _renta_total_no_grabada_paso.ToString().PadLeft(12,'0');
	        	}
	        	
	        }
	    }
    	private string _renta_total_no_grabada;
    	
    	public string renta_total_exenta
	    {
	        get { return _renta_total_exenta; }
	        set
	        {
	        	int _renta_total_exenta_paso = 0;
	        	if (string.IsNullOrEmpty(value.ToString()))
	                errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Renta total Exenta" + ";" + "valor no puede ser vacio" + "</error></fila>");
	        	if (!int.TryParse(value, out _renta_total_exenta_paso))
	        	{
	        		errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Renta total Exenta" + ";" + "valor debe ser numérico" + "</error></fila>");
	        	}else
	        	{
	        		_renta_total_exenta = _renta_total_exenta_paso.ToString().PadLeft(12,'0');
	        	}
	        	
	        }
	    }
    	private string _renta_total_exenta;
    	
    	public string rebaja_zona_extrema
	    {
	        get { return _rebaja_zona_extrema; }
	        set
	        {
	        	int _rebaja_zona_extrema_paso = 0;
	        	if (string.IsNullOrEmpty(value.ToString()))
	                errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Renta total Exenta" + ";" + "valor no puede ser vacio" + "</error></fila>");
	        	if (!int.TryParse(value, out _rebaja_zona_extrema_paso))
	        	{
	        		errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Renta total Exenta" + ";" + "valor debe ser numérico" + "</error></fila>");
	        	}else
	        	{
	        		_rebaja_zona_extrema = _rebaja_zona_extrema_paso.ToString().PadLeft(12,'0');
	        	}
	        }
	    }
    	private string _rebaja_zona_extrema;
    	//Prestamos
   	  	public string prestamos_tasa_0_2020_2021
	    {
	        get { return _prestamos_tasa_0_2020_2021; }
	        set
	        {
	        	int _prestamos_tasa_0_2020_2021_paso = 0;
	        	if (string.IsNullOrEmpty(value.ToString()))
	                errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Renta total Exenta" + ";" + "valor no puede ser vacio" + "</error></fila>");
	        	if (!int.TryParse(value, out _prestamos_tasa_0_2020_2021_paso))
	        	{
	        		errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Renta total Exenta" + ";" + "valor debe ser numérico" + "</error></fila>");
	        	}else
	        	{
	        		_prestamos_tasa_0_2020_2021 = _prestamos_tasa_0_2020_2021_paso.ToString().PadLeft(15,'0');
	        	}
	        }
	    }
    	private string _prestamos_tasa_0_2020_2021;
    	
    	public string prestamos_enero
	    {
	        get { return _prestamos_enero; }
	        set
	        {
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Prestamos Enero" + ";" + "valor no puede ser nulo" + "</error></fila>");
	        	_prestamos_enero = value.PadLeft(1,' ');
	        }
	    }
    	private string _prestamos_enero;
    	
    	public string prestamos_febrero
	    {
	        get { return _prestamos_febrero; }
	        set
	        {
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Prestamos Febrero" + ";" + "valor no puede ser nulo" + "</error></fila>");
	        	_prestamos_febrero = value.PadLeft(1,' ');
	        }
	    }
    	private string _prestamos_febrero;
    	
    	public string prestamos_marzo
	    {
	        get { return _prestamos_marzo; }
	        set
	        {
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Prestamos Marzo" + ";" + "valor no puede ser nulo" + "</error></fila>");
	        	_prestamos_marzo = value.PadLeft(1,' ');
	        }
	    }
    	private string _prestamos_marzo;
    	
    	public string prestamos_abril
	    {
	        get { return _prestamos_abril; }
	        set
	        {
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Prestamos Abril" + ";" + "valor no puede ser nulo" + "</error></fila>");
	        	_prestamos_abril = value.PadLeft(1,' ');
	        }
	    }
    	private string _prestamos_abril;
    	
    	public string prestamos_mayo
	    {
	        get { return _prestamos_mayo; }
	        set
	        {
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Prestamos Mayo" + ";" + "valor no puede ser nulo" + "</error></fila>");
	        	_prestamos_mayo = value.PadLeft(1,' ');
	        }
	    }
    	private string _prestamos_mayo;
    	
    	public string prestamos_junio
	    {
	        get { return _prestamos_junio; }
	        set
	        {
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Prestamos Junio" + ";" + "valor no puede ser nulo" + "</error></fila>");
	        	_prestamos_junio = value.PadLeft(1,' ');
	        }
	    }
    	private string _prestamos_junio;
    	
    	public string prestamos_julio
	    {
	        get { return _prestamos_julio; }
	        set
	        {
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Prestamos Julio" + ";" + "valor no puede ser nulo" + "</error></fila>");
	        	_prestamos_julio = value.PadLeft(1,' ');
	        }
	    }
    	private string _prestamos_julio;
    	
    	public string prestamos_agosto
	    {
	        get { return _prestamos_agosto; }
	        set
	        {
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Prestamos Agosto" + ";" + "valor no puede ser nulo" + "</error></fila>");
	        	_prestamos_agosto = value.PadLeft(1,' ');
	        }
	    }
    	private string _prestamos_agosto;
    	
    	public string prestamos_septiembre
	    {
	        get { return _prestamos_septiembre; }
	        set
	        {
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Prestamos Septiembre" + ";" + "valor no puede ser nulo" + "</error></fila>");
	        	_prestamos_septiembre = value.PadLeft(1,' ');
	        }
	    }
    	private string _prestamos_septiembre;
    	
    	public string prestamos_octubre
	    {
	        get { return _prestamos_octubre; }
	        set
	        {
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Prestamos Octubre" + ";" + "valor no puede ser nulo" + "</error></fila>");
	        	_prestamos_octubre = value.PadLeft(1,' ');
	        }
	    }
    	private string _prestamos_octubre;
    	
    	public string prestamos_noviembre
	    {
	        get { return _prestamos_noviembre; }
	        set
	        {
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Prestamos Noviembre" + ";" + "valor no puede ser nulo" + "</error></fila>");
	        	_prestamos_noviembre = value.PadLeft(1,' ');
	        }
	    }
    	private string _prestamos_noviembre;
    	
    	public string prestamos_diciembre
	    {
    		
    		//validar si al menos un mes tiene una C o una P
	        get { return _prestamos_diciembre; }
	        set
	        {
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Prestamos Diciembre" + ";" + "valor no puede ser nulo" + "</error></fila>");
	        	if (this.tipo_declaracion == "O")
	        	{
	        		if ((this.prestamos_enero=="C" || this.prestamos_enero=="P")
							        		 || (this.prestamos_febrero=="C" || this.prestamos_febrero=="P")
							        		 || (this.prestamos_marzo=="C" || this.prestamos_marzo=="P")
							        		 || (this.prestamos_abril=="C" || this.prestamos_abril=="P")
							        		 || (this.prestamos_mayo=="C" || this.prestamos_mayo=="P")
							        		 || (this.prestamos_junio=="C" || this.prestamos_junio=="P")
							        		 || (this.prestamos_julio=="C" || this.prestamos_julio=="P")
							        		 || (this.prestamos_agosto=="C" || this.prestamos_agosto=="P")
							        		 || (this.prestamos_septiembre=="C" || this.prestamos_septiembre=="P")
							        		 || (this.prestamos_octubre=="C" || this.prestamos_octubre=="P")
							        		 || (this.prestamos_noviembre=="C" || this.prestamos_noviembre=="P")
							        		 || (this.prestamos_diciembre=="C" || this.prestamos_diciembre=="P"))
	        		{
	        		
	        			_prestamos_diciembre = value.PadLeft(1,' ');
	        		}else
	        		{
	        			 errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Prestamos Diciembre" + ";" + "valor no puede ser nulo ni blanco al menos un mes debe tener la letra P o C si es DDJJ Original" + "</error></fila>");
	        		}
	        	}else
	        	{
	        		_prestamos_diciembre = value.PadLeft(1,' ');
	        	}
	        	
	        	
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
	                errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Número de certificado" + ";" + "valor no puede ser nulo ni blanco" + "</error></fila>");
	        	if (!int.TryParse(value, out _numero_certificado_paso))
	            	errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Número de certificado" + ";" + "valor debe ser numérico" + "</error></fila>");
	        	if (value.Length > 7)
	        	{
	        		_numero_certificado = _numero_certificado_paso.ToString().Substring(0,7);
	        	}else
	        	{
	        		_numero_certificado = _numero_certificado_paso.ToString().PadLeft(7,'0');
	        	}
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
	                errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Ingreso monto Enero" + ";" + "valor no puede ser nulo ni blanco" + "</error></fila>");
	        	if (!int.TryParse(value, out _monto_ingreso_enero_paso))
	            	errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Ingreso monto Enero" + ";" + "valor debe ser numérico" + "</error></fila>");
	        	_monto_ingreso_enero = _monto_ingreso_enero_paso.ToString().PadLeft(12,'0');
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
	                errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Ingreso monto Febrero" + ";" + "valor no puede ser nulo ni blanco" + "</error></fila>");
	        	if (!int.TryParse(value, out _monto_ingreso_febrero_paso))
	            	errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Ingreso monto Febrero" + ";" + "valor debe ser numérico" + "</error></fila>");
	        	_monto_ingreso_febrero = _monto_ingreso_febrero_paso.ToString().PadLeft(12,'0');
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
	                errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Ingreso monto Marzo" + ";" + "valor no puede ser nulo ni blanco" + "</error></fila>");
	        	if (!int.TryParse(value, out _monto_ingreso_marzo_paso))
	            	errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Ingreso monto Marzo" + ";" + "valor debe ser numérico" + "</error></fila>");
	        	_monto_ingreso_marzo = _monto_ingreso_marzo_paso.ToString().PadLeft(12,'0');
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
	                errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Ingreso monto Abril" + ";" + "valor no puede ser nulo ni blanco" + "</error></fila>");
	        	if (!int.TryParse(value, out _monto_ingreso_abril_paso))
	            	errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Ingreso monto Abril" + ";" + "valor debe ser numérico" + "</error></fila>");
	        	_monto_ingreso_abril = _monto_ingreso_abril_paso.ToString().PadLeft(12,'0');
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
	                errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Ingreso monto Mayo" + ";" + "valor no puede ser vacío" + "</error></fila>");
	        	if (!int.TryParse(value, out _monto_ingreso_mayo_paso))
	            	errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Ingreso monto Junio" + ";" + "valor debe ser numérico" + "</error></fila>");
	        	_monto_ingreso_mayo = _monto_ingreso_mayo_paso.ToString().PadLeft(12,'0');
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
	                errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Ingreso monto Junio" + ";" + "valor no puede ser nulo ni blanco" + "</error></fila>");
	        	if (!int.TryParse(value, out _monto_ingreso_junio_paso))
	            	errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Ingreso monto Abril" + ";" + "valor debe ser numérico" + "</error></fila>");
	        	_monto_ingreso_junio = _monto_ingreso_junio_paso.ToString().PadLeft(12,'0');
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
	                errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Ingreso monto Julio" + ";" + "valor no puede ser nulo ni blanco" + "</error></fila>");
	        	if (!int.TryParse(value, out _monto_ingreso_julio_paso))
	            	errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Ingreso monto Julio" + ";" + "valor debe ser numérico" + "</error></fila>");
	        	_monto_ingreso_julio = _monto_ingreso_julio_paso.ToString().PadLeft(12,'0');
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
	                errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Ingreso monto Agosto" + ";" + "valor no puede ser nulo ni blanco" + "</error></fila>");
	        	if (!int.TryParse(value, out _monto_ingreso_agosto_paso))
	            	errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Ingreso monto Agosto" + ";" + "valor debe ser numérico" + "</error></fila>");
	        	_monto_ingreso_agosto = _monto_ingreso_agosto_paso.ToString().PadLeft(12,'0');
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
	                errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Ingreso monto Septiembre" + ";" + "valor no puede ser nulo ni blanco" + "</error></fila>");
	        	if (!int.TryParse(value, out _monto_ingreso_septiembre_paso))
	            	errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Ingreso monto Septiembre" + ";" + "valor debe ser numérico" + "</error></fila>");
	        	_monto_ingreso_septiembre = _monto_ingreso_septiembre_paso.ToString().PadLeft(12,'0');
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
	                errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Ingreso monto Octubre" + ";" + "valor no puede ser nulo ni blanco" + "</error></fila>");
	        	if (!int.TryParse(value, out _monto_ingreso_octubre_paso))
	            	errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Ingreso monto Octubre" + ";" + "valor debe ser numérico" + "</error></fila>");
	        	_monto_ingreso_octubre = _monto_ingreso_octubre_paso.ToString().PadLeft(12,'0');
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
	                errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Ingreso monto Noviembre" + ";" + "valor no puede ser nulo ni blanco" + "</error></fila>");
	        	if (!int.TryParse(value, out _monto_ingreso_noviembre_paso))
	            	errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Ingreso monto Noviembre" + ";" + "valor debe ser numérico" + "</error></fila>");
	        	_monto_ingreso_noviembre = _monto_ingreso_noviembre_paso.ToString().PadLeft(12,'0');
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
	                errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Ingreso monto Diciembre" + ";" + "valor no puede ser nulo ni blanco" + "</error></fila>");
	        	if (!int.TryParse(value, out _monto_ingreso_diciembre_paso))
	            	errores.escribir_error("<fila><error>" + "Registro tipo 2" + ";" + "Ingreso monto Diciembre" + ";" + "valor debe ser numérico" + "</error></fila>");
	        	_monto_ingreso_diciembre = _monto_ingreso_diciembre_paso.ToString().PadLeft(12,'0');
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
	    			+ this.mayor_retencion_solicitada + this.renta_total_no_grabada + this.renta_total_exenta + this.rebaja_zona_extrema 
	    			+this.prestamos_tasa_0_2020_2021 + this.prestamos_enero  + this.prestamos_febrero + this.prestamos_marzo + this.prestamos_abril 
	    			+ this.prestamos_mayo + this.prestamos_junio + this.prestamos_julio + this.prestamos_agosto + this.prestamos_septiembre + this.prestamos_octubre 
	    			+ this.prestamos_noviembre + this.prestamos_diciembre + monto_ingreso_enero + monto_ingreso_febrero + monto_ingreso_marzo + monto_ingreso_abril + monto_ingreso_mayo 
	    			+ monto_ingreso_junio + monto_ingreso_julio + monto_ingreso_agosto + monto_ingreso_septiembre + monto_ingreso_octubre + monto_ingreso_noviembre + monto_ingreso_diciembre ;
	
	    		return salida + "".PadRight(308 - salida.Length);
    		}else
    		{
    			errores.escribir_error("<fila><error>" + "DDJJ 1887" + ";" + "retorna_registro_tipo_1_2" + ";" + "año no soportado para esta version" + "</error></fila>");
    			return "";
    		}
    	}
    	
	}
		
		
}

