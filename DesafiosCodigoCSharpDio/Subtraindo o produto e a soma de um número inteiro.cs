using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafiosCodigoCSharpDio
{
    internal class Subtraindo_o_produto_e_a_soma_de_um_número_inteiro
    {
        /*Desafio
        Dado um número inteiro ( n ) , retorne a diferença entre o produto de seus 
        dígitos e a soma de seus dígitos.

        Entrada
        A entrada consiste em um número inteiro ( n );

        Saída
        A saída consiste na multiplicação do produto dos dígitos ( n ),
        a soma de seus dígitos e a diferenção entre o produto e a soma*/

        static void Main(string[] args)
        {

            char[] n = Console.ReadLine().ToCharArray();
            int p = 1, s = 0;

            foreach (char numero in n)
            {
                p *= (int)Char.GetNumericValue(numero);
                s += (int)Char.GetNumericValue(numero);
            }
            Console.WriteLine(p - s);
        }

    }
}


