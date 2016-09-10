using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTest2_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*Pessoa p = new Pessoa();
                p.CPF = "1234";     //call set
                p.Nome = "Talita";  //call set

                Pessoa p2 = new Pessoa("12345", "Talita München");

                Pessoa p3 = new Pessoa("124568");
                p3.Nome = "Ciclano";

                Console.WriteLine("Nome: {0} - CPF: {1}", p.Nome, p.CPF);
                Console.WriteLine("Nome: {0}", p2.Nome);
                Console.WriteLine("Nome: {0}", p3.Nome);
                */

                List<Pessoa> ps = new List<Pessoa>(); //lista tipada - arraylist apenas objetos do tipo "Pessoa" nesse caso
                int n = 10;
                for (int i = 0; i < n; i++)
                {
                    string strNome = "Nome " + i.ToString(); //outra variavel, diferente!
                    string strCPF = "000" + i.ToString();   //
                    strCPF = strCPF.Substring(0, 4); //retorna entre 0 até 4
                    //x.Substrin(x.Lengh-4, 4); as ultimas 4

                    ps.Add(new Pessoa(strCPF, strNome));
                }

                foreach(Pessoa P in ps) //não implicita  indice numerico, vai atribuindo desde o primeiro
                {
                    Console.WriteLine("Nome: {0} - CPF: {1}", P.Nome, P.CPF);
                }

                /*for (int i = 0; i < ps.Count; i++)
                {
                    Console.WriteLine("Nome: {0} - CPF: {1}", ps[i].Nome, ps[i].CPF);
                }*/
            }
            catch (Exception Erro) //executa apenas qnd da erro
            {
                Console.WriteLine("Erro: " + Erro.Message);
            }
            finally //vai executar!
            {
                Console.ReadKey(); //para dar tempo de ler o que der na rela
            }
        }
    }
}
