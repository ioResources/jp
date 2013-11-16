// deklarujemy zmienną los i przypisujemy jej pseudolosową liczbę z podanego zakresu
int los = new Random().Next(1, 7);
// deklarujemy zmienną, która będzie przechowywała strzał użytkownika
int strzal;

// tu rozpoczyna się pętla do-while*
// ---
// pamiętajcie, że jest też pętla while - czym się różni od do-while?
do
{
    // pobieramy z konsoli strzał użytkownika 
    string s = Console.ReadLine();
    strzal = int.Parse(s);

    // jeśli użytkownik odgadł... 
    if (strzal == los)
    {
        // wypisujemy stosowny komunikat
        Console.WriteLine("Brawo!");
    }
    // jeżeli strzał jest większy od wylosowanej liczby...
    else if (strzal > los)
    {
        // piszemy, że za dużo
        Console.WriteLine("Za dużo!");
    }
    // a w przeciwnym przypadku (jeżeli jest mniejszy*)...
    // ---
    // *tak naprawdę to kiedy jest mniejszy lub równy,
    // ale sprawę równości załatwiliśmy wcześniej (pierwszy if)
    else
    {
        //piszemy, że za mało
        Console.WriteLine("Za mało!");
    }
  // i tak w kółko, aż uda się odgadnąć
  // ---
  // inaczej mówiąc, kolejną iterację pętli wykonujemy tylko wtedy,
  // gdy użytkownik nie odgadł liczby (los jest różny od strzał)
} while (los != strzal);


Console.ReadLine();
