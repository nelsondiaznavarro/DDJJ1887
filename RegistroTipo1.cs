/*
 * Created by SharpDevelop.
 * User: rjc
 * Date: 28-12-2022
 * Time: 10:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace DDJJ1887
{
	/// <summary>
	/// Description of RegistroTipo1.
	/// </summary>
	public class registrotipo1_1
	{
		private string _blancos = "      ";
		private string _blancos_ultimo_campo = "".PadRight(260, ' ');
		
		
		
		
		public registrotipo1_1()
		{
		}
		
		
		public   errores errores  {get; set;}
		
		public string tipo_registro
	    {
	        get { return _tipo_registro; }
	        set
	        {
	        	int _tipo_registro_paso = 0;
	        	if (string.IsNullOrEmpty(value.ToString()))
	                errores.escribir_error("<error>" + "Registro tipo 1" + ";" + "Tipo Registro" + ";" + "valor no puede ser vacio" + "</error>");
	        	if (value.Length != 1)
	        		errores.escribir_error("<error>" + "Registro tipo 1" + ";" + "Tipo Registro" + ";" + "valor debe ser un numero de un digito" + "</error>");
	        	if (!int.TryParse(value, out _tipo_registro_paso))
	        	{
	        		errores.escribir_error("<error>" + "Registro tipo 1" + ";" + "Tipo Registro" + ";" + "valor debe ser un numero" + "</error>");
	        	}
	        	if ( _tipo_registro_paso != 1)
	        	{
	        		errores.escribir_error("<error>" + "Registro tipo 1" + ";" + "Tipo Registro" + ";" + "valor debe ser el numero 1" + "</error>");
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
	                errores.escribir_error("<error>" + "Registro tipo 1 1" + ";" + "Orden Preced" + ";" + "valor no puede ser vacio" + "</error>");
	        	if (!int.TryParse(value, out _determina_orden_preced_paso))
	            	errores.escribir_error("<error>" + "Registro tipo 1 1" + ";" + "Orden Preced" + ";" + "valor debe ser numérico" + "</error>");
	        	if (_determina_orden_preced_paso!=1)
	            	errores.escribir_error("<error>" + "Registro tipo 1 1" + ";" + "Orden Preced" + ";" + "valor debe el número 1" + "</error>");
	        	_determina_orden_preced = _determina_orden_preced_paso.ToString();
	        	
	        }
	    }
    	private string _determina_orden_preced;
    	
    	public string ano_tributario
	    {
	        get { return _ano_tributario; }
	        set
	        {
	        	int _ano_tributario_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                
	            	errores.escribir_error("<error>" + "Registro tipo 1 1" + ";" + "Año tributario" + ";" + "valor no puede ser vacío" + "</error>");
	        	if (!int.TryParse(value, out _ano_tributario_paso))
	            	errores.escribir_error("<error>" + "Registro tipo 1 1" + ";" + "Año tributario" + ";" + "valor debe ser numérico" + "</error>");
	        	if (_ano_tributario_paso != 2023)
	            	errores.escribir_error("<error>" + "Registro tipo 1 1" + ";" + "Año tributario" + ";" + "Año no soportado por actual versión de DDJJ" + "</error>");

	        	_ano_tributario = _ano_tributario_paso.ToString();
	        }
	    }
    	private string _ano_tributario;
    	
    	public string numero_formulario
	    {
	        get { return _numero_formulario; }
	        set
	        {
	        	int _numero_formulario_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	               errores.escribir_error("<error>" + "Registro tipo 1" + ";" + "Número de Formulario" + ";" + "valor no puede ser vacio" + "</error>");
	        	if (!int.TryParse(value, out _numero_formulario_paso))
	            	errores.escribir_error("<error>" + "Registro tipo 1" + ";" + "Número de Formulario" + ";" + "valor debe ser numérico" + "</error>");
	        	if ( _numero_formulario_paso != 1887)
	        		errores.escribir_error("<error>" + "Registro tipo 1" + ";" + "Número de Formulario" + ";" + "valor debe ser el formulario 1887" + "</error>");
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
	                errores.escribir_error("<error>" + "Registro tipo 1" + ";" + "Código Presentación" + ";" + "valor no puede ser vacio" + "</error>");
	        	if (value != "I")
	                errores.escribir_error("<error>" + "Registro tipo 1" + ";" + "Código Presentación" + ";" + "valor debe ser la letra I" + "</error>");
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
	                errores.escribir_error("<error>" + "Registro tipo 1" + ";" + "Folio" + ";" + "valor no puede ser vacio" + "</error>");
	        	if (!int.TryParse(value, out _folio_paso) )
	            	errores.escribir_error("<error>" + "Registro tipo 1" + ";" + "Folio" + ";" + "valor debe ser numerico" + "</error>");
	        	if (_folio_paso < 1 )
	        		errores.escribir_error("<error>" + "Registro tipo 1" + ";" + "Folio" + ";" + "valor debe ser numerico mayor a cero" + "</error>");
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
	                errores.escribir_error("<error>" + "Registro tipo 1" + ";" + "Tipo de Declaración" + ";" + "valor no puede ser vacio" + "</error>");
	        	if (value != "O" && value != "R")
	                errores.escribir_error("<error>" + "Registro tipo 1" + ";" + "Tipo de Declaración" + ";" + "valor debe ser la letra I" + "</error>");
	        	_tipo_declaracion = value;
	        }
	    }
    	private string _tipo_declaracion;
    	
    	public string numero_rut_anterior
	    {
	        get { return _numero_rut_anterior; }
	        set
	        {
	        	int _numero_rut_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                errores.escribir_error("<error>" + "Registro tipo 1" + ";" + "Rut Anterior" + ";" + "valor no puede ser vacio" + "</error>");
	        	if (!int.TryParse(value, out _numero_rut_paso))
	            	errores.escribir_error("<error>" + "Registro tipo 1" + ";" + "Rut Anterior" + ";" + "valor debe ser numérico" + "</error>");
	        	_numero_rut_anterior = _numero_rut_paso.ToString().PadLeft(8, '0');
	        }
	    }
    	private string _numero_rut_anterior;
    	
    	public string digito_verificador_anterior
	    {
	        get { return _digito_verificador_anterior; }
	        set
	        {
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                errores.escribir_error("<error>" + "Registro tipo 1" + ";" + "Dígito verificador anterior" + ";" + "valor no puede ser vacio" + "</error>");
	        	if (int.Parse(numero_rut_anterior) > 0)
	        	{
	        		if (value != validaciones.Digito (int.Parse(numero_rut_anterior)))
	        		{
	        			errores.escribir_error("<error>" + "Registro tipo 1" + ";" + "Dígito verificador anterior" + ";" + "Error en dígito verificador rut erroneo" + "</error>");
	        		}
	        	}
	        	_digito_verificador_anterior = value;
	        }
	    }
    	private string _digito_verificador_anterior;
    	
    	public string codigo_presentacion_anterior
	    {
	        get { return _codigo_presentacion_anterior; }
	        set
	        {
	        	if (string.IsNullOrEmpty(value.ToString()))
	                errores.escribir_error("<error>" + "Registro tipo 1" + ";" + "Código presentación anterior" + ";" + "valor no puede ser vacio" + "</error>");
	        	if (this.tipo_declaracion == "O")
	        	{
	        		if (value != "I" && value != "M" &&  value != "F" )
	        			errores.escribir_error("<error>" + "Registro tipo 1" + ";" + "Código presentación anterior" + ";" + "valor debe ser I,F 0 M" + "</error>");
	        	}
	        	
	        		
	        	_codigo_presentacion_anterior = value;
	        }
	    }
    	private string _codigo_presentacion_anterior;
    	
    	public string n_de_folio_anterior
	    {
	        get { return _n_de_folio_anterior; }
	        set
	        {
	        	int _n_de_folio_anterior_paso = 0;
	        	if (string.IsNullOrEmpty(value.ToString()))
	                errores.escribir_error("<error>" + "Registro tipo 1" + ";" + "Múmero Folio anterior" + ";" + "valor no puede ser vacio" + "</error>");
	        	if (this.tipo_declaracion == "O")
	        	{
	        		if (!int.TryParse(value, out _n_de_folio_anterior_paso))
	        			errores.escribir_error("<error>" + "Registro tipo 1" + ";" + "Código presentación anterior" + ";" + "valor debe ser I,F 0 M" + "</error>");
	        		if (_n_de_folio_anterior_paso < 1)
	        			errores.escribir_error("<error>" + "Registro tipo 1" + ";" + "Código presentación anterior" + ";" + "valor debe ser mayor a 0" + "</error>");
	        	}
	        	_n_de_folio_anterior = value;
	        }
	    }
    	private string _n_de_folio_anterior;
    	
    	public string numero_rut_declarante
	    {
	        get { return _numero_rut_declarante; }
	        set
	        {
	        	int _numero_rut_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                errores.escribir_error("<error>" + "Registro tipo 1" + ";" + "Rut declarante" + ";" + "valor no puede ser vacio" + "</error>");
	        	if (!int.TryParse(value, out _numero_rut_paso))
	        		errores.escribir_error("<error>" + "Registro tipo 1" + ";" + "Rut declarante" + ";" + "valor debe ser numérico" + "</error>");
	        	if (_numero_rut_paso < 1 )
	        		errores.escribir_error("<error>" + "Registro tipo 1" + ";" + "Rut declarante" + ";" + "valor debe ser numérico mayor a 1" + "</error>");
	        	_numero_rut_declarante = _numero_rut_paso.ToString().PadLeft(8, '0');
	        }
	    }
    	private string _numero_rut_declarante;
    	
    	public string digito_verificador_declarante
	    {
	        get { return _digito_verificador_declarante; }
	        set
	        {
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                errores.escribir_error("<error>" + "Registro tipo 1" + ";" + "Dígito verificador declarante" + ";" + "valor no puede ser vacio" + "</error>");
	        	if (value != validaciones.Digito (int.Parse(numero_rut_declarante)))
	        		errores.escribir_error("<error>" + "Registro tipo 1" + ";" + "Dígito verificador declarante" + ";" + "Dígito verificador erroneo" + "</error>");
	        	
	        	_digito_verificador_declarante = value;
	        }
	    }
    	private string _digito_verificador_declarante;
    	
    	public string razon_social
	    {
	        get { return _razon_social; }
	        set
	        {
	        	if (string.IsNullOrEmpty(value.ToString()))
	                errores.escribir_error("<error>" + "Registro tipo 1" + ";" + "Razón Social" + ";" + "Debe tener al menos 1 caracter alfanumérico" + "</error>");
	        	if (value.Length < 30)
	        	{
	        		value = value.PadRight(30 - value.Length, ' ');
	        	}else
	        	{
	        		value = value.Substring(0,29);
	        	}
	        	_razon_social = value;
	        }
	    }
    	private string _razon_social;
    	
    	public string retorna_registro_tipo_1_1(int anodj)
    	{
    		
    		if (anodj == 2023)
    		{
    		
	    		this.tipo_registro = "1";
	    		this.determina_orden_preced = "1";
	    		this.ano_tributario = DateTime.Now.Year.ToString();
	    		this.numero_formulario = "1887";
	    		this.codigo_presentacion = "I";
	    		this.n_de_folio = "6666666";
	    		this.tipo_declaracion = "O";
	    		this.numero_rut_anterior = "00000000";
	    		this.digito_verificador_anterior = "0";
	    		this.codigo_presentacion_anterior = " "; //I, M ó F: Si Tipo Declaración es "R" (Rectificatoria); Blanco: Si Tipo Declaración es "O" (Original)
	    		this.n_de_folio_anterior = "0000000";  // LARGO 7 >0: Si tipo Declaración es “R” (Rectificatoria) ; =0 Si tipo Declaración es “O” (Original)
	    		string blancos_6 = "      ";
	    		string blancos_260 = "".PadLeft(260,' ');
	    		string salida =  this.tipo_registro +   this.determina_orden_preced +  this.ano_tributario + this.numero_formulario
	    						+ this.codigo_presentacion + this.n_de_folio + this.tipo_declaracion + this.numero_rut_anterior + this.digito_verificador_anterior 
								+ this.codigo_presentacion_anterior + this.n_de_folio_anterior + blancos_6 + this.numero_rut_declarante + this._digito_verificador_declarante 
	    			+ this.razon_social + blancos_260;
	    		return salida ;
    		}else
    		{
    			errores.escribir_error("<error>" + "DDJJ 1887" + ";" + "retorna_registro_tipo_1_1" + ";" + "año no soportado para esta version" + "</error>");
    			return "";
    		}
    	}
    	
    	
    	
    	
	}

	public class registrotipo1_2
	{
		private string _blancos = "".PadLeft(248, '0');
		private string _blancos_ultimo_campo = "".PadLeft(260, '0');
		
		public registrotipo1_2()
		{
		}
		
		
		public   errores errores  {get; set;}
		
		public string tipo_registro
	    {
	        get { return _tipo_registro; }
	        set
	        {
	        	int _tipo_registro_paso = 0;
	        	if (string.IsNullOrEmpty(value.ToString()))
	                errores.escribir_error("<error>" + "Registro tipo 1 2" + ";" + "Tipo Registro" + ";" + "valor no puede ser vacio" + "</error>");
	        	if (value.Length != 1)
	        		errores.escribir_error("<error>" + "Registro tipo 1 2" + ";" + "Tipo Registro" + ";" + "valor debe ser un numero de un digito" + "</error>");
	        	if (!int.TryParse(value, out _tipo_registro_paso))
	        	{
	        		errores.escribir_error("<error>" + "Registro tipo 1 2" + ";" + "Tipo Registro" + ";" + "valor debe ser un numero" + "</error>");
	        	}
	        	if ( _tipo_registro_paso != 1)
	        	{
	        		errores.escribir_error("<error>" + "Registro tipo 1 2" + ";" + "Tipo Registro" + ";" + "valor debe ser el numero 1" + "</error>");
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
	                errores.escribir_error("<error>" + "Registro tipo 1 2" + ";" + "Orden Preced" + ";" + "valor no puede ser vacio" + "</error>");
	        	if (!int.TryParse(value, out _determina_orden_preced_paso))
	            	errores.escribir_error("<error>" + "Registro tipo 1 2" + ";" + "Orden Preced" + ";" + "valor debe ser numérico" + "</error>");
	        	if (_determina_orden_preced_paso!=2)
	            	errores.escribir_error("<error>" + "Registro tipo 1 2" + ";" + "Orden Preced" + ";" + "valor debe el número 2" + "</error>");
	        	_determina_orden_preced = _determina_orden_preced_paso.ToString();
	        }
	    }
    	private string _determina_orden_preced;
    	
    	public string direccion_postal
	    {
	        get { return _direccion_postal; }
	        set
	        {
	        	if (string.IsNullOrEmpty(value.ToString()))
	                errores.escribir_error("<error>" + "Registro tipo 1 2" + ";" + "Dirección Postal" + ";" + "valor no puede ser vacio" + "</error>");
	        	if (value.Length > 35 )
	        	{
	        		_direccion_postal = value.Substring(0,34);
	        	}else
	        	{
	        		_direccion_postal = value.ToString().PadRight(35, ' ');
	        	}
	        	
	        }
	    }
    	private string _direccion_postal;
    	
    	public string comuna
	    {
	        get { return _comuna; }
	        set
	        {
	        	
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                errores.escribir_error("<error>" + "Registro tipo 1 2" + ";" + "Cómuna" + ";" + "valor no puede ser vacio" + "</error>");
	        	if (value.Length > 15 )
	        	{
	        		_comuna = value.Substring(0,14);
	        	}else
	        	{
	        		_comuna = value.ToString().PadRight(15, ' ');;
	        	}
	        	
	        	
	        }
	    }
    	private string _comuna;
    	
    	public string correo_electronico
	    {
	        get { return _correo_electronico; }
	        set
	        {
	        	if (string.IsNullOrEmpty(value.ToString()))
	                errores.escribir_error("<error>" + "Registro tipo 1 2" + ";" + "Correo electrónico" + ";" + "valor no puede ser vacio" + "</error>");
	        	if (value.Length < 30)
	        	{
	        		value = value.PadRight(30 - value.Length, ' ');
	        	}else
	        	{
	        		value = value.Substring(0,29);
	        	}
	        	_correo_electronico = value;
	        }
	    }
    	private string _correo_electronico;
    	
    	public string codigo_pais
	    {
	        get { return _codigo_pais; }
	        set
	        {
	        	int _codigo_pais_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                errores.escribir_error("<error>" + "Registro tipo 1 2" + ";" + "Código país" + ";" + "valor no puede ser vacio" + "</error>");
	        	if (!int.TryParse(value, out _codigo_pais_paso))
	            	errores.escribir_error("<error>" + "Registro tipo 1 2" + ";" + "Código país" + ";" + "valor debe ser numérico" + "</error>");
	        	if (_codigo_pais_paso != 56)
	        		errores.escribir_error("<error>" + "Registro tipo 1 2" + ";" + "Código país" + ";" + "Código país debe ser 56" + "</error>");
	        	_codigo_pais = _codigo_pais_paso.ToString();
	        }
	    }
    	private string _codigo_pais;
    	
    	public string cod_area_ciudad
	    {
	        get { return _cod_area_ciudad; }
	        set
	        {
	        	int _cod_area_ciudad_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                errores.escribir_error("<error>" + "Registro tipo 1 2" + ";" + "Código área" + ";" + "valor no puede ser vacio" + "</error>");
	        	if (!int.TryParse(value, out _cod_area_ciudad_paso))
	            	errores.escribir_error("<error>" + "Registro tipo 1 2" + ";" + "Código área" + ";" + "valor debe ser numérico" + "</error>");
	        	if (_cod_area_ciudad_paso < 10 && _cod_area_ciudad_paso > 99)
	        		errores.escribir_error("<error>" + "Registro tipo 1 2" + ";" + "Código área" + ";" + "valor debe ser numérico de dos digitos" + "</error>");
	        		
	        	_cod_area_ciudad = _cod_area_ciudad_paso.ToString();
	        }
	    }
    	private string _cod_area_ciudad;
    	
    	public string telefono
	    {
	        get { return _telefono; }
	        set
	        {
	        	int _telefono_paso = 0;
	        	if (string.IsNullOrEmpty(value.ToString()))
	                errores.escribir_error("<error>" + "Registro tipo 1 2" + ";" + "Número de Teléfono" + ";" + "valor no puede ser vacio" + "</error>");
	        	if (!int.TryParse(value, out _telefono_paso))
	            	errores.escribir_error("<error>" + "Registro tipo 1 2" + ";" + "Número de Teléfono" + ";" + "valor deb eser numérico" + "</error>");
	        	if (value.Length > 7)
	        	{
	        		_telefono = _telefono_paso.ToString().Substring(0,7);
	        	}else
	        	{
	        		_telefono = _telefono_paso.ToString().PadRight(7,' ');
	        	}
	        }
	    }
    	private string _telefono;
    	
    	public string retorna_registro_tipo_1_2(int anodj)
    	{
    		if (anodj == 2023)
    		{
    		
    			string salida = this.tipo_registro + this.determina_orden_preced 
   								+ this.direccion_postal + this.comuna + this.correo_electronico
								+ this.codigo_pais + this.cod_area_ciudad + this.telefono 		;
    			return salida + "".PadRight(248 - salida.Length);
    		}else
    		{
    			errores.escribir_error("<error>" + "DDJJ 1887" + ";" + "retorna_registro_tipo_1_2" + ";" + "año no soportado para esta version" + "</error>");
    			return "";
    		}
    	}
    	
	}

	public class registrotipo1_3
	{
		private string _blancos = "".PadLeft(308, '0');
		
		
		public registrotipo1_3()
		{
		}
		
		
		public   errores errores  {get; set;}
		
		
		public string tipo_registro
	    {
	        get { return _tipo_registro; }
	        set
	        {
	        	int _tipo_registro_paso = 0;
	        	if (string.IsNullOrEmpty(value.ToString()))
	                errores.escribir_error("<error>" + "Registro tipo 1 3" + ";" + "Tipo Registro" + ";" + "valor no puede ser vacio" + "</error>");
	        	if (value.Length != 1)
	        		errores.escribir_error("<error>" + "Registro tipo 1 3" + ";" + "Tipo Registro" + ";" + "valor debe ser un numero de un digito" + "</error>");
	        	if (!int.TryParse(value, out _tipo_registro_paso))
	        	{
	        		errores.escribir_error("<error>" + "Registro tipo 1 3" + ";" + "Tipo Registro" + ";" + "valor debe ser un numero" + "</error>");
	        	}
	        	if ( _tipo_registro_paso != 1)
	        	{
	        		errores.escribir_error("<error>" + "Registro tipo 1 3" + ";" + "Tipo Registro" + ";" + "valor debe ser el numero 1" + "</error>");
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
	        	if (string.IsNullOrEmpty(value.ToString()))
	                errores.escribir_error("<error>" + "Registro tipo 1 2" + ";" + "Orden Preced" + ";" + "valor no puede ser vacio" + "</error>");
	        	if (!int.TryParse(value, out _determina_orden_preced_paso))
	            	errores.escribir_error("<error>" + "Registro tipo 1 2" + ";" + "Orden Preced" + ";" + "valor debe ser numérico" + "</error>");
	        	if (_determina_orden_preced_paso!=3)
	            	errores.escribir_error("<error>" + "Registro tipo 1 2" + ";" + "Orden Preced" + ";" + "valor debe el número 3" + "</error>");
	        	_determina_orden_preced = _determina_orden_preced_paso.ToString();
	        }
	    }
    	private string _determina_orden_preced;
    	
    	public string codigo_pais
	    {
	        get { return _codigo_pais; }
	        set
	        {
	        	int _codigo_pais_paso = 0;
	        	if (string.IsNullOrEmpty(value.ToString()))
	                errores.escribir_error("<error>" + "Registro tipo 1 3" + ";" + "Código país" + ";" + "valor no puede ser vacio" + "</error>");
	        	if (!int.TryParse(value, out _codigo_pais_paso))
	            	errores.escribir_error("<error>" + "Registro tipo 1 3" + ";" + "Código país" + ";" + "valor debe ser numérico" + "</error>");
	        	if (_codigo_pais_paso != 56)
	        		errores.escribir_error("<error>" + "Registro tipo 1 3" + ";" + "Código país" + ";" + "Código país debe ser 56" + "</error>");
	        	_codigo_pais = _codigo_pais_paso.ToString();
	        }
	    }
    	private string _codigo_pais;
    	
    	public string cod_area_ciudad
	    {
	        get { return _cod_area_ciudad; }
	        set
	        {
	        	int _cod_area_ciudad_paso = 0;
	        	if (string.IsNullOrEmpty(value.ToString()))
	                errores.escribir_error("<error>" + "Registro tipo 1 3" + ";" + "Código área" + ";" + "valor no puede ser vacio" + "</error>");
	        	if (!int.TryParse(value, out _cod_area_ciudad_paso))
	            	errores.escribir_error("<error>" + "Registro tipo 1 3" + ";" + "Código área" + ";" + "valor debe ser numérico" + "</error>");
	        	if (_cod_area_ciudad_paso < 10 && _cod_area_ciudad_paso > 99)
	        		errores.escribir_error("<error>" + "Registro tipo 1 3" + ";" + "Código área" + ";" + "valor debe ser numérico de dos digitos" + "</error>");
	        	_cod_area_ciudad = _cod_area_ciudad_paso.ToString();
	        }
	    }
    	private string _cod_area_ciudad;
    	
    	public string telefono
	    {
	        get { return _telefono; }
	        set
	        {
	        	int _telefono_paso = 0;
	        	if (string.IsNullOrEmpty(value.ToString()))
	                errores.escribir_error("<error>" + "Registro tipo 1 3" + ";" + "Número de Teléfono" + ";" + "valor no puede ser vacio" + "</error>");
	        	if (!int.TryParse(value, out _telefono_paso))
	            	errores.escribir_error("<error>" + "Registro tipo 1 3" + ";" + "Número de Teléfono" + ";" + "valor debe ser numérico" + "</error>");
	        	if (value.Length > 7)
	        	{
	        		_telefono = _telefono_paso.ToString().Substring(0,7);
	        	}else
	        	{
	        		_telefono = _telefono_paso.ToString().PadRight(7,' ');
	        	}
	        }
	    }
    	private string _telefono;
    	
    	public string codigo_empresa
	    {
	        get { return _codigo_empresa; }
	        set
	        {
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                errores.escribir_error("<error>" + "Registro tipo 1 3" + ";" + "Código Empresa" + ";" + "valor no puede ser vacio" + "</error>");
	        	if (value.Length ==2)
	        	{
	        		_codigo_empresa = value;
	        	}else
	        	{
	        		errores.escribir_error("<error>" + "Registro tipo 1 3" + ";" + "Código Empresa" + ";" + "Código empresa debe ser de largo 2" + "</error>");
	        	}
	        	
	        }
	    }
    	private string _codigo_empresa;
    	
    	public string numero_cliente
	    {
	        get { return _numero_cliente; }
	        set
	        {
	        	int _numero_cliente_paso = 0;
	        	if (string.IsNullOrEmpty(value.ToString()))
	                errores.escribir_error("<error>" + "Registro tipo 1 3" + ";" + "Número cliente" + ";" + "Número cliente no puede ser vacío" + "</error>");
	        	if (!int.TryParse(value, out _numero_cliente_paso))
	        	{
	        		errores.escribir_error("<error>" + "Registro tipo 1 3" + ";" + "Número cliente" + ";" + "Número cliente debe ser numérico" + "</error>");
	        	}else
	        	{
	        		if (value.Length == 4)
	        		{
	        			_numero_cliente = value;
	        		}else
	        		{
	        			errores.escribir_error("<error>" + "Registro tipo 1 3" + ";" + "Número cliente" + ";" + "Número cliente debe ser numérico de largo 4" + "</error>");
	        			_numero_cliente = value;
	        		}
	        	}

	        }
	    }
    	private string _numero_cliente;

    	public string unidad
	    {
	        get { return _unidad; }
	        set
	        {
	        	int _unidad_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                errores.escribir_error("<error>" + "Registro tipo 1 3" + ";" + "Número cliente" + ";" + "Número cliente debe ser numérico de largo 4" + "</error>");
	        	if (!int.TryParse(value, out _unidad_paso))
	            	errores.escribir_error("<error>" + "Registro tipo 1 3" + ";" + "Número cliente" + ";" + "Número cliente debe ser numérico de largo 4" + "</error>");
	        	_unidad = "00000";
	        }
	    }
    	private string _unidad;
    	
    	public string numero_caja
	    {
	        get { return _numero_caja; }
	        set
	        {
	        	int  _numero_caja_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                throw new ArgumentException("Valor no puede ser vacio");
	        	if (!int.TryParse(value, out _numero_caja_paso))
	            	throw new ArgumentException("valor debe ser un numero");
	        	_numero_caja = "000";
	        }
	    }
    	private string _numero_caja;
    	
    	public string numero_paquete
	    {
	        get { return _numero_paquete; }
	        set
	        {
	        	int  _numero_paquete_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                throw new ArgumentException("Valor no puede ser vacio");
	        	if (!int.TryParse(value, out _numero_paquete_paso))
	            	throw new ArgumentException("valor debe ser un numero");
	        	_numero_paquete = "00000";
	        }
	    }
    	private string _numero_paquete;
    	
    	
    	
    	
    	public string retorna_registro_tipo_1_3(int anodj)
    	{
    		if (anodj == 2023)
    		{
	    		string salida = this.tipo_registro + this.determina_orden_preced + this.codigo_pais + this.cod_area_ciudad + this.telefono 
	    			+ this.codigo_empresa + this.numero_cliente + this.unidad + this.numero_caja + this.numero_paquete;
	
	    		return salida + "".PadRight(308);
    		}else
    		{
    			errores.escribir_error("<error>" + "DDJJ 1887" + ";" + "retorna_registro_tipo_1_2" + ";" + "año no soportado para esta version" + "</error>");
    			return "";
    		}
    	}
    	
	}

	
}
