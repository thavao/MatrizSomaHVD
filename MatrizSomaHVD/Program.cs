int qtdLinhas = 0, qtdColunas = 0;
int somaLinha = 0, somaColuna = 0, somaDiagonal = 0;
int linhaAtual = 0, colunaAtual = 0;

#region Funcoes 
int EscolherSoma()
{
    Console.WriteLine("Escolha em qual direção da matriz deseja somar: ");
    Console.WriteLine("1 - Linhas");
    Console.WriteLine("2 - Colunas");
    Console.WriteLine("3 - Diagonal 1");
    Console.WriteLine("4 - Diagonal 2");
    return int.Parse(Console.ReadLine());
}

int[,] DefinirTamanhoDaMatriz()
{
    Console.WriteLine("A quantidade de linhas e colunas devem ser maior que 0");

    do
    {
        Console.Write("Digite a quantidade linhas e colunas: ");
        qtdLinhas = int.Parse(Console.ReadLine());

    } while (qtdLinhas <= 0);

    qtdColunas = qtdLinhas;

    int[,] NovaMatriz = new int[qtdLinhas, qtdColunas];

    return NovaMatriz;
}


int[,] SortearMatriz(int[,] matrizFuncao)
{
    for (linhaAtual = 0; linhaAtual < qtdLinhas; linhaAtual++)
    {
        for (colunaAtual = 0; colunaAtual < qtdColunas; colunaAtual++)
        {
            matrizFuncao[linhaAtual, colunaAtual] = new Random().Next(0, 10);
        }
    }
    return matrizFuncao;
}


void ImprimirMatriz(int[,] matrizFuncao)
{
    Console.WriteLine("Matriz: ");
    for (linhaAtual = 0; linhaAtual < qtdLinhas; linhaAtual++)
    {
        Console.WriteLine();
        for (colunaAtual = 0; colunaAtual < qtdColunas; colunaAtual++)
        {
            Console.Write(matrizFuncao[linhaAtual, colunaAtual] + " ");
        }
    }
}

void SomarLinhas(int[,] matrizFuncao)
{
    Console.WriteLine();
    Console.WriteLine();
    for (linhaAtual = 0; linhaAtual < qtdLinhas; linhaAtual++)
    {
        somaLinha = 0;
        for (colunaAtual = 0; colunaAtual < qtdColunas; colunaAtual++)
        {
            somaLinha += matrizFuncao[linhaAtual, colunaAtual];
        }
        Console.WriteLine($"Soma da linha {linhaAtual}: {somaLinha}");
    }
}

void SomarColunas(int[,] matrizFuncao)
{
    Console.WriteLine();
    Console.WriteLine();
    for (colunaAtual = 0; colunaAtual < qtdLinhas; colunaAtual++)
    {
        somaColuna = 0;
        for (linhaAtual = 0; linhaAtual < qtdColunas; linhaAtual++)
        {
            somaColuna += matrizFuncao[linhaAtual, colunaAtual];
        }
        Console.WriteLine($"Soma da coluna {colunaAtual}: {somaColuna}");
    }
}


void SomarDiagonal1(int[,] matrizFuncao)
{
    somaDiagonal = 0;
    for (int i = 0; i < qtdLinhas; i++)
    {
        somaDiagonal += matrizFuncao[i, i];
    }

    Console.WriteLine();
    Console.WriteLine("Soma diagonal 1: " + somaDiagonal);
    Console.WriteLine();
}

void SomarDiagonal2(int[,] matrizFuncao)
{
    somaDiagonal = 0;
    for (linhaAtual = 0, colunaAtual = qtdLinhas - 1; linhaAtual < qtdLinhas; linhaAtual++, colunaAtual--)
    {
        somaDiagonal += matrizFuncao[linhaAtual, colunaAtual];
    }
    Console.WriteLine();
    Console.WriteLine("Soma diagonal 2: " + somaDiagonal);
    Console.WriteLine();
}

#endregion


//inicio do programa

int[,] matriz = DefinirTamanhoDaMatriz();
matriz = SortearMatriz(matriz);

do
{
    ImprimirMatriz(matriz);
    Console.WriteLine();
    Console.WriteLine();
    switch (EscolherSoma())
    {
        case 1:
            SomarLinhas(matriz);
            break;
        case 2:
            SomarColunas(matriz);
            break;
        case 3:
            SomarDiagonal1(matriz);
            break;
        case 4:
            SomarDiagonal2(matriz);
            break;
        default:
            Console.WriteLine("Opção inválida");
            Console.WriteLine();
            break;
    }
    Console.WriteLine("Pressione Enter para continuar...");
    Console.ReadLine();
    Console.Clear();
} while (true);