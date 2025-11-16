using ExerciciosLogicaProgramacao.Exercicios;
using Spectre.Console;

namespace ExercicioLogicaProgramacao;

class Program
{
    public static void Main(String[] args)
    {
        
        // Adição de questões resolvidas na lista

        var exerciciosResolvidos = new List<Exercicio>();
        exerciciosResolvidos.Add(new PrimeiroExercicio());
        exerciciosResolvidos.Add(new SegundoExercicio());

        // Configurações estéticas

        Style estiloNumeroExercicio = new Style(foreground: Color.Blue, decoration: Decoration.Bold);
        Style estiloEnunciadoExercicio = new Style(foreground: Color.Purple, decoration: Decoration.SlowBlink);
        FigletText apresentacao = new("Exercícios Resolvidos");
        apresentacao.Centered();
        apresentacao.Color = Color.Red;
        AnsiConsole.Write(apresentacao);



        for (int i = 0; i < exerciciosResolvidos.Count; i++)
        {
            AnsiConsole.Write(new Markup($"{i+1} - ", style: estiloNumeroExercicio));
            AnsiConsole.Write(new Markup(exerciciosResolvidos[i].Enunciado + "\n", style: estiloEnunciadoExercicio));
        }
    }
}