/*
 * Created by SharpDevelop.
 * User: rjc
 * Date: 28-12-2022
 * Time: 12:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace DDJJ1887
{
	/// <summary>
	/// Description of RegistroTipo0.
	/// </summary>
	public class registrotipo0
	{	
		//pasa por referencia la clase de errores para usarla en todas las clases
		//registro 0 al 3
		public static errores errores  {get; set;}
		
		
		
		
		public registrotipo0 ()
		{
			//inicializa todas las constantes de la clase
			checksum_sii = "0000000000";
			checksum_declarante = "0000000000";
			numero_version = "13";
			numero_version = "00000000";
		}
	
		public string tipo_registro
	    {
	        get { return _tipo_registro; }
	        set
	        {
	        	int _tipo_registro_paso = 0;
	        	if (string.IsNullOrEmpty(value.ToString()))
	                errores.escribir_error("<error>" + "Registro tipo 0" + ";" + "Tipo Registro" + ";" + "valor no puede ser vacio" + "</error>");
	        	if (value.Length != 1)
	        		errores.escribir_error("<error>" + "Registro tipo 0" + ";" + "Tipo Registro" + ";" + "valor debe ser un numero de un digito" + "</error>");
	        	if (!int.TryParse(value, out _tipo_registro_paso))
	        	{
	        		errores.escribir_error("<error>" + "Registro tipo 0" + ";" + "Tipo Registro" + ";" + "valor debe ser un numero" + "</error>");
	        	}
	        	if ( _tipo_registro_paso != 0)
	        	{
	        		errores.escribir_error("<error>" + "Registro tipo 0" + ";" + "Tipo Registro" + ";" + "valor debe ser el numero 0" + "</error>");
	        	}
	        	
	        	_tipo_registro = _tipo_registro_paso.ToString();
	        }
	    }
    	private string _tipo_registro;
    	
     	public string ano_tributario
	    {
	        get { return _ano_tributario; }
	        set
	        {
	        	int _ano_tributario_paso = 0;
	        	if (string.IsNullOrEmpty(value.ToString()))
	               errores.escribir_error("<error>" + "Registro tipo 0" + ";" + "Año tributario" + ";" + "valor no puede ser vacio" + "</error>");
	        	if (!int.TryParse(value, out _ano_tributario_paso))
	            	errores.escribir_error("<error>" + "Registro tipo 0" + ";" + "Año tributario" + ";" + "valor no puede ser numérico" + "</error>");
	        	if ( _ano_tributario_paso != 2023)
	        	{
	        		errores.escribir_error("<error>" + "Registro tipo 0" + ";" + "Tipo Registro" + ";" + "valor debe ser el el año 2023" + "</error>");
	        	}
	        	
	        	
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
	               errores.escribir_error("<error>" + "Registro tipo 0" + ";" + "Número de Formulario" + ";" + "valor no puede ser vacio" + "</error>");
	        	if (!int.TryParse(value, out _numero_formulario_paso))
	            	errores.escribir_error("<error>" + "Registro tipo 0" + ";" + "Número de Formulario" + ";" + "valor debe ser numérico" + "</error>");
	        	if ( _numero_formulario_paso != 1887)
	        		errores.escribir_error("<error>" + "Registro tipo 0" + ";" + "Número de Formulario" + ";" + "valor debe ser el formulario 1887" + "</error>");
	        	_numero_formulario = _numero_formulario_paso.ToString();
	        }
	    }
    	private string _numero_formulario;
    	
      	public string numero_rut
	    {
	        get { return _numero_rut; }
	        set
	        {
	        	int _numero_rut_paso = 0;
	        	if (string.IsNullOrEmpty(value.ToString()))
	                errores.escribir_error("<error>" + "Registro tipo 0" + ";" + "Número de RUT" + ";" + "valor no puede ser vacio" + "</error>");
	        	if (!int.TryParse(value, out _numero_rut_paso))
	            	errores.escribir_error("<error>" + "Registro tipo 0" + ";" + "Número de RUT" + ";" + "valor debe ser un numero mayor a cero" + "</error>");
	        	
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
	                errores.escribir_error("<error>" + "Registro tipo 0" + ";" + "Digito Verificador" + ";" + "valor no puede ser vacio" + "</error>");
	        	if (value.Length !=1)
	        		errores.escribir_error("<error>" + "Registro tipo 0" + ";" + "Digito Verificador" + ";" + "valor debe ser un caracter" + "</error>");
	        	if (value != validaciones.Digito (int.Parse( numero_rut)))
	        		errores.escribir_error("<error>" + "Registro tipo 0" + ";" + "Digito Verificador" + ";" + "Rut invalido, error en  Digito Verrificador" + "</error>");
	        	_digito_verificador = value;
	        }
	    }
    	private string _digito_verificador;
    	
      	public string total_registros
	    {
	        get { return _total_registros; }
	        
	        set
	        {
	        	int _total_registros_paso = 0;
	        	if (string.IsNullOrEmpty(value.ToString()))
	                 errores.escribir_error("<error>" + "Registro tipo 0" + ";" + "Total Registros" + ";" + "valor no puede ser vacio" + "</error>");
	        	if (!int.TryParse(value, out _total_registros_paso))
	            	 errores.escribir_error("<error>" + "Registro tipo 0" + ";" + "Total Registros" + ";" + "valor debe ser numerico" + "</error>");
	        	if (_total_registros_paso < 1)
	        		errores.escribir_error("<error>" + "Registro tipo 0" + ";" + "Total Registros" + ";" + "valor debe ser numerico mayor a cero" + "</error>");
	        	_total_registros = _total_registros_paso.ToString().PadLeft(7, '0');
	        }
	    }
    	private string _total_registros;
    	
    	public string codigo_empresa
	    {
      		//verificar validación
	        get { return _codigo_empresa; }
	        set
	        {
	        	int _codigo_empresa_paso = 0;
	        	if (string.IsNullOrEmpty(value.ToString()))
	                errores.escribir_error("<error>" + "Registro tipo 0" + ";" + "Código Empresa" + ";" + "valor no puede ser vacio" + "</error>");
	        	if (!int.TryParse(value, out _codigo_empresa_paso) || value.Length != 2 )
	            	 errores.escribir_error("<error>" + "Registro tipo 0" + ";" + "Código Empresa" + ";" + "valor debe ser numerico de largo 2" + "</error>");
	        	if (value == "74" )
	            	 errores.escribir_error("<error>" + "Registro tipo 0" + ";" + "Código Empresa" + ";" + "valor debe ser 74" + "</error>");
	        	_codigo_empresa = value;
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
	                errores.escribir_error("<error>" + "Registro tipo 0" + ";" + "Número Cliente" + ";" + "valor no puede ser vacio" + "</error>");
	        	if (!int.TryParse(value, out _numero_cliente_paso) || value.Length != 4 )
	            	 errores.escribir_error("<error>" + "Registro tipo 0" + ";" + "Código Empresa" + ";" + "valor debe ser numerico de largo 4" + "</error>");
	        	 _numero_cliente = value;
	        }
	    }
    	private string _numero_cliente;
    	
    	public string checksum_declarante
	    {
	        get { return _checksum_declarante; }
	        set
	        {
	        	int _checksum_declarante_paso = 0;
	        	if (string.IsNullOrEmpty(value.ToString())  )
	                errores.escribir_error("<error>" + "Registro tipo 0" + ";" + "Checksum Declarante" + ";" + "valor no puede ser vacio" + "</error>");
	        	if (!int.TryParse(value, out _checksum_declarante_paso) )
	            	 errores.escribir_error("<error>" + "Registro tipo 0" + ";" + "Checksum Declarante" + ";" + "valor debe ser numerico " + "</error>");
	        	_checksum_declarante = value;
	        }
	    }
    	private string _checksum_declarante;
    	
    	public string checksum_sii
	    {
	        get { return _checksum_sii; }
	        set
	        {
	        	int checksum_sii_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                errores.escribir_error("<error>" + "Registro tipo 0" + ";" + "Checksum SII" + ";" + "valor no puede ser vacio" + "</error>");
	        	if (!int.TryParse(value, out checksum_sii_paso) )
	            	 errores.escribir_error("<error>" + "Registro tipo 0" + ";" + "Checksum SII" + ";" + "valor debe ser numerico " + "</error>");
	        	_checksum_sii = value;
	        }
	    }
    	private string _checksum_sii;
    	
     	public string codigo_prestacion
	    {
	        get { return _codigo_prestacion; }
	        set
	        {
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                errores.escribir_error("<error>" + "Registro tipo 0" + ";" + "Código Prestación" + ";" + "valor no puede ser vacio" + "</error>");
	        	if (value != "I")
	                errores.escribir_error("<error>" + "Registro tipo 0" + ";" + "Código Prestación" + ";" + "valor debe ser la letra I" + "</error>");
	        	_codigo_prestacion = value;
	        }
	    }
    	private string _codigo_prestacion;
    	
    	public string tipo_declaracion
	    {
	        get { return _tipo_declaracion; }
	        set
	        {
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                errores.escribir_error("<error>" + "Registro tipo 0" + ";" + "Tipo de Declaración" + ";" + "valor no puede ser vacio" + "</error>");
	        	if (value != "O" && value != "R")
	                errores.escribir_error("<error>" + "Registro tipo 0" + ";" + "Código Prestación" + ";" + "valor debe ser la letra I" + "</error>");
	        	_tipo_declaracion = value;
	        }
	    }
    	private string _tipo_declaracion;
    	
     	public string folio
	    {
	        get { return _folio; }
	        set
	        {
	        	
	        	
	        	int _folio_paso = 0;
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                errores.escribir_error("<error>" + "Registro tipo 0" + ";" + "Folio" + ";" + "valor no puede ser vacio" + "</error>");
	        	if (!int.TryParse(value, out _folio_paso) )
	            	errores.escribir_error("<error>" + "Registro tipo 0" + ";" + "Folio" + ";" + "valor debe ser numerico" + "</error>");
	        	if (_folio_paso < 1 )
	        		errores.escribir_error("<error>" + "Registro tipo 0" + ";" + "Folio" + ";" + "valor debe ser numerico mayor a cero" + "</error>");
	        	_folio = _folio_paso.ToString().PadLeft(7,'0');
	        }
	    }
    	private string _folio;
    	
    	public string dia
	    {
	        get { return _dia; }
	        set
	        {
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                throw new ArgumentException("Valor no puede ser vacio");
//	        	if (!int.TryParse(s, out _dia))
//	            	throw new ArgumentException("valor debe ser un numero");
	        	_dia = value;
	        }
	    }
    	private string _dia;
    	
    	public string mes
	    {
	        get { return _mes; }
	        set
	        {
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                throw new ArgumentException("Valor no puede ser vacio");
//	        	if (!int.TryParse(s, out _mes))
//	            	throw new ArgumentException("valor debe ser un numero");
	        	_mes = value;
	        }
	    }
    	private string _mes;
    	
    	public string ano
	    {
	        get { return _ano; }
	        set
	        {
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                throw new ArgumentException("Valor no puede ser vacio");
//	        	if (!int.TryParse(s, out _ano))
//	            	throw new ArgumentException("valor debe ser un numero");
	        	_ano = value;
	        }
	    }
    	private string _ano;
    	
       	public string hora
	    {
	        get { return _hora; }
	        set
	        {
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                throw new ArgumentException("Valor no puede ser vacio");
//	        	if (!int.TryParse(s, out _hora))
//	            	throw new ArgumentException("valor debe ser un numero");
	        	_hora = value;
	        }
	    }
    	private string _hora;
    	
    	public string minuto
	    {
	        get { return _minuto; }
	        set
	        {
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                throw new ArgumentException("Valor no puede ser vacio");
//	        	if (!int.TryParse(s, out _minuto))
//	            	throw new ArgumentException("valor debe ser un numero");
	        	_minuto = value;
	        }
	    }
    	private string _minuto;
    	
    	public string segundo
	    {
	        get { return _segundo; }
	        set
	        {
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                throw new ArgumentException("Valor no puede ser vacio");
//	        	if (!int.TryParse(s, out _segundo))
//	            	throw new ArgumentException("valor debe ser un numero");
	        	_segundo = value;
	        }
	    }
    	private string _segundo;
    	
    	public string numero_version
	    {
	        get { return _numero_version; }
	        set
	        {
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                throw new ArgumentException("Valor no puede ser vacio");
//	        	if (!int.TryParse(s, out _numero_version))
//	            	throw new ArgumentException("valor debe ser un numero");
	        	_numero_version = value;
	        }
	    }
    	private string _numero_version;
    	
    	public string numero_atencion
	    {
	        get { return _numero_atencion; }
	        set
	        {
	        	if (string.IsNullOrWhiteSpace(value.ToString()))
	                throw new ArgumentException("Valor no puede ser vacio");
//	        	if (!int.TryParse(s, out _numero_atencion))
//	            	throw new ArgumentException("valor debe ser un numero");
	        	_numero_atencion = value.PadLeft(8,'0');
	        }
	    }
    	private string _numero_atencion;
    	
    	//retorna la linea del registro completo
    	public string retorna_registro_tipo_0(int anodj)
    	{
     		if (anodj == 2023)
    		{
		    		string salida = this.tipo_registro + this.ano_tributario + this.numero_formulario
		    						+ this.numero_rut + this.digito_verificador + this.total_registros + this.codigo_empresa + this.numero_cliente 
									+ this.checksum_declarante + this.checksum_sii + this._codigo_prestacion + this._tipo_declaracion + this.folio + this.dia
									+ this.mes + this.ano +     this.hora + this.minuto + this.segundo + this.numero_atencion + this.numero_atencion			;
		    		return salida + "".PadRight(341 - salida.Length);
    		}else
    		{
    		
    			errores.escribir_error("<error>" + "Registro tipo 0" + ";" + "Retorna registro" + ";" + "Año no soportado por version actual" + "</error>");
    			return "";
    		}
    	}
    	
	}
	
}
