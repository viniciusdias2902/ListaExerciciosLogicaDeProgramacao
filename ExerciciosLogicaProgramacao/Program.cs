using ExerciciosLogicaProgramacao.Exercicios;

namespace ExercicioLogicaProgramacao;

class Program
{
    public static void Main(String[] args)
    {
       var questoesResolvidas = new List<Questao>();
       questoesResolvidas.Add(new PrimeiraQuestao());
       foreach(var questao in questoesResolvidas)
       {
            Console.WriteLine(questao.Enunciado);
            questao.Resolucao();
       }
    }
}