using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validador.Validadores
{
    public class ValidadorDatas
    {
        public string TratamentoData(string Data)
        {
            try
            {
                return DateTime.Parse(Data).ToString("dd/MM/yyyy HH:mm:ss");
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("Data inválida: {0} - {1}", Data, ex.Message), ex);
            }
        }
    }
}
