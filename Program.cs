using System;

class Program
{  // 1)

    static void Main()
    {
        Console.Write("Informe um número: ");
        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            bool pertence = VerificaFibonacci(numero);
            // Exiba o resultado
            if (pertence)
            {
                Console.WriteLine($"O {numero} pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine($"O {numero} não pertence à sequência de Fibonacci.");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Informe um número inteiro.");
        }
    }

    static bool VerificaFibonacci(int numero)
    {
        int fib1 = 0;
        int fib2 = 1;

        if (numero == fib1 || numero == fib2)
        {
            return true;
        }

        int fibAtual = fib1 + fib2;
        while (fibAtual <= numero)
        {
            if (fibAtual == numero)
            {
                return true;
            }
            fib1 = fib2;
            fib2 = fibAtual;
            fibAtual = fib1 + fib2;
        }

        // Se o número não foi encontrado na sequência, retorne falso
        return false;
    }
}


