using System.Runtime.Serialization;
using System.ServiceModel;

namespace WcfCepService
{

    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        Endereco ObterCep(string cep);
    }

    [DataContract]
    public class Endereco
    {
        [DataMember]
        public int ErroIndicador { get; set; }
        [DataMember]
        public string Descricao { get; set; }
        [DataMember]
        public string Logradouro { get; set; }
        [DataMember]
        public decimal Numero { get; set; }
        [DataMember]
        public string Cep { get; set; }
        [DataMember]
        public string Bairro { get; set; }
        [DataMember]
        public string Uf { get; set; }
        [DataMember]
        public string Municipio { get; set; }
        [DataMember]
        public string TipoLogradouro { get; set; }
    }
}
