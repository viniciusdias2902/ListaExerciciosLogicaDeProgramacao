using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogicaProgramacao.Exercicios
{
     class DecimoExercicio : Exercicio
    {
        public override string Enunciado { get; } = "Faça um algoritmo que leia três notas obtidas por um aluno, e imprima na tela a média das notas";

        public override void Resolucao()
        {
            double[] notas = new double[3];
            for (int i = 0; i < notas.Length; i++)
            {
                notas[i] = double.Parse(Console.ReadLine());
            }
            double media = (notas[0] + notas[1] + notas[2]) / 3;
            Console.WriteLine(media);
        }
    }
}
