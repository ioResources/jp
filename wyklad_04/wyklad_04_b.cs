/*
 * Zagnieżdżanie pętli FOR
 * 
 * Rysowanie prostokątów i trójkątów z gwiazdek (*)
 */ 

// długość "boków"
int a = 5; // w poziomie (oś X)
int b = 5; // w pionie (oś Y)

// pętla iterująca po wierszach 
for (int y = 0; y < b; y++)
{
    // pętla iterująca po kolumnach - wyświetlamy wiersz
    // Tutaj można się pobawić i np. uzależnić liczbę iteracji od aktualnej
    // wartości zmiennej y. Jeżeli wpiszemy np. x < b-y, uzyskamy trójkąt.
    for (int x = 0; x < b; x++)
    {
        // Kod w komentarzu służy do wyświetlenia wartości zmiennych
        // x i y. Usuń komentarz, aby zobaczyć, jak się zmieniają te wartości.   
//        Console.WriteLine("x: " + x + " y:" + y);
        
        // wyświetlanie pojedynczej gwiazdki - ta instrukcja zostanie wykonana
        // a * b razy
        Console.Write("*");
    }
    //przechodzimy do nowego wiersza
    Console.WriteLine();
}
