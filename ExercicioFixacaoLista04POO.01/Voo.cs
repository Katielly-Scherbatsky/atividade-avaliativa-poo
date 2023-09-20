public class Voo
{
    public int numeroMaximoPoltrona;
    public int numeroDoVoo;
    public DateTime dataDoVoo;

    public List<bool> poltronas;

    public Voo(int numeroDoVoo, DateTime dataDoVoo, int numeroMaximoPoltrona)
    {
        this.numeroDoVoo = numeroDoVoo;
        this.dataDoVoo = dataDoVoo;
        this.numeroMaximoPoltrona = numeroMaximoPoltrona;
        poltronas = new List<bool>(new bool[numeroMaximoPoltrona]);
    }

    public bool Ocupa(int numeroPoltrona)
    {
        
        if (poltronas[numeroPoltrona - 1] == true)
        {
            return false;
        }
        else
        {
            poltronas[numeroPoltrona - 1] = true;
            return true;
        }
    }

    public bool Verifica(int numeroPoltrona)
    {
        return poltronas[numeroPoltrona - 1];
    }

    public int ProximoLivre()
    {
        for (int i = 0; i < poltronas.Count; i++)
        {
            if (poltronas[i] == false)
            {
                return i + 1;
            }
        }
        return 0;
    }

    public int Vagas()
    {
        int contador = 0;

        for (int i = 0; i < poltronas.Count; i++)
        {
            if (poltronas[i] == false)
            {
                contador++;
            }
        }
        return contador;
    }

    public int GetVoo()
    {
        return numeroDoVoo;
    }

    public DateTime GetData()
    {
        return dataDoVoo;
    }
}