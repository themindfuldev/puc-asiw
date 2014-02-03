﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.488
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cadastro.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Endereco", Namespace="http://schemas.datacontract.org/2004/07/WcfCepService")]
    [System.SerializableAttribute()]
    public partial class Endereco : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BairroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CepField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescricaoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ErroIndicadorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LogradouroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MunicipioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal NumeroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TipoLogradouroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UfField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Bairro {
            get {
                return this.BairroField;
            }
            set {
                if ((object.ReferenceEquals(this.BairroField, value) != true)) {
                    this.BairroField = value;
                    this.RaisePropertyChanged("Bairro");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Cep {
            get {
                return this.CepField;
            }
            set {
                if ((object.ReferenceEquals(this.CepField, value) != true)) {
                    this.CepField = value;
                    this.RaisePropertyChanged("Cep");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Descricao {
            get {
                return this.DescricaoField;
            }
            set {
                if ((object.ReferenceEquals(this.DescricaoField, value) != true)) {
                    this.DescricaoField = value;
                    this.RaisePropertyChanged("Descricao");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ErroIndicador {
            get {
                return this.ErroIndicadorField;
            }
            set {
                if ((this.ErroIndicadorField.Equals(value) != true)) {
                    this.ErroIndicadorField = value;
                    this.RaisePropertyChanged("ErroIndicador");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Logradouro {
            get {
                return this.LogradouroField;
            }
            set {
                if ((object.ReferenceEquals(this.LogradouroField, value) != true)) {
                    this.LogradouroField = value;
                    this.RaisePropertyChanged("Logradouro");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Municipio {
            get {
                return this.MunicipioField;
            }
            set {
                if ((object.ReferenceEquals(this.MunicipioField, value) != true)) {
                    this.MunicipioField = value;
                    this.RaisePropertyChanged("Municipio");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Numero {
            get {
                return this.NumeroField;
            }
            set {
                if ((this.NumeroField.Equals(value) != true)) {
                    this.NumeroField = value;
                    this.RaisePropertyChanged("Numero");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TipoLogradouro {
            get {
                return this.TipoLogradouroField;
            }
            set {
                if ((object.ReferenceEquals(this.TipoLogradouroField, value) != true)) {
                    this.TipoLogradouroField = value;
                    this.RaisePropertyChanged("TipoLogradouro");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Uf {
            get {
                return this.UfField;
            }
            set {
                if ((object.ReferenceEquals(this.UfField, value) != true)) {
                    this.UfField = value;
                    this.RaisePropertyChanged("Uf");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ObterCep", ReplyAction="http://tempuri.org/IService1/ObterCepResponse")]
        Cadastro.ServiceReference1.Endereco ObterCep(string cep);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Cadastro.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Cadastro.ServiceReference1.IService1>, Cadastro.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Cadastro.ServiceReference1.Endereco ObterCep(string cep) {
            return base.Channel.ObterCep(cep);
        }
    }
}