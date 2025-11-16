using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogicaProgramacao.Exercicios
{
     class QuintoExercicio : Exercicio
    {
        public override string Enunciado { get; } = "Faça um algoritmo que leia o valor do salário mínimo e o valor do salário de um usuário, calcule quantos salários mínimos esse usuário ganha e imprima na tela o resultado. (Base para o Salário mínimo R$ 1.293,20).";

        public override void Resolucao()
        {
            double salarioMinimo = 1293.20;
            double salarioUsuario = double.Parse(Console.ReadLine());
            double quantidadeSalariosMinimos = salarioUsuario / salarioMinimo;
            Console.WriteLine($"O usuário ganha {quantidadeSalariosMinimos} vezes o salário mínimo");

        }
    }
}
