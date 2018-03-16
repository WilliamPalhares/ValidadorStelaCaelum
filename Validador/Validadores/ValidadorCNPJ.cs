using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caelum.Stella.CSharp.Format;
using Caelum.Stella.CSharp.Validation;

namespace Validador.Validadores
{
    public class ValidadorCNPJ
    {
        public void ValidarCNPJ(string CNPJ)
        {
            try
            {
                new CNPJValidator().AssertValid(CNPJ);
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("CNPJ inválido: {0} - {1}", CNPJ, ex.Message), ex);
            }
        }

        public string FormatarCPNJ(string CNPJ)
        {
            try
            {
                return new CNPJFormatter().Format(CNPJ);
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("CNPJ inválido: {0} - {1}", CNPJ, ex.Message), ex);
            }
        }

        public string RetirarFormatacaoCNPJ(string CNPJ)
        {
            try
            {
                return new CNPJFormatter().Unformat(CNPJ);
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("CNPJ inválido: {0} - {1}", CNPJ, ex.Message), ex);
            }
        }
    }
}
