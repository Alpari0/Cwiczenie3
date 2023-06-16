using System;
class Program
{
    static void Main()
    {
        //Wprowadzanie liczby
        Console.WriteLine("Podaj liczbę: ");
        int number = int.Parse(Console.ReadLine());
        //Wywolanie metody wraz z końcowym rezultatem
        int odwroconeLiczby = odwracanieLiczby(number);
        Console.WriteLine("Liczba po odwróceniu cyfr: " + odwroconeLiczby);
    }

    static int odwracanieLiczby(int number)
    {
        int odwroconeLiczby = 0;
        //Algorytm do zamiany kolejności cyfr w podanej wcześniej liczbie
        while (number != 0)
        {
            int digit = number % 10;
            odwroconeLiczby = odwroconeLiczby * 10 + digit;
            number /= 10;
        }

        return odwroconeLiczby;
    }
}