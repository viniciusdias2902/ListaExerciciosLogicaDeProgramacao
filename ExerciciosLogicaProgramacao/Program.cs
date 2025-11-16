using ExerciciosLogicaProgramacao.Exercicios;
using Spectre.Console;

namespace ExercicioLogicaProgramacao;

class Program
{
    public static void Main(String[] args)
    {
        var exerciciosResolvidos = new List<Exercicio>();
        exerciciosResolvidos.Add(new PrimeiroExercicio());
        exerciciosResolvidos.Add(new SegundoExercicio());
        FigletText apresentacao = new("Exercícios Resolvidos");
        apresentacao.Centered();
        apresentacao.Color = Color.Red;
        AnsiConsole.Write(apresentacao);
    }
}