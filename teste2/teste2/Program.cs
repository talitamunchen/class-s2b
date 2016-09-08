using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//aula 2 - 08/09
namespace teste2
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            int num = 2;

            String nomeArq = Path.Combine(Directory.GetCurrentDirectory(), "nros.txt"); 
            //criar arquivo nome com nome = "nros.text"
            //concatenação da string automaticamente
            //Directory.Get... - pasta atual do diretorio
            //@C:\TEXT\NRT.TEXT - String não literal

            StreamWriter arqSaida = new StreamWriter(nomeArq); //criar arquivo
            //arqSaida.WriteLine("teste"); //escrever no arquivo
            //arqSaida.Close(); //fim da escrita

            while (cont < 25)
            {
                bool e = false;
                for (int j = 2; j < num; j++)
                {
                    if (num % j == 0)
                    {
                        e = true;
                    }
                }

                if (!e)
                {
                    //Console.WriteLine(num); 
                    e = false;
                    arqSaida.WriteLine(num);
                    cont++;
                }
                
                num++;
                

            }
            arqSaida.Close();
            //Console.ReadKey();

        }
    }
}
