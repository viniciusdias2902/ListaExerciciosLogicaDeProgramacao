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
        exerciciosResolvidos.Add(new TerceiroExercicio());
        exerciciosResolvidos.Add(new QuartoExercicio());
        exerciciosResolvidos.Add(new QuintoExercicio());
        exerciciosResolvidos.Add(new SextoExercicio());
        // Configurações estéticas

        Style estiloNumeroExercicio = new Style(foreground: Color.Blue, decoration: Decoration.Bold);
        Style estiloEnunciadoExercicio = new Style(foreground: Color.Purple, decoration: Decoration.SlowBlink);
        FigletText apresentacao = new("Exercícios Resolvidos");
        apresentacao.Centered();
        apresentacao.Color = Color.Red;
        AnsiConsole.Write(apresentacao);
        AnsiConsole.WriteLine("");

        for (int i = 0; i < exerciciosResolvidos.Count; i++)
        {
            AnsiConsole.Write(new Markup($"{i+1} - ", style: estiloNumeroExercicio));
            AnsiConsole.Write(new Markup(exerciciosResolvidos[i].Enunciado + "\n", style: estiloEnunciadoExercicio));

        }

        AnsiConsole.WriteLine("");

        while (true)
        {
            int opcao = AnsiConsole.Prompt(new TextPrompt<int>("Digite o número do exercício para ter acesso a sua resolução ou 0 para encerrar o programa: "));
            if (opcao == 0)
            {
                break;
            }else if (opcao < 0 || opcao > exerciciosResolvidos.Count())
            {
                continue;
            }else
            {
                exerciciosResolvidos[opcao-1].Resolucao();
            }
        }
     }
}