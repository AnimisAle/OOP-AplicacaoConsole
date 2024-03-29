﻿using Aula02Curso.Funcoes;
using Calculo;
using Classes;
using Diretorio;
using Funcoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tela
{
    public class Menu
    {
        public static void Criar()
        {
            while (true)
            {
                string Mensagem = "Olá, seja bem vindo ao programa. \n \n" +
                    "\n================ Aplicação Console Final ================\n" +
                    "\n Digite uma das opções abaixo: \n" +
                    "\n 0 - Sair do programa" +
                    "\n 1 - Para ler arquivos" +
                    "\n 2 - Para executar a tabuada" +
                    "\n 3 - Calcular media de alunos" +
                    "\n 4 - Cadastrar clientes" +
                    "\n 5 - Cadastrar usuários" +
                    "\n 6 - Cadastrar fornecedor";

                Console.WriteLine(Mensagem);

                int valor = int.Parse(Console.ReadLine());

                if (SAIDA_PROGRAMA == valor)
                {
                    break;
                }
                else if (valor == LER_ARQUIVOS)
                {
                    Console.WriteLine("======= Opção de ler arquivos ======= \n");
                    Arquivo.Ler(1);
                }
                else if (valor == TABUADA)
                {
                    Console.WriteLine("======= Opção tabuada ======= \n");
                    Console.WriteLine("Digire o número que deseja na tabuada: ");
                    int numero = int.Parse(Console.ReadLine());
                    Tabuada.Calcular(numero);
                    Console.WriteLine("============================ \n");
                }
                else if (valor == CALCULO_MEDIA)
                {
                    Console.WriteLine("============================ \n");
                    Media.Aluno();
                }
                else if (valor == CADASTRAR_CLIENTES)
                {
                    Console.WriteLine("============================ \n");
                    TelaCliente.Chamar();
                }
                else if (valor == CADASTRAR_USUARIO)
                {
                    Console.WriteLine("============================ \n");
                    TelaUsuario.Chamar();
                }
                else if (valor == CADASTRAR_FORNECEDOR)
                {
                    Console.WriteLine("============================ \n");
                    TelaFornecedor.Chamar();
                }
                else
                {
                    Console.WriteLine("============================ \n");
                    Console.WriteLine("Opção inválida, digite uma das opções válidas...");
                    Console.WriteLine("============================ \n");
                }

            }
        }

        public const int SAIDA_PROGRAMA = 0;
        public const int LER_ARQUIVOS = 1;
        public const int TABUADA = 2;
        public const int CALCULO_MEDIA = 3;
        public const int CADASTRAR_CLIENTES = 4;
        public const int CADASTRAR_USUARIO = 5;
        public const int CADASTRAR_FORNECEDOR = 6;
    }
}
