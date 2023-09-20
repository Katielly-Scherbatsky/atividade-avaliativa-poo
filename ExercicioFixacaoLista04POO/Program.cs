int numeroDeQuestoes = 10;

Gabarito gabarito = new Gabarito(numeroDeQuestoes);
List<Prova> provas = new List<Prova>();

Console.Write("Quantos Alunos Farão a prova? ");
int numeroDeAlunos = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

for (int i = 0; i < numeroDeAlunos; i++)
{
    Console.WriteLine($"Prova Aluno: {i + 1}");

    Prova prova = new Prova(gabarito);
    provas.Add(prova);

    for (int numeroQuestao = 0; numeroQuestao < numeroDeQuestoes; numeroQuestao++)
    {
        Console.Write($"Resposta Questão {numeroQuestao + 1}: ");
        string resposta = Console.ReadLine();
        prova.RespostaAluno(resposta);
    }

    Console.WriteLine();
}

int idAluno = 1;

foreach (Prova prova in provas)
{

    Console.WriteLine($"Prova Aluno: {idAluno}");
    Console.WriteLine($"Acertos: {prova.Acertos()}");
    Console.WriteLine($"Nota: {prova.Nota()}");
    idAluno++;

    Console.WriteLine();
}

Console.ReadKey();