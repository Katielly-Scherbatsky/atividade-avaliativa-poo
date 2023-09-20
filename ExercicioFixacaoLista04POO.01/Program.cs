Console.Write("Informe o número máximo de poltronas do voo: ");
int numeroMaximoPoltronas = Convert.ToInt16(Console.ReadLine());

Console.Write("Informe a data e o horário do voo: \n(formato data e hora: 00/00/0000 00:00): ");
DateTime dataVoo = Convert.ToDateTime(Console.ReadLine());

Console.Write("Informe o número do voo: ");
int numeroVoo = Convert.ToInt32(Console.ReadLine());

Voo voo = new Voo(numeroVoo, dataVoo, numeroMaximoPoltronas);
int opcao = 0;

do
{
    Menu();
    opcao = Convert.ToInt16(Console.ReadLine());

    if(opcao == 1)
    {
        Console.Write("\nDigite o número da poltrona: ");
        int numeroPoltrona = Convert.ToInt16(Console.ReadLine());

        bool numeroPoltronaValida = numeroPoltrona <= numeroMaximoPoltronas;

        if (numeroPoltronaValida)
        {
            if (voo.Ocupa(numeroPoltrona))
            {
                Console.WriteLine($"Poltrona escolhida: {numeroPoltrona}!");
            }
            else
            {
                Console.WriteLine($"Poltrona {numeroPoltrona} já esta ocupada!");
            }
        }
        else
        {
            Console.WriteLine("Número da poltrona não existe!");
        }

        
    }
    else if(opcao == 2)
    { 
        Console.Write("\nDigite o número da poltrona: ");
        int numeroPoltrona = Convert.ToInt16(Console.ReadLine());

        if (voo.Verifica(numeroPoltrona))
        {
            Console.WriteLine($"Poltrona {numeroPoltrona} ocupada!");
        }
        else
        {
            Console.WriteLine($"Poltrona {numeroPoltrona} livre!");
        }
    }
    else if(opcao == 3)
    {
        Console.WriteLine($"\nProxima poltrona livre: {voo.ProximoLivre()}");
    }
    else if(opcao == 4)
    {
        Console.WriteLine($"\nVagas disponíveis no voo: {voo.Vagas()}");

    }
    else if(opcao == 5)
    {
        Console.WriteLine($"\nData e hora do voo: {voo.GetData()}");
        Console.WriteLine($"Número do voo: {voo.GetVoo()}");
    }
    else if(opcao == 0)
    {
        Console.WriteLine("\nEncerrado!");
    }
    else
    {
        Console.WriteLine("\nOpção inválida!");
    }

}
while (opcao != 0) ;

void Menu()
{
    Console.Write("\n0 para sair \n" +
        "1 para Ocupar Poltrona \n" +
        "2 para Verificar Poltrona \n" +
        "3 para Ver a Proxima Poltrona Livre \n" +
        "4 para Ver a Quantidade de Poltronas Vagas \n" +
        "5 para Ver Informações do Voo \n" +
        "Insira o número de uma das opções acima: ");
}