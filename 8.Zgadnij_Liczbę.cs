using System;

        //Deklaracja zakresu liczb
        int mniejsza = 1;
        int wieksza = 20;
        //Instrukcje dla użytkownika
        Console.WriteLine("Wybierz liczbę z przedziału {0} - {1}.", mniejsza, wieksza);
        Console.WriteLine("Wpisz liczbę ujemną jeśli liczba jest mniejsza od proponowanej,");
        Console.WriteLine("Wpisz liczbę dodatnią jeśli liczba jest większa od proponowanej");
        Console.WriteLine("a '0', jeśli liczba została pomyślnie odgadnięta.");

        int guess;
            //Pętla która sprawdza warunek wprowadzonych liczb czy jest dodatnia, ujemna czy jest zerem
        do {
            guess = CalculateGuess(mniejsza, wieksza);
            Console.WriteLine("Czy Twoja liczba to {0}?", guess);

            int response = int.Parse(Console.ReadLine());

            if (response < 0)
            {
                wieksza = guess - 1;
            }
            else if (response > 0)
            {
                mniejsza = guess + 1;
            }
            else
            {
                Console.WriteLine("Odgadłem Twoją liczbę!");
                break;
            }
            
            }      
        while (guess != 0);
    

    static int CalculateGuess(int mniejsza, int wieksza)
    {
        return (mniejsza + wieksza) / 2;
    }