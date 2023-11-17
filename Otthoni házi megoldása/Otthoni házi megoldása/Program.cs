static string szo(int darab)
{
    Random rand = new Random();
    string betuk = "qwertzuiopőúöüóűáélkjhgfdsaíyxcvbnm";
    string msh = "pktycszfhmnnjqwlrbdgv";
    string mgh = "aáeéiíoóöőuúüű";
    string szo = "";

    for(int i=0; i<darab; i++)
    {
        if (i % 2 == 0)
        {
            int index = rand.Next(mgh.Length);
            szo += mgh[index];
        }
        el
    }
    for (int i = 0; i < darab; i++)
    {
        int index = rand.Next(betuk.Length);
        szo += betuk[index];
    }
    return szo;
}

string[] sokSzo = new string[10000];
Random rand = new Random();
for (int i = 0; i < sokSzo.Length; i++)
{
    sokSzo[i] = szo(rand.Next(2, 11));
}

sokSzo[sokSzo.Length - 1] = "aaaa";
sokSzo[0]= "baaaab";

File.WriteAllLines("szavak.txt", sokSzo);
/*
for (int i = 0; i<sokSzo.Length; i++)
{
    Console.WriteLine(sokSzo[i]);
}
*/

string[] szavak = File.ReadAllLines("szavak.txt");

string tobbszoros = "";
for (int i = 0; i < szavak.Length; i++)
{
    for (int k = i + 1; k < szavak.Length; k++)
    {
        if (szavak[i] == szavak[k])
        {
            tobbszoros += ";" + szavak[k];
            break;
        }
    }
}
if (tobbszoros != "")
{
    tobbszoros = tobbszoros.Substring(1);
    Console.WriteLine("Többször előforduló szavak: " + tobbszoros);
}


for (int i = 0; i < szavak.Length; i++)
{
    if (szavak[i].Length == 2)
    {
        szavak[i] = szavak[i].Substring(0, 1).ToLower() + szavak[i].Substring(1);
        Console.WriteLine(szavak[i]);
    }
}

for (int i = 0;i < szavak.Length; i++)
{
    if (szavak[i].Length == 2)
    {
        for(int k = i + 1;k < szavak.Length; k++)
        {
            if (szavak[k].Length == 10)
            {
                if (szavak[k].IndexOf(szavak[i])>-1)
                {
                    Console.WriteLine("{0} Benne van ebben: {1}", szavak[i]);
                }
            }
        }
    }
}
for(int i = 0;i<szavak.Length;i++)
{
    if (szavak[i].Length == 5)
    {
        szavak[i] = szavak[i].Replace("a", "@").Replace("e", "3").Replace("l", "1").Replace("o", "0");
        Console.WriteLine(szavak[i]);
    }
}
string[] valogat = new string[7];

for (int i = 0; i < valogat.Length; i++)
{
    valogat[szavak[i].Length] += szavak[i] + ";";
}

for(int i = 0;i < szavak.Length; i++)
{
    string[] darabolt = valogat[i].Substring(0, valogat[i].Length - 1).Split(';');
    Array.Sort(darabolt);
    File.WriteAllLines(i+"betus.txt", darabolt);
}
