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
   public class TelaUsuario
    {
        public static void Chamar()
        {
            Console.WriteLine("===================== Cadastro de usuários ======================");
            while (true)
            {
                string Mensagem = "Olá, seja bem vindo ao programa... +" +
                   "\n Digite uma das opções abaixo: \n" +
                   "\n 0 - Sair do programa" +
                   "\n 1 - Para cadastrar usuários" +
                   "\n 2 - Para listar os usuários";

                Console.WriteLine(Mensagem);
                
                int valor = int.Parse(Console.ReadLine());

                if (valor == 0)
                {
                    break;
                }
                // Cadastro de usuarios
                else if (valor == 1)
                {
                    
                    var usuario = new Usuario();
                   
                    Console.WriteLine("Insira o nome do cliente: ");
                    usuario.Nome = Console.ReadLine();
                   
                    Console.WriteLine("Insira o telefone do cliente: ");
                    usuario.Telefone = Console.ReadLine();
                    
                    Console.WriteLine("Insira o CPF do cliente: ");
                    usuario.CPF = Console.ReadLine();
                    
                    usuario.Gravar();
                }
                // Listar os usuários 
                else
                {
                    var usuarios = new Usuario().Ler();
                    foreach (Usuario u in usuarios)
                    {
                        Console.WriteLine("=========================");
                        Console.WriteLine("Nome: " + u.Nome);
                        Console.WriteLine("Telefone: " + u.Telefone);
                        Console.WriteLine("Nome: " + u.CPF);
                        Console.WriteLine("=========================");
                    }
                }
            }
        }
    }
}
