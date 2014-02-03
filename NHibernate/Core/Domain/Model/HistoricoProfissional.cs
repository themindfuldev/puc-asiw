using System;
using System.Collections.Generic;

namespace Core.Domain.Model
{
	public class HistoricoProfissional
	{
		#region Private Members
		private decimal idHistoricoProfissiona ;
		private string empresa = String.Empty;
		private string cargo = String.Empty;
		private DateTime? dataInicio ;
		private DateTime? dataFim ;
		private string habilidadesIntraPessoais = String.Empty;
		private string habilidadesTecnicas = String.Empty;
		private Pessoa idPessoa;		
		#endregion
		
		
		#region Private List Members		
		#endregion
		
		
		#region Constructor
		public HistoricoProfissional()
		{
		}
		#endregion
		
		
		#region Public Properties
			
		/// <summary>
		/// 
		/// </summary>		
		public virtual decimal IdHistoricoProfissiona
		{
			get { return idHistoricoProfissiona; }
			set { idHistoricoProfissiona = value; }
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public virtual string Empresa
		{
			get { return empresa; }
			set	
			{
				if( value != null && value.Length > 256)
					throw new ArgumentOutOfRangeException("Capacidade excedida para Empresa", value, value.ToString());
				
				empresa = value;
			}
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public virtual string Cargo
		{
			get { return cargo; }
			set	
			{
				if( value != null && value.Length > 512)
					throw new ArgumentOutOfRangeException("Capacidade excedida para Cargo", value, value.ToString());
				
				cargo = value;
			}
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public virtual DateTime? DataInicio
		{
			get { return dataInicio; }
			set { dataInicio = value; }
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public virtual DateTime? DataFim
		{
			get { return dataFim; }
			set { dataFim = value; }
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public virtual string HabilidadesIntraPessoais
		{
			get { return habilidadesIntraPessoais; }
			set	
			{
				if( value != null && value.Length > 512)
					throw new ArgumentOutOfRangeException("Capacidade excedida para HabilidadesIntraPessoais", value, value.ToString());
				
				habilidadesIntraPessoais = value;
			}
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public virtual string HabilidadesTecnicas
		{
			get { return habilidadesTecnicas; }
			set	
			{
				if( value != null && value.Length > 512)
					throw new ArgumentOutOfRangeException("Capacidade excedida para HabilidadesTecnicas", value, value.ToString());
				
				habilidadesTecnicas = value;
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
			HistoricoProfissional castObj = (HistoricoProfissional)obj; 
			return ( castObj != null ) &&
				( this.idHistoricoProfissiona == castObj.IdHistoricoProfissiona );
		}
		
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			
			int hash = 57; 
			hash = 27 * hash * idHistoricoProfissiona.GetHashCode();
			return hash; 
		}
		#endregion
			
		
	}
}
