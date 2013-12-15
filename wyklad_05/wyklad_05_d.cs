/*
 * Uwaga: tym razem kod trzeba umieścić wewnątrz klasy (class Program),
 * a nie w funkcji Main()!
 */ 
class Program
{ 
	/*
	 * Funkcja poteguj() ma zadeklarowane dwa parametry
	 * (a więc przyjmuje dwa argumenty): podstawa i wykladnik
	 * 
	 * Funkcja zwraca wynik (typu double) równy podstawa^wykladnik.
	 */ 
	static double poteguj(double podstawa, double wykladnik)
	{
		double potega = 1;

		for (int i = 0; i < wykladnik; i++)
		{
			potega = potega * podstawa;

		}

		return potega;	// w ten sposób zwracamy wartość
	}

                
	static void Main(string[] args)
	{
		// wynik działania funkcji możemy przypisać do zmiennej:
		double wynik = poteguj(10, 3);
		//...
		Console.WriteLine(wynik);

		// możemy go też użyć bezpośrednio, np. do wyświetlenia:
		Console.WriteLine( poteguj(2, 3) );

		// wywołania funkcji można zagnieżdżać, np. 5^(3^2):
		Console.WriteLine(poteguj(5, poteguj(3, 2)));
		
		// można też tworzyć wyrażenia, np. 10^5 + 5*2^7:
		double wynik = poteguj(10, 5) + 5 * poteguj(2, 7);
		Console.WriteLine(wynik);
	}

} // koniec class Program
