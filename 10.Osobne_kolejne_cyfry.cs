using System;

    Console.WriteLine("Podaj liczbę conajmniej 3 cyfrową");
    int liczba = int.Parse(Console.ReadLine());
    //Warunek który sprawdza czy liczba ma conajmniej 3 cyfry
    if (liczba < 100)
    {
        Console.WriteLine("Liczba musi mieć conajmniej 3 cyfry.");
    }
    else
    {
        //konwersja liczby do ciągu znaków następnie do tabeli
        char[] tablica = liczba.ToString().ToCharArray();
        //pętla za pomocą której wypiszemy wszystkie elementy tabeli
        foreach (char cyfra in tablica)
        {
            Console.WriteLine(cyfra);
        }
    }

