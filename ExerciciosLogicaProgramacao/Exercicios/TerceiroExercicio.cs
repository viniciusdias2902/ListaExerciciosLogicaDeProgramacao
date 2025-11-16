using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogicaProgramacao.Exercicios
{
    internal class TerceiroExercicio : Exercicio
    {
        public override string Enunciado { get; } = "Faça um algoritmo que leia dois valores inteiros A e B, se os valores de A e B forem iguais, deverá somar os dois valores, caso contrário devera multiplicar A por B. Ao final de qualquer um dos cálculos deve-se atribuir o resultado a uma variável C e imprimir seu valor na tela.";
        public override void Resolucao()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c;
            if (a == b)
            {
                c = a + b;
            }else
            {
                c = a * b;
            }
            Console.WriteLine(c);
        }
    }
}
