/*
 * To samo zadanie - liczenie od 1 do 5 - zrealizowane
 * za pomocą pętli DO-WHILE i FOR
 * 
 * Zaznaczyłem charakterystyczne fragmenty obu pętli:
 * 1) instrukcja wykonywana przed rozpoczęciem pętli
 * 2) instrukcja wykonywana przed sprawdzeniem warunku
 * 3) wyrażenie obliczane na końcu iteracji; jeżeli jest równe true,
 *    jest wykonywany kolejny obieg pętli, a jeśli false - pętla kończy działanie
 */ 

// Pętla do-while
int i = 1;  //1
do
{
    Console.WriteLine(i);
    i = i + 1; //2
} while (i <= 5); //3

// Pętla for            
//       1         3     2
for (int j = 1; j <= 5; j++)
{
    Console.WriteLine(j);
    
}
