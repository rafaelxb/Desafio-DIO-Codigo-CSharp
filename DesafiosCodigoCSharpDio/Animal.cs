using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafiosCodigoCSharpDio
{
    class Animal
    {
        /*Neste problema, você deverá ler 3 palavras que definem o tipo
         *de animal possível segundo o esquema abaixo, da esquerda para a 
         *direita.  Em seguida conclua qual dos animais seguintes foi escolhido, 
         *através das três palavras fornecidas.

         Entrada
         A entrada contém 3 palavras, uma em cada linha, necessárias para 
         identificar o animal segundo a figura acima, com todas as letras minúsculas.

         Saída
         Imprima o nome do animal correspondente à entrada fornecida.*/

        public static void Main(string[] args)
        {
            string ossos;
            string tipo;
            string alimentacao;

            ossos = Console.ReadLine();
            tipo = Console.ReadLine();
            alimentacao = Console.ReadLine();

            if (ossos == "vertebrado")
            {
                if (tipo == "ave")
                {
                    if (alimentacao == "carnivoro")
                    {
                        Console.WriteLine("aguia\n");
                    }
                    else if (alimentacao == "onivoro")
                    {
                        Console.WriteLine("pomba\n");
                    }
                }
                else if (tipo == "mamifero")
                {
                    if (alimentacao == "onivoro")
                    {
                        Console.WriteLine("homem\n");
                    }
                    else if (alimentacao == "herbivoro")
                    {
                        Console.WriteLine("vaca\n");
                    }
                }
            }
            else if (ossos == "invertebrado")
            {
                if (tipo == "inseto")
                {
                    if (alimentacao == "hematofago")
                    {
                        Console.WriteLine("pulga\n");
                    }
                    else if (alimentacao == "herbivoro")
                    {
                        Console.WriteLine("lagarta\n");
                    }
                }
                else if (tipo == "anelideo")
                {
                    if (alimentacao == "hematofago")
                    {
                        Console.WriteLine("sanguessuga\n");
                    }
                    else if (alimentacao == "onivoro")
                    {
                        Console.WriteLine("minhoca\n");
                    }
                }
            }
        }
    }
}
