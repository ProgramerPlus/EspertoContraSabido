Console.Clear();
Console.WriteLine("--- Esperto Contra Sabido ---\n");

Console.Write("Quantos alimentos serão distribuídos? ");
int total = Convert.ToInt32(Console.ReadLine()!);

// ➤ NÃO FAÇA NADA se o número for menor ou igual a zero
if (total <= 0)
    return;

int recebidosPicaPau = 0;
int recebidosRaposinha = 0;

int rodada = 1;

while (total > 0)
{
    // Quantidade que Pica-Pau receberia na rodada
    int paraVoce = rodada;

    if (paraVoce > total)
        paraVoce = total; // pega só o que resta

    total -= paraVoce;
    recebidosPicaPau += paraVoce;

    Console.Write($"{paraVoce} para você. ");

    // Agora os itens da Raposinha
    int paraMim = rodada;

    if (paraMim > total)
        paraMim = total;

    if (paraMim > 0)
    {
        Console.Write("1");
        recebidosRaposinha++;
    }

    for (int i = 2; i <= paraMim; i++)
    {
        Console.Write($", {i}");
        recebidosRaposinha++;
    }

    Console.WriteLine(" para mim.");

    total -= paraMim;

    rodada++;
}

Console.WriteLine();
Console.WriteLine($"Pica-pau recebeu {recebidosPicaPau} alimento(s).");
Console.WriteLine($"Raposinha recebeu {recebidosRaposinha} alimento(s).");
