using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogicaProgramacao.Exercicios
{
    internal class NonoExercicio : Exercicio
    {
        public override string Enunciado { get; } = "Faça um algoritmo que calcule o IMC (Índice de Massa Corporal) de uma pessoa, leia o seu peso e sua altura e imprima na tela sua condição";

        public override void Resolucao()
        {
            double peso = double.Parse(Console.ReadLine());
            double altura = double.Parse(Console.ReadLine());
            double imc = peso / (altura * altura);
            if (imc < 18.5)
            {
                Console.WriteLine("Abaixo do peso");
            }else if (imc >=18.5 && imc <= 24.9)
            {
                Console.WriteLine("Peso normal");
            }else if (imc >= 25.0 && imc <= 29.9)
            {
                Console.WriteLine("Excesso de peso");
            }else if (imc >= 30.0 && imc <= 34.9)
            {
                Console.WriteLine("Obesidade classe 1");
            }else if (imc >= 35.0 && imc <= 39.9)
            {
                Console.WriteLine("Obesidade classe 2");
            }else if (imc >= 40)
            {
                Console.WriteLine("Obesidade classe 3");
            }
        }
    }
}
