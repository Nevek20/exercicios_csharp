using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercitando
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cabecalho();
        }
        public static void Cabecalho()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=========================================================");
            Console.WriteLine("                        Feito por");
            Console.WriteLine("=========================================================");
            Console.WriteLine("*  #######  ##   ##   #####   ####       ##      ##### *\r\n*   ##   #  ### ###  ##   ##   ##       ####    ##   ## *\r\n*   ## #    #######  ##   ##   ##      ##  ##   # *\r\n*   ####    #######  ##   ##   ##      ##  ##    ##### *\r\n*   ## #    ## # ##  ##   ##   ##   #  ######        ## *\r\n*   ##   #  ##   ##  ##   ##   ##  ##  ##  ##   ##   ## *\r\n*  #######  ##   ##   #####   #######  ##  ##    ##### *");
            Console.WriteLine("=========================================================");
            Console.WriteLine("                     Lhes apresento:");
            Console.WriteLine("                                                  \r\n,---.                   o|                  |     \r\n|--- .  ,,---.,---.,---..|--- ,---.,---.,---|,---.\r\n|     >< |---'|    |    ||    ,---||   ||   ||   |\r\n`---''  ``---'`    `---'``---'`---^`   '`---'`---'\r\n                                                  ");
            Console.WriteLine("=========================================================");
            Console.WriteLine("");
            Console.ResetColor();
            Menu();
        }
        public static void Menu()
        {
            Console.WriteLine("Digite 1 para Exercicios 1.              (Testador de idade)\n");
            Console.WriteLine("Digite 2 para Exercicios 2.              (Notas escolares)\n");
            Console.WriteLine("Digite 3 para Exercicios 3.              (calculadora básica)\n");
            Console.WriteLine("Digite 4 para Exercicios 4.              (Negativo, positivo ou zero)\n");
            Console.WriteLine("Digite 5 para Exercicios 5.              (Par ou ímpar)\n");
            Console.WriteLine("Digite 6 para Exercicios 6.              (Calculador de IMC)\n");
            Console.WriteLine("Digite 0 para sair do programa.");
            int escolhas = int.Parse(Console.ReadLine());

            switch (escolhas)
            {
                case 1:
                    Console.WriteLine("Você escolheu a opção 1.");
                    Console.Clear();
                    Exercicio1();
                    break;
                case 2:
                    Console.WriteLine("Você escolheu a opção 2.");
                    Console.Clear();
                    Exercicio2();
                    break;
                case 3:
                    Console.WriteLine("Você escolheu a opção 3");
                    Console.Clear();
                    Exercicio3();
                    break;
                case 4:
                    Console.WriteLine("Você escolheu a opção 4");
                    Console.Clear();
                    Exercicio4();
                    break;
                case 5:
                    Console.WriteLine("Você escolheu a opção 5");
                    Console.Clear();
                    Exercicio5(); 
                    break;
                case 6:
                    Console.WriteLine("Você escolheu a opção 6");
                    Console.Clear();
                    Exercicio6();
                    break;
                case 0:
                    Console.Clear();
                    Console.WriteLine("Saindo...");
                    Thread.Sleep(2530);
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    Thread.Sleep(2000);
                    Console.Clear();
                    Cabecalho();
                    Menu();
                    break;
            }
        }
        //2. Crie um programa que leia a idade de uma pessoa e informe se ela é maior de idade (18 anos ou mais) ou menor de idade.
        public static void Exercicio1()
        {
            Console.WriteLine("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());
            if (idade  <= 17) {
                Console.WriteLine("Você é de menor.\n");
                Thread.Sleep(2000);
                Console.Clear();
                Cabecalho();
                Menu();
            }
            else if (idade > 18 && idade < 118)
            {
                Console.WriteLine("você é de maior.\n");
                Thread.Sleep(2000);
                Console.Clear();
                Cabecalho();
                Menu();
            }
            else if (idade >= 119)
            {
                Console.WriteLine("Você esta morto.\n");
                Thread.Sleep(2000);
                Console.Clear();
                Cabecalho();
                Menu();
            }
        }
        //6. Faça um programa que leia a nota de um aluno e informe se ele está aprovado (nota maior ou igual a 7), em recuperação (nota entre 5 e 7) ou reprovado (nota menor que 5).
        public static void Exercicio2()
        {
            Console.WriteLine("Nota do aluno: ");
            int nota = int.Parse(Console.ReadLine());

            if (nota <= 4){
                Console.WriteLine($"Reprovado.\n\nNota: {nota}");
                Thread.Sleep(2000);
                Console.Clear();
                Cabecalho();
                Menu();
            }
            else if (nota == 5 || nota == 6){
                Console.WriteLine($"Recuperação.\n\nNota: {nota}");
                Thread.Sleep(2000);
                Console.Clear();
                Cabecalho();
                Menu();
            }
            else if (nota >= 7 && nota <= 10){
                Console.WriteLine($"Aprovado.\n\nNota: {nota}");
                Thread.Sleep(2000);
                Console.Clear();
                Cabecalho();
                Menu();
            }
            else if (nota >= 11)
            {
                Console.WriteLine("ERRO: Nota maior do que o esperado.");
                Exercicio2();
            }
            else
            {
                Console.WriteLine("ERRO: Valor inserido incorreto.");
                Exercicio2();
            }
        }
        //7. Escreva um programa que leia dois números e uma operação (adição, subtração, multiplicação, divisão) e realize a operação entre os dois números.
        public static void Exercicio3()
        {
            Console.WriteLine("Digite o primeiro numero: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua escolha:\n\n1.Adição\n2.Subtração\n3.Multiplicação\n4.Divisão");
            int escolha = int.Parse(Console.ReadLine());
            if (escolha == 1)
            {
                Console.WriteLine($"sua conta:  {numero1} + {numero2} = {(numero1 + numero2)}\n");
                Thread.Sleep(2000);
                Console.Clear();
                Cabecalho();
                Menu();
            }
            else if (escolha == 2)
            {
                Console.WriteLine($"sua conta:  {numero1} - {numero2} = {(numero1 + numero2)}\n");
                Thread.Sleep(2000);
                Console.Clear();
                Cabecalho();
                Menu();
            }
            else if (escolha == 3)
            {
                Console.WriteLine($"sua conta:  {numero1} X {numero2} = {(numero1 + numero2)}\n");
                Thread.Sleep(2000);
                Console.Clear();
                Cabecalho();
                Menu();
            }
            else if (escolha == 4)
            {
                Console.WriteLine($"sua conta:  {numero1} ÷ {numero2} = {(numero1 + numero2)}\n");
                Thread.Sleep(2000);
                Console.Clear();
                Cabecalho();
                Menu();
            }
            else
            {
                Console.WriteLine("ERRO: Numero digitado incorreto.");
                Thread.Sleep(2000);
                Console.Clear();
                Exercicio3();
            }
        }
        //1. Escreva um programa que verifique se um número fornecido pelo usuário é positivo, negativo ou zero.
        public static void Exercicio4()
        {
            Console.WriteLine("escreva seu número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero >= 1)
            {
                Console.WriteLine("Número positivo.\n");
                Thread.Sleep(2000);
                Console.Clear();
                Cabecalho();
                Menu();
            }
            else if (numero <= -1)
            {
                Console.WriteLine("Número negativo.\n");
                Thread.Sleep(2000);
                Console.Clear();
                Cabecalho();
                Menu();
            }
            else
            {
                Console.WriteLine("Seu número é zero.\n");
                Thread.Sleep(2000);
                Console.Clear();
                Cabecalho();
                Menu();
            }
        }
        //3. Escreva um programa que verifique se um número fornecido pelo usuário é par ou ímpar.
        public static void Exercicio5()
        {
            Console.WriteLine("Digite seu número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("Seu número é par.\n");
                Thread.Sleep(2000);
                Console.Clear();
                Cabecalho();
                Menu();
            }
            else
            {
                Console.WriteLine("Seu número é ímpar.\n");
                Thread.Sleep(2000);
                Console.Clear();
                Cabecalho();
                Menu();
            }
        }
        //10. Escreva um programa que leia o peso e a altura de uma pessoa e calcule seu IMC, informando se está abaixo do peso, no peso normal, acima do peso ou obeso.
        public static void Exercicio6()
        {
            Console.WriteLine("Seu peso: ");
            double peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Sua altura: ");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);
            Console.WriteLine($"Seu IMC: {imc}");
            Thread.Sleep(2000);
            Console.Clear();
            Cabecalho();
            Menu();
        }
    }
}
