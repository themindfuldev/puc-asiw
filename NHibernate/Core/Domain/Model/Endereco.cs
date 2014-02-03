using System;
using System.Collections.Generic;

namespace Core.Domain.Model
{
	public class Endereco
	{
		#region Private Members
		private decimal idEndereco ;
		private string logradouro = String.Empty;
		private string bairro = String.Empty;
		private string numero = String.Empty;
		private string complemento = String.Empty;
		private string cEP = String.Empty;
		private string cidade = String.Empty;
		private string estado = String.Empty;
		private string pais = String.Empty;
		private Pessoa idPessoa;		
		#endregion
		
		
		#region Private List Members		
		#endregion
		
		
		#region Constructor
		public Endereco()
		{
		}
		#endregion
		
		
		#region Public Properties
			
		/// <summary>
		/// 
		/// </summary>		
		public virtual decimal IdEndereco
		{
			get { return idEndereco; }
			set { idEndereco = value; }
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public virtual string Logradouro
		{
			get { return logradouro; }
			set	
			{
				if( value != null && value.Length > 512)
					throw new ArgumentOutOfRangeException("Capacidade excedida para Logradouro", value, value.ToString());
				
				logradouro = value;
			}
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public virtual string Bairro
		{
			get { return bairro; }
			set	
			{
				if( value != null && value.Length > 256)
					throw new ArgumentOutOfRangeException("Capacidade excedida para Bairro", value, value.ToString());
				
				bairro = value;
			}
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public virtual string Numero
		{
			get { return numero; }
			set	
			{
				if( value != null && value.Length > 20)
					throw new ArgumentOutOfRangeException("Capacidade excedida para Numero", value, value.ToString());
				
				numero = value;
			}
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public virtual string Complemento
		{
			get { return complemento; }
			set	
			{
				if( value != null && value.Length > 256)
					throw new ArgumentOutOfRangeException("Capacidade excedida para Complemento", value, value.ToString());
				
				complemento = value;
			}
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public virtual string Cep
		{
			get { return cEP; }
			set	
			{
				if( value != null && value.Length > 10)
					throw new ArgumentOutOfRangeException("Capacidade excedida para Cep", value, value.ToString());
				
				cEP = value;
			}
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public virtual string Cidade
		{
			get { return cidade; }
			set	
			{
				if( value != null && value.Length > 100)
					throw new ArgumentOutOfRangeException("Capacidade excedida para Cidade", value, value.ToString());
				
				cidade = value;
			}
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public virtual string Estado
		{
			get { return estado; }
			set	
			{
				if( value != null && value.Length > 100)
					throw new ArgumentOutOfRangeException("Capacidade excedida para Estado", value, value.ToString());
				
				estado = value;
			}
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public virtual string Pais
		{
			get { return pais; }
			set	
			{
				if( value != null && value.Length > 256)
					throw new ArgumentOutOfRangeException("Capacidade excedida para Pais", value, value.ToString());
				
				pais = value;
			}
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public virtual Pessoa Pessoa
		{
			get { return idPessoa; }
			set { idPessoa = value; }
		}
					
		#endregion 
		
		
		#region Public List Properties
					
		#endregion
		
		
		#region Public Functions
        
		#endregion
		
		
		#region Equals And HashCode Overrides
		/// <summary>
		/// local implementation of Equals based on unique value members
		/// </summary>
		public override bool Equals( object obj )
		{
			if( this == obj ) return true;
			if( obj == null ) return false;
			Endereco castObj = (Endereco)obj; 
			return ( castObj != null ) &&
				( this.idEndereco == castObj.IdEndereco );
		}
		
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			
			int hash = 57; 
			hash = 27 * hash * idEndereco.GetHashCode();
			return hash; 
		}
		#endregion
			
		
	}
}
