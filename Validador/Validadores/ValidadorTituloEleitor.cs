using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caelum.Stella.CSharp.Format;
using Caelum.Stella.CSharp.Validation;

namespace Validador.Validadores
{
    public class ValidadorTituloEleitor
    {
        public void ValidarTituloEleitor(string Titulo)
        {
            try
            {
                new TituloEleitoralValidator().AssertValid(Titulo);
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("Titulo Eleitor inválido: {0} - {1}", Titulo, ex.Message), ex);
            }
        }

        public string FormatarTituloEleitor(string Titulo)
        {
            try
            {
                return new TituloEleitoralFormatter().Format(Titulo);
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("Titulo Eleitor inválido: {0} - {1}", Titulo, ex.Message), ex);
            }
        }

        public string RetirarFormatacaoTituloEleitor(string Titulo)
        {
            try
            {
                return new TituloEleitoralFormatter().Unformat(Titulo);
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("Titulo Eleitor inválido: {0} - {1}", Titulo, ex.Message), ex);
            }
        }
    }
}
