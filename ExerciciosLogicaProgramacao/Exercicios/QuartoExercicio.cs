using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogicaProgramacao.Exercicios
{
     class QuartoExercicio : Exercicio
    {
        public override string Enunciado { get;  } = "Faça um algoritmo que receba um número inteiro e imprima na tela o seu antecessor e o seu sucessor.";
        public override void Resolucao()
        {
            int numeroInteiro = int.Parse(Console.ReadLine());
            Console.WriteLine($"Antecessor: {numeroInteiro - 1}");
            Console.WriteLine($"Sucessor: {numeroInteiro + 1}");
        }
    }
}
