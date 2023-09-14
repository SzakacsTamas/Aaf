Console.Write("Kérem, adja meg az első számot: ");
int szam1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Kérem, adja meg a második számot: ");
int szam2 = Convert.ToInt32(Console.ReadLine());

int osszeg = 0;

// Két szám közötti számok összegzése
for (int i = szam1; i <= szam2; i++)
{
    osszeg += i;
}

int negyzet = osszeg * osszeg;

Console.WriteLine("A(z) "+szam1 + " és "+ szam2+" közötti számok összegének négyzete: "+ negyzet);