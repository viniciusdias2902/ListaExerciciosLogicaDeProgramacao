using ExerciciosLogicaProgramacao.Exercicios;
using Spectre.Console;

namespace ExercicioLogicaProgramacao;

class Program
{
    public static void Main(String[] args)
    {
        var questoesResolvidas = new List<Questao>();
        questoesResolvidas.Add(new PrimeiraQuestao());
        questoesResolvidas.Add(new SegundaQuestao());
        FigletText apresentacao = new("Questões Resolvidas");
        apresentacao.Centered();
        apresentacao.Color = Color.Red;
        foreach(var questao in questoesResolvidas)
        {
            AnsiConsole.WriteLine(questao.Enunciado);
        }
    }
}