using System.Numerics;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите несколько целых чисел.\nЧтобы продолжить, введите любое не число.");

        LinkedList<int> nums = [];
        while (true)
        {
            try
            {
                nums.AddLast(int.Parse(Console.ReadLine()));
            }
            catch
            {
                break;
            }
        }

        FindMinimalsSummirize([.. nums]);
    }

    public static int FindMinimalsSummirize(int[]? numeros = null)
    {
        ArgumentNullException.ThrowIfNull(numeros);
        ArgumentOutOfRangeException.ThrowIfGreaterThan(numeros.Length, 100, nameof(numeros));
        if (numeros.Length == 0)
            throw new ArgumentException("Числа не предоставлены", nameof(numeros));

        int firstMinimal = int.MaxValue;
        int secondMinimal = int.MaxValue;

        int firstIndex = int.MaxValue;
        int secondIndex = int.MinValue;

        Console.WriteLine("Тек. индекс\tИндекс числа");
        for (int i = 0; i < numeros.Length; i++)
        {
            int secondLook = Math.Clamp(numeros.Length - i - 1, 0, numeros.Length - 1);
            if (IsLesser(secondMinimal, numeros[secondLook]) && secondIndex != firstIndex)
            {
                int secondBuffer = numeros[secondLook];
                secondIndex = secondLook;
                secondMinimal = secondBuffer;
            }

            if (IsLesser(firstMinimal, numeros[i]) && firstIndex != secondIndex && i != secondIndex)
            {
                int firstBuffer = numeros[i];
                firstIndex = i; 
                firstMinimal = firstBuffer;
            }
            Console.Write($"{i}/{secondLook} \t\t {firstIndex}/{secondIndex}\n");
        }

        Console.WriteLine($"\nПервое минимальное: {firstMinimal}\nВторое минимальное: {secondMinimal}");

        int sum = firstMinimal + secondMinimal;
        Console.WriteLine($"Сумма минимальных: {sum}");
        return sum;
    }

    static bool IsLesser(int max, int min)
    {
        if (max > min)
            return true;
        return false;
    }
}