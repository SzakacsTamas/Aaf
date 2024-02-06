using Fogadoora;

List<adatok> foglalasok = new List<adatok>();
StreamReader olvas = new StreamReader("fogado.txt");

while (!olvas.EndOfStream)
{
    string sor=olvas.ReadLine();
    foglalasok.Add(new adatok(sor));
}

olvas.Close();

Console.WriteLine("2.Feladat");
Console.WriteLine("Foglalások száma: {0}", foglalasok.Count);

Console.WriteLine("3.Feladat");
Console.WriteLine("Adjon meg egy nevet: ");

string nev=Console.ReadLine();

int darab = 0;
for(int i = 0; i<foglalasok.Count; i++)
{
    //Console.WriteLine(foglalasok[i].nev);
    if (foglalasok[i].nev == nev)
    {
        darab++;
        Console.WriteLine("{0} néven {1} ifőpont foglalás van", nev, darab);
    }
    else
    {
        Console.WriteLine("{0} darab foglalás volt {1} néven",darab,nev);

    }
}

Console.WriteLine("4.feladat");
Console.Write("Adjon meg egy érvényes időpontot (pl 17:21)");
string idopont =Console.ReadLine();
List<string> nevek= new List<string>();

for(int i = 0; i < foglalasok.Count; i++)
{
    if(idopont == foglalasok[i].idopont)
    {
        nevek.Add(foglalasok[i].nev);
    }
}

nevek.Sort();
for(int i=0; i<nevek.Count(),i++)
{
    Console.WriteLine(nevek[i]);
}

File.WriteAllLines(idopont.Replace(":", "") + ".txt", nevek);

adatok min = foglalasok[0];

for(int i = 0; i < foglalasok.Count; i++)
{
    if (foglalasok[i].foglalas < min.foglalas)
    {
        min = foglalasok[i];
    }
}