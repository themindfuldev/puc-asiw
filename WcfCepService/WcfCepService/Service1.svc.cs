using System;
using System.Collections;
using System.Configuration;
using System.Net;
using WcfCepService.ByJgCep;

namespace WcfCepService
{
    public class Service1 : IService1
    {
        public Endereco ObterCep(string cep)
        {
            try
            {
                var cepService = new CEPService();
                ObterConfiguracoesProxy(cepService);
                var responseWs = cepService.obterLogradouroAuth(cep, ConfigurationManager.AppSettings["CepServiceUsername"], ConfigurationManager.AppSettings["CepServicePassword"]);
                return ObterObjetoEndereco(cep, responseWs);
            }
            catch (Exception ex)
            {
                var endereco = new Endereco
                {
                    Logradouro = "Rua dos Bobos",
                    Municipio = "Município Qualquer",
                    Uf = "MG",
                    Cep = cep,
                    Bairro = "Bairro X",
                    TipoLogradouro = "Rua",
                    ErroIndicador = 0,
                    Descricao = "Ocorreu problema e foi enviado o endereço padrão" + ex.Message,
                };

                return endereco;
            }
        }

        private static Endereco ObterObjetoEndereco(string cep, string responseWs)
        {
            var logradouro = string.Empty;
            var bairro = string.Empty;
            var cidade = string.Empty;
            var uf = string.Empty;

            IList arr = responseWs.Split(',');

            for (var a = 0; a < 4; a++)
            {
                if (arr[0].ToString().ToLower().Contains("não encontrado"))
                    throw new Exception(arr[0].ToString());

                switch (a)
                {
                    case (0):
                        logradouro = arr[0].ToString().Trim();
                        break;
                    case (1):
                        bairro = arr[1].ToString().Trim();
                        break;
                    case (2):
                        cidade = arr[2].ToString().Trim();
                        break;
                    case (3):
                        uf = arr[3].ToString().Trim();
                        break;
                }
            }

            var endereco = new Endereco
                               {
                                   Logradouro = logradouro.Substring(logradouro.IndexOf(" ")).Trim(),
                                   Municipio = cidade,
                                   Uf = uf,
                                   Cep = cep,
                                   Bairro = bairro,
                                   TipoLogradouro = logradouro.Remove(logradouro.IndexOf(" ")).Trim(),
                                   ErroIndicador = 0,
                                   Descricao = "Consulta Realizada Com Sucesso",
                               };
            return endereco;
        }

        private static void ObterConfiguracoesProxy(CEPService cepService)
        {
            //Implementação do acesso via Proxy
            if (ConfigurationManager.AppSettings["ProxyHabilitado"].Equals("S"))
            {
                //Configura as credenciais
                var credential = new NetworkCredential
                                     {
                                         UserName = ConfigurationManager.AppSettings["ProxyUserName"],
                                         Password = ConfigurationManager.AppSettings["ProxyPassword"],
                                     };

                //Configura as informações do proxy
                var proxy = new WebProxy
                                {
                                    Address = new Uri(ConfigurationManager.AppSettings["ProxyAddress"]),
                                    Credentials = credential
                                };

                //Informa para o request os dados para acesso ao proxy
                cepService.Proxy = proxy;
            }
            else
            {
                //Acesso com as configurações padrões de autenticaçãos
                cepService.Credentials = CredentialCache.DefaultCredentials;
            }
        }
    }
}
