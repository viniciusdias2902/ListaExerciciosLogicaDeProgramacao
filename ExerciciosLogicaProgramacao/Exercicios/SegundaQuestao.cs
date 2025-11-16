using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ExerciciosLogicaProgramacao.Exercicios
{
    internal class SegundaQuestao : Questao
    {
        public override string Enunciado { get; } = "2 - Faça um algoritmo para receber um número" +
            " qualquer e imprimir na tela se o número é par ou ímpar, positivo ou negativo.";
        public override void Resolucao()
        {
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine(AnalisarNumero(numero));
        }
        private string AnalisarNumero(int numero)
        {
            String analiseNumero = "";
            if (numero % 2 == 0)
            {
                analiseNumero = "O número é par ";
            }
            else
            {
                analiseNumero = "O número é ímpar ";
            }

            if (numero > 0)
            {
                analiseNumero += "e positivo"; 
            }
            else
            {
                analiseNumero += "e negativo";
            }

            if (numero == 0)
            {
                analiseNumero = "O número é zero";
            }

            return analiseNumero;
        }
    }
}
