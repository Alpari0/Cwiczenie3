using System;

    //Deklaracja zmiennych oraz wprowadzenie wartości z klawiatury
    Console.WriteLine("Wprowadź wartość podstawy i wykładnika");
    int a, b, baza;
    string liczba;
    baza = 1;
    a = int.Parse(liczba);
    b = int.Parse(liczba);
    //Pętla, dzięki której podstawa jest mnożona tak długo aż wykładnik nie osiągnie wartości 0
    while (b > 0)
    {
        baza = baza * a;
        b = b - 1;
    }
    //Wyświetlenie końcowego wyniku
    Console.WriteLine(baza);