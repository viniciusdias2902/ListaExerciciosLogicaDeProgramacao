using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosLogicaProgramacao.Exercicios
{
    class PrimeiraQuestao : Questao
    {
        private static string Enunciado = "Faça um algoritmo que leia os valores de A, B, C" +
            "e em seguida imprima na tela a soma entre A e B é mostre se a soma é menor que C.";
        
        public static void Resolucao()
        {
            Console.WriteLine(Enunciado);
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int somaDoisPrimeirosValores = a + b;
            if (somaDoisPrimeirosValores > c) {
                Console.WriteLine($"A soma dos valores a e b resulta em {somaDoisPrimeirosValores} e é maior do que {c}");
            }else if(somaDoisPrimeirosValores < b)
            {
                Console.WriteLine($"A soma dos valores a e b resulta em {somaDoisPrimeirosValores} e é menor do que {c}");
            }else {
                Console.WriteLine($"A soma dos valores a e b resulta em {somaDoisPrimeirosValores} e é igual a {c}");
            }
        }
    }
}
