using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTest2_POO
{
    class Pessoa
    {
        #region "Recursos Privados"
        private string strNome;
        private string strCPF;
        //private DateTime nascimento;
        #endregion

        #region "Construtores"
        //Anotação(///):
        /// <summary>
        /// Construtor da classe Pessoa
        /// </summary>
        public Pessoa() { } //vazio

        public Pessoa(string CPF, string Nome) //SOBRECARGA
        {
            this.CPF = CPF;     //strCPF = CPF;   ---escrita direto na memoria, NÃO É CORRETO
            this.Nome = Nome;   //strNome = Nome; ---pode acarretar erros 
        }
        public Pessoa(string CPF) //SOBRECARGA
        {
            this.CPF = CPF;
        }
        
        #endregion

        #region "Propriedades"
        public string CPF
            {
                set {
                if (value.Length >= 4)
                {
                    strCPF = value;
                }
                else throw new Exception("CPF inválido!"); //instancia de mensagem de erro - gera um novo erro com parametro Message
                    
                }
                get { return strCPF; }
            } 

            public string Nome
            {
                set { strNome = value; }
                get { return strNome; }
            }
        #endregion
    }
}
