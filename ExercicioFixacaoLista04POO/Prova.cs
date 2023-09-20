public class Prova
{
    public Prova(Gabarito gabarito)
    {
        _gabarito = gabarito;
    }

    private Gabarito _gabarito;
    private int _acertos = 0;

    public List<string> Respostas { get; set; } = new List<string>();

    public void RespostaAluno(string resposta)
    {
        Respostas.Add(resposta.ToUpper());
        CalcularAcertos();
    }

    private void CalcularAcertos()
    {
        int numeroQuestao = 1;
        _acertos = 0;

        foreach (string resposta in Respostas)
        {
            if (_gabarito.RepostaQuestao(numeroQuestao) == resposta)
            {
                _acertos++;
            }

            numeroQuestao++;
        }
    }

    public int Acertos()
    {
        return _acertos;
    }

    public int Nota()
    {
        return _acertos;
    }

    public int Maior()
    {

        return ;
    }
}