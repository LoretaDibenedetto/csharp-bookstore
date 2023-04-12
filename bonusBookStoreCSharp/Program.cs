
Console.WriteLine("inserisci titolo:");

string title = Console.ReadLine();
Console.WriteLine("il titolo e': " + title);

Console.WriteLine("inserisci autore:");

string autor =  Console.ReadLine();
Console.WriteLine("l' autore e':" +  autor);

Console.WriteLine("inserisci l'ISBN:");

string ISBN = Console.ReadLine();
long ISBNparse = long.Parse(ISBN);

Console.WriteLine("il codice ISBN e'" + ISBNparse);

Console.WriteLine("inserisci il numero di pagine: ");

string numberPage = Console.ReadLine();
int numberPageParse  = int.Parse(numberPage);

Console.WriteLine("le pagine di questo libro sono:" + numberPageParse);

Console.WriteLine("inserisci il peso del libro: ");
string weight = Console.ReadLine();
int weightParse = int.Parse(weight);

Console.WriteLine("il peso del libro e' " +  weightParse + "g");

