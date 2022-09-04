using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafiosCodigoCSharpDio
{
    internal class Três_Divisores
    {
        /*Desafio
        Dado um inteiro n, retorne true se n tiver exatamente
        três divisores positivos. Caso contrário, retorne false.
        O inteiro m é um divisor de n, se existe um inteiro k tal que n = k * m. 

        Entrada
        O arquivo de entrada consiste em um inteiro n que será validada
        caso esteja sob as condições do desafio.

        Saída
        A saída consistirá em um tipo booleano: true ou false.*/
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count == 3);
        }
    }
}
