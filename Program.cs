int  parcelas;
decimal valorSolicitado,  rendaMensal, valorParcela;

Console.WriteLine("-- Solicitação de empréstimo --");

Console.Write("\nInforme o valor solicitado:");
valorSolicitado = Convert.ToDecimal(Console.ReadLine()!);

Console.Write("\nInforme a quantidade de parcelas que deseja:");
parcelas = Convert.ToInt32(Console.ReadLine()!);

Console.Write("\nInforme o valor de sua renda mensal comprovada:");
rendaMensal = Convert.ToDecimal(Console.ReadLine()!);

valorParcela = valorSolicitado / parcelas;



