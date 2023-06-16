using System;
        //Wprowadzenie wartości n, która spowoduje wygenerowanie n następnych liczby Fibbonaciego
        Console.WriteLine("Podaj liczbę wyrazów do wygenerowania: ");
        int n = int.Parse(Console.ReadLine());
        //Warunek dla dwóch pierwszych wyrazów ciągu
        Console.WriteLine("Ciąg Fibonacciego:");
        if (n >= 1)
            Console.Write("0 ");
        if (n >= 2)
            Console.Write("1 ");

        int a = 0; // Deklaracja pierwszego wyrazu
        int b = 1; // Deklaracja drugiego wyrazu

        // Wypisywanie kolejnych, wygenerowanych wyrazów
        for (int i = 3; i <= n; i++)
        {
            int c = a + b; //Algorytm obliczający kolejny wyraz ciągu
            Console.Write(c + " ");
            a = b;
            b = c;
        }