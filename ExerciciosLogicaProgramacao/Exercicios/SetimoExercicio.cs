using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogicaProgramacao.Exercicios
{
     class SetimoExercicio : Exercicio
    {
        public override string Enunciado { get; } = "Faça um algoritmo que leia dois valores booleanos (lógicos) e determine se ambos são VERDADEIRO ou FALSO.";
        public override void Resolucao()
        {
            bool valorBooleano1 = bool.Parse(Console.ReadLine());
            bool valorBooleano2 = bool.Parse(Console.ReadLine());
            if (valorBooleano1 && valorBooleano2)
            {
                Console.WriteLine("Ambos são verdadeiros");
            }else if (!valorBooleano1 && !valorBooleano2)
            {
                Console.WriteLine("Ambos são falsos");
            }else
            {
                Console.WriteLine("Os dois valores são diferentes");
            }
        }
    }
}
