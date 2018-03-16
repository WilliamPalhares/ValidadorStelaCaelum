using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caelum.Stella.CSharp.Inwords;
using Caelum.Stella.CSharp.Vault;

namespace Validador.Validadores
{
    public class ValidadorMoney
    {
        public string ValorPorExtenso(double valor)
        {
            try
            {
                return new MoedaBRL(valor).Extenso();
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("Valor inválido: {0} - {1}", valor, ex.Message), ex);
            }
        }

        public string FormatarValorMoney(double valor)
        {
            Money money;

            try
            {
                money = valor;

                return money.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("Valor inválido: {0} - {1}", valor, ex.Message), ex);
            }
        }

        public string FormatarValorMoney(decimal valor)
        {
            Money money;

            try
            {
                money = valor;

                return money.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("Valor inválido: {0} - {1}", valor, ex.Message), ex);
            }
        }
    }
}
