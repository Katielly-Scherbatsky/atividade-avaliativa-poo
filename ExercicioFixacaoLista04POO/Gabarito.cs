public class Gabarito
{
    public Gabarito(int numeroQuestoes)
    {
        Alternativas = new List<Questao>();

        GerarGabarito(numeroQuestoes);
    }

    private void GerarGabarito(int numeroQuestoes)
    {
        for (int i = 0; i < numeroQuestoes; i++)
        {
            Alternativas.Add(new Questao(i + 1));
        }
    }

    public List<Questao> Alternativas;

    public string RepostaQuestao(int numeroQuestao)
    {
        Questao questao = BuscarQuestao(numeroQuestao);

        return questao.RetornaReposta();
    }

    private Questao BuscarQuestao(int numeroQuestao)
    {
        return Alternativas.FirstOrDefault(x => x.RetornaNumeroQuestao() == numeroQuestao);
    }

}

public class Questao
{
    private string _resposta;
    private int _numeroQuestao;

    public Questao(int numeroQuestao)
    {
        _numeroQuestao = numeroQuestao;

        _resposta = GerarResposta();
    }

    private string GerarResposta()
    {
        Random rnd = new Random();
        char randomChar = (char)rnd.Next('a', 'e');

        return randomChar.ToString().ToUpper();
    }

    public string RetornaReposta()
    {
        return _resposta;
    }

    public int RetornaNumeroQuestao()
    {
        return _numeroQuestao;
    }
}