using System.ComponentModel;

double BonusB;             //Percentual de bônus
double RetornoA;           //Percentual de Retorno
   int transfer;           //Pontos a transferir
   int ReduzirOrigem;      //Pontos a reduzir na origem
   int AcrescentarDestino; //Pontos a Acrescentar no destino
   int ContaOrigem;        //Pontos restantes na conta de origem
      
Console.Clear();

    Console.WriteLine("Este programa irá calcular sua transferência de milhas numa promoção de bônus e pontos de volta");
Thread.Sleep(2000);

Console.WriteLine();

    Console.Write("Qual o percentual de bônus da promoção?... ");
BonusB = Convert.ToDouble(Console.ReadLine());

    Console.Write("Qual o percental de Retorno?.............. ");
RetornoA = Convert.ToDouble(Console.ReadLine());

    Console.Write("Quantos pontos deseja tranferir?.......... ");
transfer = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

                ReduzirOrigem = Convert.ToInt32(transfer - (RetornoA/100) * transfer);
            Thread.Sleep(900);
        Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Pontos a reduzir na origem............ {ReduzirOrigem}");
Console.ResetColor();

                AcrescentarDestino = Convert.ToInt32(transfer + (BonusB/100) * transfer);
            Thread.Sleep(900);
        Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Pontos a acrescentar no destino....... {AcrescentarDestino}");
Console.ResetColor();

Console.WriteLine();

Console.WriteLine("-------------------------------------------------------------");

ContaOrigem = Convert.ToInt32(transfer - ReduzirOrigem);
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"A conta de origem ainda ficará com...... {ContaOrigem}");
Console.WriteLine($"A conta de destino ficará com........... {AcrescentarDestino}");
Console.ResetColor();

Console.WriteLine("-------------------------------------------------------------");

Console.WriteLine();