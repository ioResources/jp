/*
 * Uwaga: tym razem kod trzeba umieścić wewnątrz klasy (class Program),
 * a nie w funkcji Main()!
 */ 
class Program
{       
	/*
	 * W funkcji gwiazdki() zamknęliśmy kod wypisujący rząd składający się
	 * z dziesięciu gwiazdek (pętla for).
	 * Dzięki temu, jeśli będziemy chcieli wyświetlić gwiazki, nie będziemy
	 * musieli powtarzać konstrukcji z pętlą - wystarczy *wywołać* funkcję gwiazdki().
	 * 
	 * Słowem static się nie przejmujcie.
	 * Void oznacza, że funkcja nie zwraca żadnej wartości.
	 * 
	 * + Wprowadziliśmy jeden *parametr* funkcji: ile. Dzięki temu możemy
	 * + określić długość rzędu gwiazdek.
	 * 
	 */	 
	static void gwiazdki(int ile)
	{
		for (int i = 0; i < ile; i++)
		{
			Console.Write(symbol);
		}
	}
	
	/*
	 * Jak zwykle wpisujemy tu kod, który ma zostać wykonany.
	 */ 
	static void Main(string[] args)
	{
		gwiazdki();	// + błąd (nie można wywołać funkcji bez przekazania wartości parametru "ile")

		Console.WriteLine("Cześć");
		gwiazdki(5);

		Console.WriteLine("coś tam");
		gwiazdki(15);

		Console.ReadLine();
	}

} // koniec class Program
