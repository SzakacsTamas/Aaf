//1000 elemű tömb, feltőltve 3 jegyű számokkal.

int[] szamok = new int[1000];
Random rand = new Random();

for (int i = 0; i < szamok.Length; i++)
{

    szamok[i] = rand.Next(100, 1000);
}

foreach(int s in szamok)
{
    Console.WriteLine(s);
}