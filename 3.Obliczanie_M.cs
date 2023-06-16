using System;

    Console.WriteLine("Podaj liczbę n (n >= 5): ");
    int n = int.Parse(Console.ReadLine());

    Console.WriteLine("Podaj liczbę k (k >= 5): ");
    int k = int.Parse(Console.ReadLine());
    if (n < 5 || k < 5)
    {
        Console.WriteLine("Podaj wartość równą lub większą od 5");
    }
    else
    {
        // Obliczanie silni dla n
        int silniaOdN = CalculateFactorial(n);
        // Obliczanie silni dla k
        int SilniaOdK = CalculateFactorial(k);
        // Obliczanie m
        int m = (silniaOdN - SilniaOdK) / SilniaOdK;
        Console.WriteLine("Wartość m: " + m);
    }

    //Obliczanie silnii
    static int CalculateFactorial(int number)
    {
        int Silnia = 1;
        for (int i = 2; i <= number; i++)
        {
            Silnia *= i;
        }
        return Silnia;
    }
