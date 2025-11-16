using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogicaProgramacao.Exercicios
{
     class OitavoExercicio : Exercicio
    {
        public override string Enunciado { get; } = "Faça um algoritmo que leia três valores inteiros diferentes e imprima na tela os valores em ordem decrescente.";
        public override void Resolucao()
        {
            int maior = 0;
            int meio = 0;
            int menor = 0;
            int[] inteiros = new int[3];

            for (int i = 0; i < inteiros.Length; i++)
            {
                inteiros[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < (inteiros.Length - 1); i++)
            {
                if (inteiros[i] > inteiros[i+1])
                {
                    maior = inteiros[i];
                }
            }

            for (int i = 0; i < (inteiros.Length - 1); i++)
            {
                if (inteiros[i] < inteiros[i + 1])
                {
                    menor = inteiros[i];
                }
            }

            for (int i = 0; i < inteiros.Length; i++)
            {
                if (inteiros[i] > menor && inteiros[i] < maior)
                {
                    meio = inteiros[i];
                }
            }

            Console.WriteLine(maior);
            Console.WriteLine(meio);
            Console.WriteLine(menor);
        }
    }
}
