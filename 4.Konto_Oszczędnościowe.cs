using System;

    Console.Write("Wprowadź kwotę początkową");
    double kwotaWstepna = Convert.ToDouble(Console.ReadLine());

    Console.Write("Wprowadź oprocentowanie");
    double oprocentowanie = Convert.ToDouble(Console.ReadLine());

    Console.Write("Jak długo chcesz oszczędzać ");
    int liczbaMiesiecy = Convert.ToInt32(Console.ReadLine());

    double koncowa = kwotaWstepna * Math.Pow(1 + (oprocentowanie / 100), liczbaMiesiecy / 12.0);

    Console.WriteLine("Końcowa kwota jaką otrzymasz " + koncowa);