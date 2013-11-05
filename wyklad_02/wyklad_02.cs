// deklarujemy zmienną przechowującą aktualny rok
int rok = 2013;

// deklarujemy zmienną, w której zapiszemy łańcuch (tekst) wpisany przez użytkownika
string dane;
// odczytujemy łańcuch z konsoli (klawiatury)
Console.Write("Podaj rok urodzenia: ");
dane = Console.ReadLine();

// deklarujemy zmienną, w której zapiszemy rok urodzenia podany przez użytkownika
int rokUrodzenia;
// zamieniamy tekst (string) wprowadzony przez użytkownika na liczbę całkowitą (int)
rokUrodzenia = int.Parse(dane);

// jeśli rok urodzenia jest mniejszy niż bieżący...
if (rokUrodzenia <= rok)
{
  // ...obliczamy wiek użytkownika...
  int wiek = rok - rokUrodzenia;
  // ...i go wyświetlamy
  Console.WriteLine("Wiek: " + wiek);
}
// w przeciwnym przypadku...
else
{
  // ...wyświetlamy komunikat o błędnych danych 
  Console.WriteLine("Błędne dane!");
}

// czekamy na wciśnięcie entera (po to, żeby nie zniknęło nam okienko konsoli)
Console.ReadLine();
