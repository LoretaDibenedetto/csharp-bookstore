
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



Console.WriteLine(" inserisci altezza larghezza e profondita'");
string height = Console.ReadLine();
float heightParse = float.Parse(height);

string length = Console.ReadLine();
float lengthParse = float.Parse(length);

string depth = Console.ReadLine();
float depthParse = float.Parse(depth);


Console.WriteLine("l'altezza del libro e'" + heightParse+" cm " + "la profondita'" + depthParse +" cm " + "la lunghezza" + lengthParse +" cm");



Console.WriteLine("scrivi il numero di stelline da 1 a 5");


string valutation = Console.ReadLine();
int valutationParse = int.Parse(valutation);

if (valutationParse == 0)
{
    Console.WriteLine("zoro stelline :(");
}
else if (valutationParse == 1)
{
    Console.WriteLine("la valutazione e': *");
} else if (valutationParse == 2)
{
    Console.WriteLine("la valutazione e': **");

} else if (valutationParse == 3)
{
    Console.WriteLine("la valutazione e': ***");

} else if (valutationParse == 4)
{
    Console.WriteLine("la valutazione e': ****");

} else if (valutationParse == 5)
{

    Console.WriteLine("la valutazione e': *****");

};







