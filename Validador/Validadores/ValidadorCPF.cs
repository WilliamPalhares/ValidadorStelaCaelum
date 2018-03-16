using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caelum.Stella.CSharp.Format;
using Caelum.Stella.CSharp.Validation;

namespace Validador.Validadores
{
    public class ValidadorCPF
    {
        public void ValidarCPF(string CPF)
        {
            try
            {
                new CPFValidator().AssertValid(CPF);
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("CPF inválido: {0} - {1}", CPF, ex.Message), ex);
            }
        }

        public string FormatarCPF(string CPF)
        {
            try
            {
                return new CPFFormatter().Format(CPF);
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("CPF inválido: {0} - {1}", CPF, ex.Message), ex);
            }
        }

        public string RetirarFormatacaoCPF(string CPF)
        {
            try
            {
                return new CPFFormatter().Unformat(CPF);
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("CPF inválido: {0} - {1}", CPF, ex.Message), ex);
            }
        }
    }
}
