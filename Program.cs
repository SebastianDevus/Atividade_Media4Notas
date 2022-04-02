double nota1, nota2, nota3, nota4, media;


Console.WriteLine(); // Espacamento

// Solicitando e armazenando notas
Console.Write("Digite a nota 1: ");
nota1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite a nota 1: ");
nota2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite a nota 1: ");
nota3 = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite a nota 1: ");
nota4 = Convert.ToInt32(Console.ReadLine());

// Validando as notas
bool nota1Invalida = nota1 < 0.0 || nota1 > 10.0;
bool nota2Invalida = nota2 < 0.0 || nota2 > 10.0;
bool nota3Invalida = nota3 < 0.0 || nota3 > 10.0;
bool nota4Invalida = nota4 < 0.0 || nota4 > 10.0;

Console.WriteLine(); // Espacamento

// Verificando a validade das notas
if (nota1Invalida || nota2Invalida || nota3Invalida || nota4Invalida)
{
    // Mensagem de erro, em vermelho, caso as notas digitadas sejam inválidas
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Por favor digite somente notas entre 0 e 10");   
    Console.ResetColor();
}
else // Se chegar a esse ponto, as notas são válidas
{
    // Calculando a média
    media = (nota1 + nota2 + nota3 + nota4) / 4;

    //Avaliando se o aluno foi reprovado (média menor que 5)
    if (media < 5)
    {
        // Exibindo média
        Console.WriteLine($"Sua média é {media:N1}.");
        
        // Informa que o aluno foi reprovado, em cor vermelha, e reseta a cor
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Resultado: REPROVADO");
        Console.ResetColor();
    }
    // Avaliando se o aluno foi aprovado (média maior que 6), ou ficara em recuperação (média entre 5 e 6)
    else if (media > 6)
    {
        // Exibindo média
        Console.WriteLine($"Sua média é {media:N1}.");

        // Informa que o aluno foi aprovado, em cor verde, e reseta a cor
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Resultado: APROVADO");
        Console.ResetColor();
    }
    else
    {
        // Exibindo média
        Console.WriteLine($"Sua média é {media:N1}.");     

        // Informa que o aluno foi aprovado, em cor amarela, e reseta a cor
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Resultado: EM RECUPERAÇÃO");
        Console.ResetColor();  
    }
}

Console.WriteLine(); // Espacamento