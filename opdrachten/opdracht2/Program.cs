using System;

// Console applicatie die alle tafels van verm. kunnen geven
public int Vermenigvuldig(int number1, int number2)
{
    int result = number1 * number2;
    Console.WriteLine(result);
}

// Console applicatie die faculteit berekent van opgegeven getal (parameter bij oproep v functie)
public int Faculteit(int number1)
{
    int totaal = 1;
    while(number1>1)
    {
        totaal *= number1;
        number1--;
    }
    return totaal;
    Console.WriteLine(totaal);
}

// Console applicatie die de rij van Fibonacci weergeeft
public int Fibonacci(int aantal)
    {
        int a = 0;
        int b = 1;
        for (int i = 0; i < aantal; i++)
        {
            int start = a;
            a = b;
            b += start;
        }
        return a;
    }
static void Go()
    {
        for (int i = 0; i < 15; i++)
        {
            Console.WriteLine(Fibonacci(i));
        }
    }