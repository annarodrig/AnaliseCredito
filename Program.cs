int  parcelas;
double valorSolicitado,  rendaMensal, valorParcela, calculo;

Console.WriteLine("-- Solicitação de empréstimo --");

Console.Write("\nInforme o valor solicitado:");
valorSolicitado = Convert.ToDouble(Console.ReadLine()!);

Console.Write("\nInforme a quantidade de parcelas que deseja:");
parcelas = Convert.ToInt32(Console.ReadLine()!);

Console.Write("\nInforme o valor de sua renda mensal comprovada:");
rendaMensal = Convert.ToDouble(Console.ReadLine()!);

valorParcela = valorSolicitado / parcelas;

Console.WriteLine($"\nVocê solicitou o valor de R${valorSolicitado} em {parcelas}X de R${valorParcela}\n");

calculo = rendaMensal * 0.3;

if (valorParcela > calculo)
{
    Console.ForegroundColor=ConsoleColor.Red;
    Console.WriteLine($"--- Seu empréstimo foi negado! ---");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor=ConsoleColor.Green;
    Console.WriteLine("--- Seu empréstimo foi aprovado! ---");
    Console.ResetColor();
}

Console.WriteLine("\nObrigado por utilizar nossos serviços!");