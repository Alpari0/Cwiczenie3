using System;

        Console.WriteLine("Podaj liczbę x: ");
        int x = int.Parse(Console.ReadLine());

        int n = 1;
        int silnia = 1;

        while (silnia < x)
        {
            n++;
            silnia *= n;
        }

        if (silnia == x)
        {Console.WriteLine("{0} jest silnią liczby {1}", x, n);}
        else
        {Console.WriteLine("{0} nie jest silnią żadnej liczby", x);}



