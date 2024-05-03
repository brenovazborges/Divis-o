double numerador, denominador, quociente;
Console.WriteLine("--- ATIVIDADE DE DIVISÃO ---");

Console.Write("Digite o Numerador....:");
numerador = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o Denominador....:");
denominador = Convert.ToDouble(Console.ReadLine());

quociente = numerador / denominador;



if (denominador == 0)
{
    Console.WriteLine("Não é possível dividir por zero.");
   return;
}

 Console.WriteLine($"O resultado é {quociente} ");

