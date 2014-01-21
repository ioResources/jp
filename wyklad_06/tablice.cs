    class Program
    {
	/*
	 * Funkcja zwracająca największą wartość z tablicy
	 */
        static int max(int[] tab)
        {
	    // na początku zakładamy, że największa wartość to 0 
            int m = 0;
	    // iterujemy po tablicy
            foreach (int a in tab)
            {
		// jeśli bieżący element tablicy jest większy niż obecne maksimum...
                if (a > m)
                {
		    // ...aktualizujemy maksimum
                    m = a;
                }
            }
            return m;
        }

	/*
	 * Funkcja rysująca wykres słupkowy.
	 * Dane do wykresu pochodzą z tablicy.
	 */
        static void wykres(int[] t)
        {
	    // szerokość wykresu (w znakach)
            int szer = 80;

	    // liczymy wartość, o którą trzeba przeskalować wartości z tablicy,
	    // by odpowiadające im słupki zmieściły się na wykresie 
	    // Uwaga: rzutowanie na double, czyli (double)szer, jest potrzebne,
	    // by operacje były wykonywane na liczbach zmiennoprzecinkowych
            double skala = (double)szer / max(t);
            
	    // nie rozciągamy słupków 
	    if (skala >= 1)
            {
                skala = 1.0;
            }

	    // iterujemy po tablicy
            //for (int i = 0; i < t.Length; i++)	//można też tak
            foreach (int a in t)
            {
		// liczba gwiazdek odpowiada wartości w tablicy (z uwzględnieniem skalowania)                 
		for (int j = 0; j < a*skala; j++)
                {
                    Console.Write("*");
                }
		// przejście do nowego wiersza - przygotowanie do rysowania kolejnego słupka
                Console.WriteLine();
            }
        
        }
        

        static void Main(string[] args)
        {
	    // deklarujemy i tworzymy tablicę
            int[] tab = new int[4];

	    // kolejnym elementom tablicy przypisujemy wartości
            tab[0] = 20;
            tab[1] = 6;
            tab[2] = 10;
            tab[3] = 5;

	    // wywołujemy funkcję rysującą wykres
            wykres(tab);
            
            Console.ReadLine();
        }
    }
