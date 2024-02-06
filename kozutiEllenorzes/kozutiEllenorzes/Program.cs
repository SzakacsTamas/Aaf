
using kozutiEllenorzes;

List<adatok> lista = new List<adatok>();



StreamReader asd = new StreamReader("jarmu.txt");

while (!asd.EndOfStream)
{
    string line = asd.ReadLine();
    lista.Add(new adatok(line));
     
    
}

Console.WriteLine();

asd.Close();
int busz =0;
int Kamion=0;
int Motor=0;
int Auto = 0;

for (int i = 0; i < lista.Count; i++)
{
    if (Convert.ToString(lista[i].rendSzam[0]) == "B")
    {
        busz ++;
    }
    else if(Convert.ToString(lista[i].rendSzam[0]) == "K")
    {
        Kamion ++;
    }
    else if(Convert.ToString(lista[i].rendSzam[0]) == "M")
    {
        Motor ++;

    }
    else { Auto++; }
    
}
Console.WriteLine("4.Feladat");
Console.WriteLine("Buszok száma: {0}",busz);
Console.WriteLine("Kamionok száma: {0}", Kamion);
Console.WriteLine("Motorok száma: {0}", Motor);
Console.WriteLine("Autók száma: {0}", Auto);




