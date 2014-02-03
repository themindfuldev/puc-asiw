using System;
using System.Collections.Generic;

namespace Core.Domain.Model
{
    public class Pessoa
    {
        #region Private Members
        private decimal idPessoa;
        private string nome = String.Empty;
        private string nomeMae = String.Empty;
        private string nomePai = String.Empty;
        private DateTime? dataNascimento;
        private string rG = String.Empty;
        private string cPF = String.Empty;
        private bool estrangeiro;
        private string identificacaoEstrangeiro = String.Empty;
        #endregion


        #region Private List Members
        private IList<Endereco> _EnderecoList;
        private IList<HistoricoAcademico> _HistoricoAcademicoList;
        private IList<HistoricoProfissional> _HistoricoProfissionalList;
        #endregion


        #region Constructor
        public Pessoa()
        {
            _EnderecoList = new List<Endereco>();
            _HistoricoAcademicoList = new List<HistoricoAcademico>();
            _HistoricoProfissionalList = new List<HistoricoProfissional>();
        }
        #endregion


        #region Public Properties

        /// <summary>
        /// 
        /// </summary>		
        public virtual decimal IdPessoa
        {
            get { return idPessoa; }
            set { idPessoa = value; }
        }

        /// <summary>
        /// 
        /// </summary>		
        public virtual string Nome
        {
            get { return nome; }
            set
            {
                if (value != null && value.Length > 256)
                    throw new ArgumentOutOfRangeException("Capacidade excedida para Nome", value, value.ToString());

                nome = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public virtual string NomeMae
        {
            get { return nomeMae; }
            set
            {
                if (value != null && value.Length > 256)
                    throw new ArgumentOutOfRangeException("Capacidade excedida para NomeMae", value, value.ToString());

                nomeMae = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public virtual string NomePai
        {
            get { return nomePai; }
            set
            {
                if (value != null && value.Length > 256)
                    throw new ArgumentOutOfRangeException("Capacidade excedida para NomePai", value, value.ToString());

                nomePai = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public virtual DateTime? DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
        }

        /// <summary>
        /// 
        /// </summary>		
        public virtual string Rg
        {
            get { return rG; }
            set
            {
                if (value != null && value.Length > 100)
                    throw new ArgumentOutOfRangeException("Capacidade excedida para Rg", value, value.ToString());

                rG = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public virtual string Cpf
        {
            get { return cPF; }
            set
            {
                if (value != null && value.Length > 20)
                    throw new ArgumentOutOfRangeException("Capacidade excedida para Cpf", value, value.ToString());

                cPF = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public virtual bool Estrangeiro
        {
            get { return estrangeiro; }
            set
            {

                estrangeiro = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public virtual string IdentificacaoEstrangeiro
        {
            get { return identificacaoEstrangeiro; }
            set
            {
                if (value != null && value.Length > 256)
                    throw new ArgumentOutOfRangeException("Capacidade excedida para IdentificacaoEstrangeiro", value, value.ToString());

                identificacaoEstrangeiro = value;
            }
        }

        #endregion


        #region Public List Properties

        public virtual IList<Endereco> EnderecoList
        {
            get
            {
                return _EnderecoList;
            }
            set
            {
                _EnderecoList = value;
            }
        }

        public virtual IList<HistoricoAcademico> HistoricoAcademicoList
        {
            get
            {
                return _HistoricoAcademicoList;
            }
            set
            {
                _HistoricoAcademicoList = value;
            }
        }

        public virtual IList<HistoricoProfissional> HistoricoProfissionalList
        {
            get
            {
                return _HistoricoProfissionalList;
            }
            set
            {
                _HistoricoProfissionalList = value;
            }
        }

        #endregion


        #region Public Functions

        #endregion


        #region Equals And HashCode Overrides
        /// <summary>
        /// local implementation of Equals based on unique value members
        /// </summary>
        public override bool Equals(object obj)
        {
            if (this == obj) return true;
            if (obj == null) return false;
            Pessoa castObj = (Pessoa)obj;
            return (castObj != null) &&
                (this.idPessoa == castObj.IdPessoa);
        }

        /// <summary>
        /// local implementation of GetHashCode based on unique value members
        /// </summary>
        public override int GetHashCode()
        {

            int hash = 57;
            hash = 27 * hash * idPessoa.GetHashCode();
            return hash;
        }
        #endregion


    }
}
