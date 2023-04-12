
using System;
using System.ComponentModel.Design;

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






Console.WriteLine("inserisci un numero da 1 a 5");
string input = Console.ReadLine();

int inputParse = int.Parse(input);

int[] numberRewiew = { 1, 2, 3, 4, 5 };



for (int a = 0; a < numberRewiew.Length; a++)
{
    // Console.WriteLine( "- "+  numberRewiew[i]);
    
   if (inputParse == numberRewiew[a])
    {
        Console.WriteLine("il libro ha " + numberRewiew[a] + " stelle");
    };
    
};

 



/*
Console.WriteLine("scrivi il numero di stelline da 1 a 5");
string valutation = Console.ReadLine();
int valutationParse = int.Parse(valutation);


 if (valutationParse == 1)
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

}
else if(valutationParse == 0)
{
    Console.WriteLine("questo libro ha 0 stelline");
};

*/


Console.WriteLine("inserisci il numero di recensioni del libro: ");
string reviewcounter = Console.ReadLine();

int numberReviewParse = int.Parse(reviewcounter);
Console.WriteLine("le recensioni del libro sono " + numberReviewParse);



Console.WriteLine("ha la versione kindle? digita Si o No");

string havekindle = Console.ReadLine();
if(havekindle == "Si" || havekindle == "si")
{
    Console.WriteLine("ha la versione kindle");
}else if(havekindle == "No"|| havekindle == "no")
{
    Console.WriteLine("non ha la versione kindle");

};

Console.WriteLine("ha la copertina flessibile? digita Si o No");

string haveFlexible = Console.ReadLine();
if (haveFlexible == "Si" || haveFlexible == "si")
{
    Console.WriteLine("ha la versione kindle");
}
else if (haveFlexible == "No"|| haveFlexible == "no")
{
    Console.WriteLine("non ha la versione kindle");

};