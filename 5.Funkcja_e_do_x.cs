using System;

class Program
{
    static void Main()
    {
        //Wprowadzenie wartości x oraz liczby wyrazów n
        Console.WriteLine("Podaj wartość x: ");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Podaj liczbę wyrazów n: ");
        int n = int.Parse(Console.ReadLine());
        double wynik = CalculateExponential(x, n);
        Console.WriteLine("Wartość funkcji e^{0} przybliżona sumą {1} wyrazów szeregu Taylora: {2}", x, n, wynik);
    }
    static double CalculateExponential(double x, int n)
    {
        // Pierwszy wyraz szeregu: x^0/0!
        double sum = 1; 

        for (int i = 1; i <= n; i++)
        {
            double abc = Math.Pow(x, i) / silnia(i);
            sum += abc;
        }
        return sum;
    }

    //Obliczanie końcowego wyniku
    static double silnia(int number)
    {
        double wynik = 1;
        for (int i = 2; i <= number; i++)
        {
            wynik *= i;
        }
        return wynik;
    }
}






