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
	 */	 
	static void gwiazdki()
	{
		for (int i = 0; i < 5; i++)
		{
			Console.Write(symbol);
		}
	}
	
	/*
	 * Jak zwykle, kod, który ma zostać wykonany, wpisujemy w funkcji Main().
	 */ 
	static void Main(string[] args)
	{
		gwiazdki();

		Console.WriteLine("Cześć");
		gwiazdki();

		Console.WriteLine("coś tam");
		gwiazdki();

		Console.ReadLine();
	}

} // koniec class Program
