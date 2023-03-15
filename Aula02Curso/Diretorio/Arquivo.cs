using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diretorio
{
    public class Arquivo
    {   
        private static string caminhoArquivo()
        {
            return ConfigurationManager.AppSettings["CaminhoArquivo"];
        }
        public static void Ler(int numeroArquivo)
        {
            string arquivoComCaminho = caminhoArquivo() + numeroArquivo + ".txt";
            Console.WriteLine(" LENDO ARQUIVO : " + arquivoComCaminho + "\n");
            Console.WriteLine("===============================================");
            if (File.Exists(arquivoComCaminho))
            {

                using (StreamReader arquivo = File.OpenText(arquivoComCaminho))
                {
                    string linha;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);
                    }
                    Console.WriteLine("===============================================");
                }
            }
            string arquivosComCaminho2 = caminhoArquivo() + (numeroArquivo + 1) + ".txt";
            if (File.Exists(arquivosComCaminho2))
            {
                Arquivo.Ler(numeroArquivo + 1);
            }
        }
    }
}
