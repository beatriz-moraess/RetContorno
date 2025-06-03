Console.Clear();

int altura = 0;
int largura = 0;

Console.Write("Olá, para fazer o retângulo digite a altura: ");
altura = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Agora, digite a largura: ");
largura = Convert.ToInt32(Console.ReadLine()!);

for (int i = 0; i < altura; i++)
{
    for (int j = 0; j < largura; j++)
    {
        if ( i == 0 || j == 0  || i == altura - 1 || j == largura - 1)
        {
            Console.Write("*");
        }
        else
        {
            Console.Write(" ");
        }
    }
            
    Console.WriteLine();
}

    