using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafiosCodigoCSharpDio
{
    class Quantidade_de_Números_Positivos
    {
        /*Desafio
            Crie um programa que leia 6 valores, os quais poderão ser 
            negativos e/ou positivos. Em seguida, apresente a quantidade 
            de valores positivos digitados.

            Entrada
            Você receberá seis valores, negativos e/ou positivos.

            Saída
            Exiba uma mensagem dizendo quantos valores positivos foram lidos. 
            assim como é exibido abaixo no exemplo de saída. Não se esqueça de
            incluir na mensagem de saída o sufixo " valores positivos"
         */

        public static void Main(string[] args)
        {
            int quantidadePositivos = 0;
            for (int i = 0; i < 6; i++)
            {
                double valorInformadoPeloUsuario = double.Parse(Console.ReadLine());
                if (valorInformadoPeloUsuario > 0)
                {
                    quantidadePositivos++;
                }
            }
            Console.WriteLine(quantidadePositivos + " valores positivos");
        }
    }
}
