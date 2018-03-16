using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Net.Http;
using Newtonsoft.Json;
using Caelum.Stella.CSharp.Format;
using Caelum.Stella.CSharp.Http;

namespace Validador.Validadores
{
    public class ValidadorCEP
    {
        public string GetEnderecoCompleto(string CEP)
        {
            string result = string.Empty;

            try
            {
                ViaCEP viaCEP = new ViaCEP();
                result = viaCEP.GetEnderecoJson(CEP);
                
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("CEP {0} informado é inválido", CEP), ex);
            }
        }

        public string FormatarCep(string CEP)
        {
            try
            {
                GetEnderecoCompleto(CEP);
                return new CEPFormatter().Format(CEP);
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("CEP {0} informado é inválido", CEP), ex);
            }
        }

        public string RetirarFormatacaoCep(string CEP)
        {
            try
            {
                GetEnderecoCompleto(CEP);
                return new CEPFormatter().Unformat(CEP);
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("CEP {0} informado é inválido", CEP), ex);
            }
        }
    }
}
