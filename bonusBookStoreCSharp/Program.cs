
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






Console.WriteLine("scrivi il numero di stelline da 1 a 5");

string stringrew = Console.ReadLine();

int numrew = int.Parse(stringrew);

if (numrew == 1)
{
    Console.WriteLine("questo libro ha 1 stellina");
}
else if (numrew == 2)
{
    Console.WriteLine("questo libro ha 2 stelline");
}
else if (numrew == 3)
{
    Console.WriteLine("questo libro ha 3 stelline");


}
else if (numrew == 4)
{
    Console.WriteLine("questo libro ha 4 stelline");

}
else if (numrew == 5)
{
    Console.WriteLine("questo libro ha 5 stelline");

};



int n = 0;

while (numrew < 0 || numrew > 5)
{
    Console.WriteLine("hai scritto " + numrew + " dovevi scrivere un numero da 1 a 5");

    string strrew2 = Console.ReadLine();
    int num2 = int.Parse(strrew2);

    n++;

    if (num2 == 1)
    {
        Console.WriteLine("questo libro ha 1 stellina");
    }
    else if (num2 == 2)
    {
        Console.WriteLine("questo libro ha 2 stelline");
    }
    else if (num2 == 3)
    {
        Console.WriteLine("questo libro ha 3 stelline");


    }
    else if (num2 == 4)
    {
        Console.WriteLine("questo libro ha 4 stelline");

    }
    else if (num2 == 5)
    {
        Console.WriteLine("questo libro ha 5 stelline");

    }

    break;
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
string numberRewiew = Console.ReadLine();

int numberRewiewParse = int.Parse(numberRewiew);
Console.WriteLine("le recensioni del libro sono " + numberRewiewParse);



Console.WriteLine("ha la versione kindle? digita Si o No");

string havekindle = Console.ReadLine();
if(havekindle == "Si")
{
    Console.WriteLine("ha la versione kindle");
}else if(havekindle == "No")
{
    Console.WriteLine("non ha la versione kindle");

};

Console.WriteLine("ha la copertina flessibile? digita Si o No");

string haveFlexible = Console.ReadLine();
if (haveFlexible == "Si")
{
    Console.WriteLine("ha la versione kindle");
}
else if (haveFlexible == "No")
{
    Console.WriteLine("non ha la versione kindle");

};