using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Validador.Validadores;

namespace TesteValidador.Validadores
{
    [TestClass]
    public class Validadores
    {
        #region Teste de CPF

        [TestMethod]
        public void CPFValido()
        {
            string CPF = "37400260227";
            ValidadorCPF validadorCPF = null;

            try
            {
                validadorCPF = new ValidadorCPF();
                validadorCPF.ValidarCPF(CPF);
                Assert.IsTrue(true);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void CPFFormatadoValido()
        {
            string CPF = "035.989.666-95";
            ValidadorCPF validadorCPF = null;

            try
            {
                validadorCPF = new ValidadorCPF();
                validadorCPF.ValidarCPF(CPF);
                Assert.IsTrue(true);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void CPFInválido()
        {
            string CPF = "00000000000";
            ValidadorCPF validadorCPF = null;

            try
            {
                validadorCPF = new ValidadorCPF();
                validadorCPF.ValidarCPF(CPF);
                Assert.IsTrue(false);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex.Message.Contains("CPF inválido"));
            }
        }

        [TestMethod]
        public void CPFInválidoMaiorQue11()
        {
            string CPF = "000000000000";
            ValidadorCPF validadorCPF = null;

            try
            {
                validadorCPF = new ValidadorCPF();
                validadorCPF.ValidarCPF(CPF);
                Assert.IsTrue(false);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex.Message.Contains("CPF inválido"));
            }
        }

        [TestMethod]
        public void CPFFormatadoInvalidoMaiorQue14()
        {
            string CPF = "035.989.666-951";
            ValidadorCPF validadorCPF = null;

            try
            {
                validadorCPF = new ValidadorCPF();
                validadorCPF.ValidarCPF(CPF);
                Assert.IsTrue(false);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex.Message.Contains("CPF inválido"));
            }
        }

        [TestMethod]
        public void CPFFormatacaoValida()
        {
            string CPF = "37400260227";
            ValidadorCPF validadorCPF = null;

            try
            {
                validadorCPF = new ValidadorCPF();

                if (validadorCPF.FormatarCPF(CPF).Length == 14)
                {
                    Assert.IsTrue(true);
                }
                else
                {
                    Assert.IsTrue(false);
                }
            }
            catch (Exception ex)
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void CPFFormatacaoInValida()
        {
            string CPF = "374002602271";
            ValidadorCPF validadorCPF = null;

            try
            {
                validadorCPF = new ValidadorCPF();

                if (validadorCPF.FormatarCPF(CPF).Length > 14)
                {
                    Assert.IsTrue(true);
                }
                else
                {
                    Assert.IsTrue(false);
                }
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex.Message.Contains("CPF inválido"));
            }
        }

        [TestMethod]
        public void CPFRetirarFormatacaoValida()
        {
            string CPF = "035.989.666-95";
            ValidadorCPF validadorCPF = null;

            try
            {
                validadorCPF = new ValidadorCPF();

                if (validadorCPF.RetirarFormatacaoCPF(CPF).Length == 11)
                {
                    Assert.IsTrue(true);
                }
                else
                {
                    Assert.IsTrue(false);
                }
            }
            catch (Exception ex)
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void CPFRetirarFormatacaoInValida()
        {
            string CPF = "035.989.666-951";
            ValidadorCPF validadorCPF = null;

            try
            {
                validadorCPF = new ValidadorCPF();

                if (validadorCPF.RetirarFormatacaoCPF(CPF).Length > 14)
                {
                    Assert.IsTrue(false);
                }
                else
                {
                    Assert.IsTrue(true);
                }
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex.Message.Contains("CPF inválido"));
            }
        }

        #endregion

        #region Teste de CNPJ

        [TestMethod]
        public void CNPJValido()
        {
            string CNPJ = "06224422000127";
            ValidadorCNPJ validadorCNPJ = null;

            try
            {
                validadorCNPJ = new ValidadorCNPJ();
                validadorCNPJ.ValidarCNPJ(CNPJ);
                Assert.IsTrue(true);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void CNPJValidoFormatado()
        {
            string CNPJ = "06.224.422/0001-27";
            ValidadorCNPJ validadorCNPJ = null;

            try
            {
                validadorCNPJ = new ValidadorCNPJ();
                validadorCNPJ.ValidarCNPJ(CNPJ);
                Assert.IsTrue(true);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void CNPJInValido()
        {
            string CNPJ = "062244220001271";
            ValidadorCNPJ validadorCNPJ = null;

            try
            {
                validadorCNPJ = new ValidadorCNPJ();
                validadorCNPJ.ValidarCNPJ(CNPJ);
                Assert.IsTrue(false);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex.Message.Contains("CNPJ inválido"));
            }
        }

        [TestMethod]
        public void CNPJInValidoFormatado()
        {
            string CNPJ = "06.224.422/00011-27";
            ValidadorCNPJ validadorCNPJ = null;

            try
            {
                validadorCNPJ = new ValidadorCNPJ();
                validadorCNPJ.ValidarCNPJ(CNPJ);
                Assert.IsTrue(false);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex.Message.Contains("CNPJ inválido"));
            }
        }

        [TestMethod]
        public void CNPJFormatacaoValido()
        {
            string CNPJ = "06224422000127";
            ValidadorCNPJ validadorCNPJ = null;

            try
            {
                validadorCNPJ = new ValidadorCNPJ();

                if (validadorCNPJ.FormatarCPNJ(CNPJ).Length == 18)
                {
                    Assert.IsTrue(true);
                }
                else
                {
                    Assert.IsTrue(false);
                }
            }
            catch (Exception ex)
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void CNPJFormatacaoInValido()
        {
            string CNPJ = "062244220001127";
            ValidadorCNPJ validadorCNPJ = null;

            try
            {
                validadorCNPJ = new ValidadorCNPJ();

                if (validadorCNPJ.FormatarCPNJ(CNPJ).Length > 18)
                {
                    Assert.IsTrue(true);
                }
                else
                {
                    Assert.IsTrue(false);
                }
            }
            catch (Exception ex)
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void CNPJRetirarValido()
        {
            string CNPJ = "06.224.422/0001-27";
            ValidadorCNPJ validadorCNPJ = null;

            try
            {
                validadorCNPJ = new ValidadorCNPJ();

                if (validadorCNPJ.RetirarFormatacaoCNPJ(CNPJ).Length == 14)
                {
                    Assert.IsTrue(true);
                }
                else
                {
                    Assert.IsTrue(false);
                }
            }
            catch (Exception ex)
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void CNPJRetirarInValido()
        {
            string CNPJ = "06.224.422/00011-27";
            ValidadorCNPJ validadorCNPJ = null;

            try
            {
                validadorCNPJ = new ValidadorCNPJ();

                if (validadorCNPJ.RetirarFormatacaoCNPJ(CNPJ).Length > 13)
                {
                    Assert.IsTrue(true);
                }
                else
                {
                    Assert.IsTrue(false);
                }
            }
            catch (Exception ex)
            {
                Assert.IsTrue(false);
            }
        }

        #endregion

        #region Teste de Titulo de Eleitor

        [TestMethod]
        public void TituloEleitorValido()
        {
            string titulo = "814737711147";
            ValidadorTituloEleitor validadorTituloEleitor = null;

            try
            {
                validadorTituloEleitor = new ValidadorTituloEleitor();
                validadorTituloEleitor.ValidarTituloEleitor(titulo);
                Assert.IsTrue(true);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void TituloEleitorInValido()
        {
            string titulo = "814737711148";
            ValidadorTituloEleitor validadorTituloEleitor = null;

            try
            {
                validadorTituloEleitor = new ValidadorTituloEleitor();
                validadorTituloEleitor.ValidarTituloEleitor(titulo);
                Assert.IsTrue(false);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex.Message.Contains("Titulo Eleitor inválido"));
            }
        }

        [TestMethod]
        public void TituloEleitorFormatoValido()
        {
            string titulo = "814737711147";
            ValidadorTituloEleitor validadorTituloEleitor = null;

            try
            {
                validadorTituloEleitor = new ValidadorTituloEleitor();

                if (validadorTituloEleitor.FormatarTituloEleitor(titulo).Length == 13)
                {
                    Assert.IsTrue(true);
                }
                else
                {
                    Assert.IsTrue(false);
                }
            }
            catch (Exception ex)
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void TituloEleitorFormatoInValido()
        {
            string titulo = "8147377111471";
            ValidadorTituloEleitor validadorTituloEleitor = null;

            try
            {
                validadorTituloEleitor = new ValidadorTituloEleitor();

                if (validadorTituloEleitor.FormatarTituloEleitor(titulo).Length > 13)
                {
                    Assert.IsTrue(true);
                }
                else
                {
                    Assert.IsTrue(false);
                }
            }
            catch (Exception ex)
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void TituloEleitorRetirarFormatoValido()
        {
            string titulo = "8147377111/47";
            ValidadorTituloEleitor validadorTituloEleitor = null;

            try
            {
                validadorTituloEleitor = new ValidadorTituloEleitor();

                if (validadorTituloEleitor.RetirarFormatacaoTituloEleitor (titulo).Length == 12)
                {
                    Assert.IsTrue(true);
                }
                else
                {
                    Assert.IsTrue(false);
                }
            }
            catch (Exception ex)
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void TituloEleitorRetirarFormatoInValido()
        {
            string titulo = "8147377111/471";
            ValidadorTituloEleitor validadorTituloEleitor = null;

            try
            {
                validadorTituloEleitor = new ValidadorTituloEleitor();

                if (validadorTituloEleitor.RetirarFormatacaoTituloEleitor(titulo).Length > 12)
                {
                    Assert.IsTrue(true);
                }
                else
                {
                    Assert.IsTrue(false);
                }
            }
            catch (Exception ex)
            {
                Assert.IsTrue(false);
            }
        }

        #endregion

        #region Teste de Datas

        [TestMethod]
        public void DataValido()
        {
            string data = "20/01/2018";
            ValidadorDatas validadorDatas = null;

            try
            {
                validadorDatas = new ValidadorDatas();
                validadorDatas.TratamentoData(data);
                Assert.IsTrue(true);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void DataValido1()
        {
            string data = "20-01-2018";
            ValidadorDatas validadorDatas = null;

            try
            {
                validadorDatas = new ValidadorDatas();
                validadorDatas.TratamentoData(data);
                Assert.IsTrue(true);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void DataValido2()
        {
            string data = "2018/01/20";
            ValidadorDatas validadorDatas = null;

            try
            {
                validadorDatas = new ValidadorDatas();
                validadorDatas.TratamentoData(data);
                Assert.IsTrue(true);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void DataValido3()
        {
            string data = "2018-01-20";
            ValidadorDatas validadorDatas = null;

            try
            {
                validadorDatas = new ValidadorDatas();
                validadorDatas.TratamentoData(data);
                Assert.IsTrue(true);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void DataInValido()
        {
            string data = "2018/20/01";
            ValidadorDatas validadorDatas = null;

            try
            {
                validadorDatas = new ValidadorDatas();
                validadorDatas.TratamentoData(data);
                Assert.IsTrue(false);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex.Message.Contains("Data inválida"));
            }
        }

        [TestMethod]
        public void DataInValido1()
        {
            string data = "2018-20-01";
            ValidadorDatas validadorDatas = null;

            try
            {
                validadorDatas = new ValidadorDatas();
                validadorDatas.TratamentoData(data);
                Assert.IsTrue(false);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex.Message.Contains("Data inválida"));
            }
        }

        [TestMethod]
        public void DataHoraValido()
        {
            string data = "20/01/2018 10:00:00";
            ValidadorDatas validadorDatas = null;

            try
            {
                validadorDatas = new ValidadorDatas();
                validadorDatas.TratamentoData(data);
                Assert.IsTrue(true);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void DataHoraValido1()
        {
            string data = "20-01-2018 10:00:00";
            ValidadorDatas validadorDatas = null;

            try
            {
                validadorDatas = new ValidadorDatas();
                validadorDatas.TratamentoData(data);
                Assert.IsTrue(true);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void DataHoraValido2()
        {
            string data = "2018/01/20 10:00:00";
            ValidadorDatas validadorDatas = null;

            try
            {
                validadorDatas = new ValidadorDatas();
                validadorDatas.TratamentoData(data);
                Assert.IsTrue(true);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void DataHoraValido3()
        {
            string data = "2018-01-20 10:00:00";
            ValidadorDatas validadorDatas = null;

            try
            {
                validadorDatas = new ValidadorDatas();
                validadorDatas.TratamentoData(data);
                Assert.IsTrue(true);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void DataHoraInvalido()
        {
            string data = "2018/20/01 10:00:00";
            ValidadorDatas validadorDatas = null;

            try
            {
                validadorDatas = new ValidadorDatas();
                validadorDatas.TratamentoData(data);
                Assert.IsTrue(false);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex.Message.Contains("Data inválida"));
            }
        }

        [TestMethod]
        public void DataHoraInvalido1()
        {
            string data = "2018-20-01 10:00:00";
            ValidadorDatas validadorDatas = null;

            try
            {
                validadorDatas = new ValidadorDatas();
                validadorDatas.TratamentoData(data);
                Assert.IsTrue(false);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex.Message.Contains("Data inválida"));
            }
        }

        #endregion

        #region Teste de CEP

        [TestMethod]
        public void CEPValido()
        {
            string cep = "20930445";
            ValidadorCEP validadorCEP = null;

            try
            {
                validadorCEP = new ValidadorCEP();
                validadorCEP.GetEnderecoCompleto(cep);
                Assert.IsTrue(true);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void CEPInValido()
        {
            string cep = "209304456";
            ValidadorCEP validadorCEP = null;

            try
            {
                validadorCEP = new ValidadorCEP();
                validadorCEP.GetEnderecoCompleto(cep);
                Assert.IsTrue(false);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex.Message.Contains("informado é inválido"));
            }
        }

        [TestMethod]
        public void CEPFormatacaoValido()
        {
            string cep = "20930445";
            ValidadorCEP validadorCEP = null;

            try
            {
                validadorCEP = new ValidadorCEP();

                if (validadorCEP.FormatarCep(cep).Length == 9)
                {
                    Assert.IsTrue(true);
                }
                else
                {
                    Assert.IsTrue(false);
                }
            }
            catch (Exception ex)
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void CEPFormatacaoInValido()
        {
            string cep = "209304459";
            ValidadorCEP validadorCEP = null;

            try
            {
                validadorCEP = new ValidadorCEP();

                if (validadorCEP.FormatarCep(cep).Length > 9)
                {
                    Assert.IsTrue(true);
                }
                else
                {
                    Assert.IsTrue(false);
                }
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex.Message.Contains("informado é inválido"));
            }
        }

        [TestMethod]
        public void CEPRetirarFormatacaoValido()
        {
            string cep = "20930-445";
            ValidadorCEP validadorCEP = null;

            try
            {
                validadorCEP = new ValidadorCEP();

                if (validadorCEP.RetirarFormatacaoCep(cep).Length == 8)
                {
                    Assert.IsTrue(true);
                }
                else
                {
                    Assert.IsTrue(false);
                }
            }
            catch (Exception ex)
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void CEPRetirarFormatacaoInValido()
        {
            string cep = "20930-4456";
            ValidadorCEP validadorCEP = null;

            try
            {
                validadorCEP = new ValidadorCEP();

                if (validadorCEP.RetirarFormatacaoCep(cep).Length == 9)
                {
                    Assert.IsTrue(true);
                }
                else
                {
                    Assert.IsTrue(false);
                }
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex.Message.Contains("informado é inválido"));
            }
        }

        #endregion
    }
}
