List<int> szamok = new List<int>();
Random random = new Random();

int darab = random.Next(10000, 100000);

for (int i = 0; i < darab; i++)
{
    szamok.Add(random.Next(10,100));
}

Console.WriteLine("{0} darab szám van.",szamok.Count);
Dictionary<int,int> stat = new Dictionary<int,int>();

for (int i = 0;i < szamok.Count; i++)
{
    if (stat.ContainsKey(szamok[i]))
    {

    }
}