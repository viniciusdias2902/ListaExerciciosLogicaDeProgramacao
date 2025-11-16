using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogicaProgramacao.Exercicios
{
    class DecimoPrimeiroExercicio : Exercicio
    {
        public override string Enunciado { get; } = "Faça um algoritmo que leia quatro notas obtidas por um aluno, calcule a média das nota obtidas, imprima na tela o nome do aluno e se o aluno foi aprovado ou reprovado. Para o aluno ser considerado aprovado sua média final deve ser maior ou igual a 7.";

        public override void Resolucao()
        {
            double[] notas = new double[4];
            double somaNotas = 0;
            Console.Write("Nome do aluno: ");
            string nomeAluno = Console.ReadLine();
            for (int i = 0; i < notas.Length; i++)
            {
                notas[i] = double.Parse(Console.ReadLine());
            }
            foreach (double nota in notas)
            {
                somaNotas += nota;
            }
            double media = somaNotas / notas.Length;
            Console.WriteLine($"Média: {media}");
            if (media >=7)
            {
                Console.WriteLine($"Parabéns, {nomeAluno}, você passou!");
            }else
            {
                Console.WriteLine($"Infelizmente, {nomeAluno}, você não passou.");
            }
        } 
    }
}
