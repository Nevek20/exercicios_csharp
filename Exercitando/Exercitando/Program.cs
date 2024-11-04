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
            Console.ResetColor();
            Menu();
        }
        public static void Menu()
        {
            Console.WriteLine("Digite 0 para sair do programa.");
            Console.WriteLine("Digite 1 para Exercicios 1.");
            Console.WriteLine("Digite 2 para Exercicios 2.");
            Console.WriteLine("Digite 3 para Exercicios 3.");
            Console.WriteLine("Digite 4 para Exercicios 4.");
            Console.WriteLine("Digite 5 para Exercicios 5.");
            Console.WriteLine("Digite 6 para Exercicios 6.");
            int escolhas = int.Parse(Console.ReadLine());

            switch (escolhas)
            {
                case 1:
                    Console.WriteLine("Você escolheu a opção 1.");
                    exercicio1();
                    break;
                case 2:
                    Console.WriteLine("Você escolheu a opção 2.");
                    exercicio2();
                    break;
                case 3:
                    Console.WriteLine("Você escolheu a opção 3");
                    exercicio3();
                    break;
                case 4:
                    Console.WriteLine("Você escolheu a opção 4");
                    exercicio4();
                    break;
                case 5:
                    Console.WriteLine("Você escolheu a opção 5");
                    exercicio5();
                    break;
                case 6:
                    Console.WriteLine("Você escolheu a opção 6");
                    exercicio6();
                    break;
                case 0:
                    Console.WriteLine("Saindo...");
                    Thread.Sleep(2530);
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
        //2. Crie um programa que leia a idade de uma pessoa e informe se ela é maior de idade (18 anos ou mais) ou menor de idade.
        public static void exercicio1()
        {
            Console.WriteLine("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());
            if (idade  <= 17) {
                Console.WriteLine("Você é de menor.\n");
                Menu();
            }
            else if (idade >= 18)
            {
                Console.WriteLine("você é de maior.\n");
                Menu();
            }
        }
        //6. Faça um programa que leia a nota de um aluno e informe se ele está aprovado (nota maior ou igual a 7), em recuperação (nota entre 5 e 7) ou reprovado (nota menor que 5).
        public static void exercicio2()
        {
            Console.WriteLine("Nota do aluno: ");
            int nota = int.Parse(Console.ReadLine());

            if (nota <= 4){
                Console.WriteLine("Reprovado\n");
                Menu();
            }
            else if (nota == 5 || nota == 6){
                Console.WriteLine("Recuperação\n");
                Menu();
            }
            else if (nota >= 7){
                Console.WriteLine("Aprovado\n");
                Menu();
            }
        }
        //7. Escreva um programa que leia dois números e uma operação (adição, subtração, multiplicação, divisão) e realize a operação entre os dois números.
        public static void exercicio3()
        {
            Console.WriteLine("Digite o primeiro numero: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua escolha:\n\n1.Adição\n2.Subtração\n3.Multiplicação\n4.Divisão");
            int escolha = int.Parse(Console.ReadLine());
            if (escolha == 1)
            {
                Console.WriteLine("sua conta: " + numero1 + " + " + numero2 + " = " + (numero1 + numero2)+"\n");
                Menu();
            }
            else if (escolha == 2)
            {
                Console.WriteLine("sua conta: " + numero1 + " - " + numero2 + " = " + (numero1 - numero2)+"\n");
                Menu();
            }
            else if (escolha == 3)
            {
                Console.WriteLine("sua conta: " + numero1 + " X " + numero2 + " = " + (numero1 * numero2)+"\n");
                Menu();
            }
            else if (escolha == 4)
            {
                Console.WriteLine("sua conta: " + numero1 + " ÷ " + numero2 + " = " + (numero1 / numero2)+"\n");
                Menu();
            }
        }
        //1. Escreva um programa que verifique se um número fornecido pelo usuário é positivo, negativo ou zero.
        public static void exercicio4()
        {
            Console.WriteLine("escreva seu número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero >= 1)
            {
                Console.WriteLine("Número positivo.\n");
                Menu();
            }
            else if (numero <= -1)
            {
                Console.WriteLine("Número negativo.\n");
                Menu();
            }
            else
            {
                Console.WriteLine("Seu número é zero.\n");
                Menu();
            }
        }
        //3. Escreva um programa que verifique se um número fornecido pelo usuário é par ou ímpar.
        public static void exercicio5()
        {
            Console.WriteLine("Digite seu número");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("Seu número é par.\n");
                Menu();
            }
            else
            {
                Console.WriteLine("Seu número é ímpar.\n");
                Menu();
            }
        }
        //10. Escreva um programa que leia o peso e a altura de uma pessoa e calcule seu IMC, informando se está abaixo do peso, no peso normal, acima do peso ou obeso.
        public static void exercicio6()
        {
            Console.WriteLine("Seu peso: ");
            double peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Sua altura: ");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);
            Console.WriteLine("Seu IMC: " + imc);
            Menu();
        }
    }
}
