using System;
using System.Collections.Generic;

namespace Core.Domain.Model
{
	public class HistoricoAcademico
	{
		#region Private Members
		private decimal idHistoricoAcademico ;
		private string curso = String.Empty;
		private string instituicao = String.Empty;
		private DateTime? dataInicio ;
		private DateTime? dataFim ;
		private Pessoa idPessoa;
        private float nota;
        private float presenca;
		#endregion
		
		
		#region Private List Members		
		#endregion
		
		
		#region Constructor
		public HistoricoAcademico()
		{
		}
		#endregion
		
		
		#region Public Properties
			
		/// <summary>
		/// 
		/// </summary>		
		public virtual decimal IdHistoricoAcademico
		{
			get { return idHistoricoAcademico; }
			set { idHistoricoAcademico = value; }
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public virtual string Curso
		{
			get { return curso; }
			set	
			{
				if( value != null && value.Length > 512)
					throw new ArgumentOutOfRangeException("Capacidade excedida para Curso", value, value.ToString());
				
				curso = value;
			}
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public virtual string Instituicao
		{
			get { return instituicao; }
			set	
			{
				if( value != null && value.Length > 512)
					throw new ArgumentOutOfRangeException("Capacidade excedida para Instituicao", value, value.ToString());
				
				instituicao = value;
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
		public virtual Pessoa Pessoa
		{
			get { return idPessoa; }
			set { idPessoa = value; }
		}

        /// <summary>
        /// 
        /// </summary>		
        public virtual float Nota
        {
            get { return nota; }
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentOutOfRangeException("Capacidade excedida para Nota", value, value.ToString());

                nota = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public virtual float Presenca
        {
            get { return presenca; }
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentOutOfRangeException("Capacidade excedida para Presenca", value, value.ToString());

                presenca = value;
            }
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
			HistoricoAcademico castObj = (HistoricoAcademico)obj; 
			return ( castObj != null ) &&
				( this.idHistoricoAcademico == castObj.IdHistoricoAcademico );
		}
		
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			
			int hash = 57; 
			hash = 27 * hash * idHistoricoAcademico.GetHashCode();
			return hash; 
		}
		#endregion
			
		
	}
}
