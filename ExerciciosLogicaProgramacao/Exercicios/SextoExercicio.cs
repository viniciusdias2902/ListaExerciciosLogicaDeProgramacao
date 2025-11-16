using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogicaProgramacao.Exercicios
{
     class SextoExercicio : Exercicio
    {
        public override string Enunciado { get; } = " Faça um algoritmo que leia um valor qualquer e imprima na tela com um reajuste de 5%.";
        public override void Resolucao()
        {
            double valor = double.Parse(Console.ReadLine());
            double valorReajustado = valor + (valor * 0.05);
            Console.WriteLine(valorReajustado);
        }
    }
}
