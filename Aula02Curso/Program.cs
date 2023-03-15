
using Classes;
using Componentes;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Tela;

namespace console_App { 

     public class Program 
    {
        static void Main(string[] args)
        {
            Menu.Criar();
        }
     }
}
#region Código de teste das aulas referente a orientação a objetos 
/* Email.Instancia.Corpo = "bla bla bla";
            Email.Instancia.Titulo = "Titulo do Email";
            Email.Instancia.Origem = "fenasadsadmadksa@gmail.com";
            Email.Instancia.Destino = "fenasdajiasjdiaf@gmail.com";

            Email.Instancia.EnviarEmail(); 
            
            /*  var c = new Cachorro();
            c.Idade = 2;
            Console.WriteLine(c.Idade);

            c.Idade2 = 4;
            Console.WriteLine(c.Idade2);

            /* var cachorro = new Cachorro();
            cachorro.Comer(); 

             
            Console.WriteLine("============================= Cadastro de CLiente ============================= \n");
            Cliente c = new Cliente();
            c.Nome = "Cliente";
            c.Telefone = "11111111111111";
            c.CPF = "2324342";
            c.Gravar();

            foreach (Base cli in new Cliente().Ler())
            {
                Console.WriteLine(cli.Nome);
                Console.WriteLine(cli.CPF);
                Console.WriteLine(cli.Telefone);
                Console.WriteLine("=============================");
            }
            Console.WriteLine("============================= Cadastro de Usuário ============================= \n");
            Usuario u = new Usuario();
            u.Nome = "Usuario";
            u.Telefone = "888888888";
            u.CPF = "77777777777777";
            u.Gravar(); 

            foreach(Base us in new Usuario().Ler())
            {
                Console.WriteLine(us.Nome);
                Console.WriteLine(us.CPF);
                Console.WriteLine(us.Telefone);
                Console.WriteLine("=============================");
            }
/*
 Ferramentas f = new Ferramentas();
 bool d = f.ValidarCPF("sadsadsad");

 Cliente c = new Cliente();
 c.CalcularUmMaisDois3();
*/
#endregion