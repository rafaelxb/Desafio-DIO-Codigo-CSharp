﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafiosCodigoCSharpDio
{
    class Validação_de_Nota
    {
        /*Desafio
            Para ajudar a calcular as notas referentes às 
            duas avaliações dos alunos, uma professora pediu 
            para que você desenvolva um programa que calcule 
            e imprima a média semestral. Faça com que o algoritmo
            só aceite notas válidas (uma nota válida deve pertencer 
            ao intervalo [0,10]). Cada nota deve ser validada separadamente.

            Entrada
            A entrada contém vários valores reais, positivos ou negativos. 
            O programa deve ser encerrado quando forem lidas duas notas válidas.

            Saída
            Se uma nota inválida  for lida, deve ser impressa a mensagem "nota invalida".
            Quando duas notas válidas forem lidas, deve ser impressa a mensagem 
            "media = " seguido do valor do cálculo. O valor deve ser apresentado 
            com duas casas após o ponto decimal.*/

        static void Main(string[] args)
        {

            double notaDigitada, notaSomada = 0;
            int notaValida = 0;

            while (notaValida < 2)
            {
                notaDigitada = double.Parse(Console.ReadLine());

                if ((notaDigitada >= 0) && (notaDigitada <= 10))
                {
                    notaValida += 1;
                    notaSomada += notaDigitada;
                }
                else
                {
                    Console.WriteLine("nota invalida");
                }
            }

            Console.WriteLine("media = " + (notaSomada / 2).ToString("F2"));
        }
    }
}
