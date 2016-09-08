using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//class1 - 06/09
namespace TesteApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello Word!");
            //Console.ReadKey();

            /*int n = 10;
            for (int i = 0; i <= n; i++)
            {
                //Console.WriteLine(i);    0 a 10
                //Console.WriteLine(n-i); 10 a 0

                /*
                if (i % 2 == 0) //é par
                { 
                    Console.WriteLine(i);
                }
                
            }*/

            /* int num;
             Console.Write("Digite um numero: ");
             num = Convert.ToInt16(Console.ReadLine());
             bool exact = false;
             for (int j = 2; j < num; j++)
             {
                 if (num % j == 0)
                 {
                     exact = true;
                     break;
                 }
                 else
                 {
                     exact = false;
                 }
             }

             if (exact == false)
             {
                 Console.WriteLine(num + " eh primo");
             }
             else
             {
                 Console.WriteLine(num + " nao eh primo");
             }*/

            bool exact = false;
            int cont = 0;
            while (cont < 25) { 
                    for (int j = 2; j < 100; j++)
                    {
                      if (num % j == 0)
                      {
                        exact = true;
                        break;
                       }
                        else
                        {
                            exact = false;
                        }
                    }

                    if (exact == false)
                    {
                        Console.WriteLine(num + " eh primo");
                        cont++;
                    }
                                       
        }
        }
    }
}
