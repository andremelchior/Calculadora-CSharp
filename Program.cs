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
                Console.WriteLine("\nDigite um n�mero para Operador Aritm�tico");
                Console.WriteLine("\n1 - [SOMA]");
                Console.WriteLine("2 - [SUBTRA��O]");
                Console.WriteLine("3 - [MULTIPLICA��O]");
                Console.WriteLine("4 - [DIVIS�O]");
                A.op = int.Parse(Console.ReadLine());

                if(A.op == 1 || A.op == 2 || A.op == 3 || A.op == 4)
                {
                    A.valores();
                    A.mostraCont();
                }else
                {
                    Console.WriteLine("\nVoc� digitou uma op��o errada");
                }

                Console.WriteLine("\nDeseja sair do programa? [0 -> SIM] [1 -> N�O]");
                A.op = int.Parse(Console.ReadLine());

                Console.Clear();
            } while (A.op != 0);
        }
    }
}
