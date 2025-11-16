using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            
  
            int[] inteiros = new int[3];

            for (int i = 0; i < inteiros.Length; i++)
            {
                inteiros[i] = int.Parse(Console.ReadLine());
            }

            int maior = inteiros[0];
            int menor = inteiros[0];

            for (int i = 0; i < inteiros.Length; i++)
            {
             
                if (inteiros[i] > maior)
                {
                    maior = inteiros[i];
                }

                if (inteiros[i] < menor)
                {
                    menor = inteiros[i];
                }
            }
            
            int meio = inteiros.Sum() - maior - menor;

            Console.Write(maior);
            Console.Write(meio);
            Console.Write(menor);
        }
    }
}
