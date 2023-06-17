Console.Clear();

void dialog(string mensagem)
{
    Console.WriteLine(mensagem);
}

yellow();
dialog("--- Caixa Eletrônico ---");
reset();

blue();
dialog("\nNotas disponíveis para saque: 1, 2, 5, 10, 20, 50, 100 e 200 reais");

dialog("\nDigite o valor a ser sacado...: ");
reset();

red();
string valueA = Console.ReadLine()!;

if (!int.TryParse(valueA, out int value) || (value == 0 && valueA.Length == 1) || valueA.Contains(","))
{
    
    dialog("\nValor não pode ser 0 e não pode conter centavos!!");
    reset();
} 
else
{
    int[] grade = { 200, 100, 50, 20, 10, 5, 2, 1 };

    yellow();
    dialog("\nO caixa deve entregar:");

    foreach (int note in grade)
    {
        int quantidadegrade = value / note;
        if (quantidadegrade > 0)
        {
            dialog($"{quantidadegrade} nota(s) de R${note}");
            

            value %= note;
        }
    }
}
reset();

void reset()
{
    Console.ResetColor();
}

void blue()
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
}

void red()
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
}

void yellow()
{
    Console.ForegroundColor = ConsoleColor.Yellow;
}
