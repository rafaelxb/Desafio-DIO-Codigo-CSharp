using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafiosCodigoCSharpDio
{
    class Conversão_de_Tempo
    {
        /*Desafio
            Você terá o desafio de ler um valor inteiro, 
            que é o tempo de duração em segundos de um determinado 
            evento em uma loja, e informe-o expresso no formato horas:minutos:segundos.

            Entrada
            O arquivo de entrada contém um valor inteiro N.

            Saída
            Imprima o tempo lido no arquivo de entrada (segundos), 
            convertido para horas:minutos:segundos, conforme exemplo fornecido.*/

        static void Main(string[] args)
        {
            var timeInSeconds = int.Parse(Console.ReadLine());

            int hours = 0;
            int minutes = 0;
            int seconds = 0;

            if (timeInSeconds > 3600)
            {
                hours = Convert.ToInt32(timeInSeconds / 3600);
                timeInSeconds -= hours * 3600;
            }

            if (timeInSeconds > 60)
            {
                minutes = Convert.ToInt32(timeInSeconds / 60);
                timeInSeconds -= minutes * 60;
            }

            seconds = timeInSeconds;

            Console.WriteLine($"{hours}:{minutes}:{seconds}", hours, minutes, seconds);
        }
    }
}
