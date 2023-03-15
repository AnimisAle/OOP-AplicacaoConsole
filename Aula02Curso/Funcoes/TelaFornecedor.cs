using Classes;
using Diretorio;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcoes
{
   public class TelaFornecedor
    {
        public static void Chamar()
        {
            Console.WriteLine("===================== Cadastro de fornecedores ======================");
            while (true)
            {
                string Mensagem = "Olá, seja bem vindo ao programa... +" +
                   "\n Digite uma das opções abaixo: \n" +
                   "\n 0 - Sair do programa" +
                   "\n 1 - Para cadastrar fornecedores" +
                   "\n 2 - Para listar os fornecedores";

                Console.WriteLine(Mensagem);
                
                int valor = int.Parse(Console.ReadLine());

                if (valor == 0)
                {
                    break;
                }
                // Cadastro de fornecedores
                else if (valor == 1)
                {
                    
                    var fornecedor = new Fornecedor();

                    Console.WriteLine("Insira o CNPJ do fornecedor:");
                    fornecedor.CNPJ = Console.ReadLine();

                    Console.WriteLine("Insira o nome do fornecedor: ");
                    fornecedor.Nome = Console.ReadLine();
                   
                    Console.WriteLine("Insira o telefone do fornecedor: ");
                    fornecedor.Telefone = Console.ReadLine();
                    
                    Console.WriteLine("Insira o CPF do fornecedor: ");
                    fornecedor.CPF = Console.ReadLine();
                    
                    fornecedor.Gravar();
                }
                // Listar os fornecedores 
                else
                {
                    var fornecedor = new Fornecedor().Ler();
                    foreach (Fornecedor f in fornecedor)
                    {
                        Console.WriteLine("=========================");
                        Console.WriteLine("CNPJ " + f.CNPJ);
                        Console.WriteLine("Nome: " + f.Nome);
                        Console.WriteLine("Telefone: " + f.Telefone);
                        Console.WriteLine("Nome: " + f.CPF);
                        Console.WriteLine("========================= \n\n");
                    }
                }
            }
        }
    }
}
