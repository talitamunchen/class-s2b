using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;

namespace TesteApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //LER ARQUIVO - criar arquivo primeiro
            String nomeArq = Path.Combine(Directory.GetCurrentDirectory(), "dados.csv");
            StreamReader arqEntrada = new StreamReader(nomeArq);
            

            while (!arqEntrada.EndOfStream) //EndsOfStream vai ate o final do arquivo
            {
                String linha = arqEntrada.ReadLine();
                String[] campos = linha.Split(';'); //quebra string por ';'

                Console.Write("Name: {0} - CPF: {1} - Date: {2}\n", campos[0], campos[1], campos[2]);

            }

            arqEntrada.Close();
            Console.ReadKey();

            
            //TRATAMENTO DE EXCEÇÃO - em tempo de desenvolvimento

            sqlconnection con = null;

            try
            {
                con = new sqlconnection(); //tentar acessar o banco
                con.open();
            }
            catch (SqlException erro) //erro de banco de dados SQL
            {

            }
            catch (Exception erro) //outro tipo de exceção
            {

            }
            finally //executado sempre, danco ou não erro (opcional)/recursos, cancelar execução
            {

            }
            
        }
    }
}
