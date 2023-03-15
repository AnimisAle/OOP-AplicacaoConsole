using Classes;
using Diretorio;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02Curso.Funcoes
{
   public class TelaCliente
    {
        public static void Chamar()
        {
            Console.WriteLine("===================== Cadastro de cliente ======================");
            while (true)
            {
                string Mensagem = "Olá, seja bem vindo ao programa... +" +
                   "\n Digite uma das opções abaixo: \n" +
                   "\n 0 - Sair do programa" +
                   "\n 1 - Para cadastrar clientes" +
                   "\n 2 - Para listar clientes";

                Console.WriteLine(Mensagem);
                
                int valor = int.Parse(Console.ReadLine());

                if (valor == 0)
                {
                    break;
                }
                // Cadastro de clientes 
                else if (valor == 1)
                {
                    
                    var cliente = new Cliente();
                   
                    Console.WriteLine("Insira o nome do cliente: ");
                    cliente.Nome = Console.ReadLine();
                   
                    Console.WriteLine("Insira o telefone do cliente: ");
                    cliente.Telefone = Console.ReadLine();
                    
                    Console.WriteLine("Insira o CPF do cliente: ");
                    cliente.CPF = Console.ReadLine();
                    
                    cliente.Gravar();
                }
                // Listar os clientes 
                else
                {
                    var clientes = new Cliente().Ler();
                    foreach (Cliente c in clientes)
                    {
                        Console.WriteLine("=========================");
                        Console.WriteLine("Nome: " + c.Nome);
                        Console.WriteLine("Telefone: " + c.Telefone);
                        Console.WriteLine("Nome: " + c.CPF);
                        Console.WriteLine("=========================");
                    }
                }
            }
        }
    }
}
