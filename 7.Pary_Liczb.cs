using System;

    Console.WriteLine("Podaj liczbę n: ");
    int n = int.Parse(Console.ReadLine());
    Console.WriteLine("Pary liczb naturalnych o sumie {0}:", n);
    poszukiwanaLiczba(n);


    static void poszukiwanaLiczba(int x)
    {//Pętla która wyszukuje wszystkie pary liczb dla wcześniej podanej liczby n
        for (int i = 1; i <= x / 2; i++)
        {
            int j = x - i;
            Console.WriteLine("({0}, {1})", i, j);
        }
    }
