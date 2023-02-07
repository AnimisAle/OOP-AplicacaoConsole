using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07Curso
{
    internal class Program
    {
      /*  static int calcular()
        {
            int a = 1;
            int b = 2;
            int c = a + b;
            return c;

        }
        public static void tabuada(int numero)
        {
           for(int i = 1; i < 10; i++) {
                Console.WriteLine(numero + "X" + i + "=" + (numero * i)); 
            }
        }
      */
        private static void LerArquivo(string nomeArquivo)
        {
            using (StreamReader arquivo = File.OpenText(nomeArquivo))
            {
                string linha;
                while((linha = arquivo.ReadLine()) != null) { 
                   Console.WriteLine(linha);
                }
            }
        }
        static void Main(string[] args)
        {

            LerArquivo(@"C:\arquivos\arq1.txt");

            //tabuada(10);
            //Console.WriteLine("_______________________________________");
            //tabuada(9); 
            //Console.WriteLine("_______________________________________");
            //tabuada(8); 

   
        }

    
    }
}
