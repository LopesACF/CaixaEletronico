Console.Clear();

cyan();
dialog("--- Caixa Eletrônico ---", 75);
reset();

yellow();
dialog($"\nNotas disponíveis para saque: 1, 2, 5, 10, 20, 50, 100 e 200 reais", 50);
reset();

blue();
dialog("\nDigite o valor a ser sacado...: ", 50);
reset();

green();
string valueA = Console.ReadLine()!;

if (!int.TryParse(valueA, out int value) || (value == 0 && valueA.Length == 1) || valueA.Contains(","))
{
    
    dialog("\nValor não pode ser 0 e não pode conter centavos!!", 50);
    reset();
} 
else
{
    int[] grade = {200, 100, 50, 20, 10, 5, 2, 1 };

    yellow();
    dialog("\nO caixa deve entregar: \n", 50);
    
    green();
    foreach (int note in grade)
    {
        int quantidadegrade = value / note;
        if (quantidadegrade > 0)
        {
            dialog($"\n{quantidadegrade} nota(s) de R${note}", 75);
            

            value %= note;
        }
    }
}
reset();

void dialog(string texto, int intervalo)
{
    foreach (char c in texto)
    {
        Console.Write(c);
        Thread.Sleep(intervalo);
    }
}

void reset()
{
    Console.ResetColor();
}

void green()
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
}

void cyan()
{
    Console.ForegroundColor = ConsoleColor.Cyan;
}

void blue()
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
}

void yellow()
{
    Console.ForegroundColor = ConsoleColor.Yellow;
}