using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc A; 

            A = new Calc();
            do
            {
                Console.WriteLine("\nDigite um número para Operador Aritmético");
                Console.WriteLine("\n1 - [SOMA]");
                Console.WriteLine("2 - [SUBTRAÇÃO]");
                Console.WriteLine("3 - [MULTIPLICAÇÃO]");
                Console.WriteLine("4 - [DIVISÃO]");
                A.op = int.Parse(Console.ReadLine());

                if(A.op == 1 || A.op == 2 || A.op == 3 || A.op == 4)
                {
                    A.valores();
                    A.mostraCont();
                }else
                {
                    Console.WriteLine("\nVocê digitou uma opção errada");
                }

                Console.WriteLine("\nDeseja sair do programa? [0 -> SIM] [1 -> NÃO]");
                A.op = int.Parse(Console.ReadLine());

                Console.Clear();
            } while (A.op != 0);
        }
    }
}
