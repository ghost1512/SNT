using System;

class PrimeNumberChecker
{
    static void Main()
    {
        Console.Write("Nhập vào một số để kiểm tra: ");
        int number = int.Parse(Console.ReadLine());

        if (IsPrime(number))
        {
            Console.WriteLine($"{number} là số nguyên tố.");
        }
        else
        {
            Console.WriteLine($"{number} không phải là số nguyên tố.");
        }
    }

    static bool IsPrime(int number)
    {
        if (number < 2) return false;

        int boundary = (int)Math.Sqrt(number);
        for (int i = 2; i <= boundary; i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }
}
