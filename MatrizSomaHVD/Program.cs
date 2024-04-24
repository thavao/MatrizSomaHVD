int qtdLinhas = 3, qtdColunas = 3;
int[,] matriz = new int[qtdLinhas, qtdColunas];
int somaLinha = 0, somaColuna = 0, somaDiagonal = 0;
int linhaAtual = 0, colunaAtual = 0;

for (linhaAtual = 0; linhaAtual < qtdLinhas; linhaAtual++)
{
    for(colunaAtual = 0; colunaAtual < qtdColunas; colunaAtual++)
    {
        matriz[linhaAtual, colunaAtual] = new Random().Next(0, 10);
    }
}

Console.WriteLine("Matriz: ");
for (linhaAtual = 0; linhaAtual < qtdLinhas; linhaAtual++)
{
    Console.WriteLine();
    for (colunaAtual = 0; colunaAtual < qtdColunas; colunaAtual++)
    {
        Console.Write(matriz[linhaAtual, colunaAtual] + " ");
    }
}
Console.WriteLine();
Console.WriteLine();

//soma linha
for (linhaAtual = 0; linhaAtual < qtdLinhas; linhaAtual++)
{
    somaLinha = 0;
    for (colunaAtual = 0; colunaAtual < qtdColunas; colunaAtual++)
    {
        somaLinha += matriz[linhaAtual, colunaAtual];
    }
    Console.WriteLine($"Soma da linha {linhaAtual}: {somaLinha}");
}
Console.WriteLine();
Console.WriteLine();

//soma coluna
for (colunaAtual = 0; colunaAtual < qtdLinhas; colunaAtual++)
{
    somaColuna = 0;
    for (linhaAtual = 0; linhaAtual < qtdColunas; linhaAtual++)
    {
        somaColuna += matriz[linhaAtual, colunaAtual];
    }
    Console.WriteLine($"Soma da coluna {colunaAtual}: {somaColuna}");
}
Console.WriteLine();
Console.WriteLine();



//soma diagonal 1
for (int i = 0; i < qtdLinhas; i++)
{
    somaDiagonal += matriz[i,i];
}

Console.WriteLine("Soma diagonal 1: " + somaDiagonal );
Console.WriteLine();

// soma diagonal 2
somaDiagonal = 0;
for (linhaAtual = 0, colunaAtual = qtdLinhas-1; linhaAtual < qtdLinhas; linhaAtual++ , colunaAtual--)
{
    somaDiagonal += matriz[linhaAtual, colunaAtual];
}
Console.WriteLine("Soma diagonal 2: " + somaDiagonal);
Console.WriteLine();

Console.WriteLine("Pressione Enter para encerrar...");
Console.ReadLine();