using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj ilość liczb do posortowania: ");
        int n = int.Parse(Console.ReadLine());

        int[] liczby = new int[n];
        Console.WriteLine("Wprowadź liczby:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Liczba {i + 1}: ");
            liczby[i] = int.Parse(Console.ReadLine());
        }

        // Sortowanie bąbelkowe
        for (int i = 0; i < liczby.Length - 1; i++)
        {
            for (int j = 0; j < liczby.Length - 1 - i; j++)
            {
                if (liczby[j] > liczby[j + 1])
                {
                    // Zamiana miejscami
                    int temp = liczby[j];
                    liczby[j] = liczby[j + 1];
                    liczby[j + 1] = temp;
                }
            }
        }

        // Wyświetlanie posortowanych liczb
        Console.WriteLine("Posortowane liczby (sortowanie bąbelkowe):");
        foreach (var liczba in liczby)
        {
            Console.Write(liczba + " ");
        }
    }
}
