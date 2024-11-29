using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCalc
{
    class Calc
    {
        public int n1;
        public int n2;
        public double result;
        public int op;


        public void valores()
        {
            Console.WriteLine("\nDigite o primeiro valor: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            n2 = int.Parse(Console.ReadLine());
        }

        public void mostraCont()
        {
            if(op == 1)
            {
                result = n1 + n2;
                Console.WriteLine("\nO resultado é: " + n1 + " + " + n2 + " = " + result);
            }else if (op == 2)
            {
                result = n1 - n2;
                Console.WriteLine("\nO resultado é: " + n1 + " - " + n2 + " = " + result);
            }else if (op == 3)
            {
                result = n1 * n2;
                Console.WriteLine("\nO resultado é: " + n1 + " X " + n2 + " = " + result);
            }else if(op == 4)
            {
                result = n1 / n2;
                Console.WriteLine("\nO resultado é: " + n1 + " ÷ " + n2 + " = " + result);
            }

        }
    }
}
