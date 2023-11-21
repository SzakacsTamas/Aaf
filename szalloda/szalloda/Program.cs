﻿//Pitypang
static int fizetendo(int erkezes, int tavozas, int szemelydb, bool etkezes)
{
    int szobaAr = 0;
    if (erkezes < 121) szobaAr = 9000;
    else if (erkezes < 244) szobaAr = 10000;
    else szobaAr = 8000;

    int ejDb = tavozas - erkezes;
    if (szemelydb>2 ==)
    {
        szobaAr += 2000;
    }
    if (etkezes)
        szobaAr += szemelydb + 1100;
    return szobaAr*ejDb;
}

StreamReader olvas = new StreamReader("pitypang.txt");
//ADDIG OLVASSUK BE AMIG NINCS VÉGE
olvas.ReadLine();
List<int> sorszamok=new List<int>();
List<int> szobaSzamok = new List<int>();
List<int> erkezesNapja = new List<int>();
List<int> tavozasNapja = new List<int>();
List<int> vendegSzam = new List<int>();
List<bool> etkezes = new List<bool>();
List<string> vendeg = new List<string>();
while (!olvas.EndOfStream)
{
    string sor = olvas.ReadLine();
    //9 17 6 13 1 1 Szalai_Tibor
    string[] vag = sor.Split(" ");
    sorszamok.Add(Convert.ToInt32(vag[0]));
    szobaSzamok.Add(Convert.ToInt32(vag[1]));
    erkezesNapja.Add(Convert.ToInt32(vag[2]));
    tavozasNapja.Add(Convert.ToInt32(vag[3]));
    vendegSzam.Add(Convert.ToInt32(vag[4]));
    etkezes.Add(vag[5]=="1");
    vendeg.Add(vag[6]);

}


olvas.Close();

//második feladat maximum kereses
int maxEj = 0;
int maxId = 0;
for (int i = 0; i < sorszamok.Count; i++)
{
    int hossz = tavozasNapja[i] - erkezesNapja[i];
    if (hossz > maxEj)
    {
        maxEj = hossz;
        maxId = i;
    }
}
Console.WriteLine("2 feladat");
Console.WriteLine("{0} ({1}) - {2}", vendeg[maxId], erkezesNapja[maxId],maxEj);

StreamWriter ir = new StreamWriter("bevetel.txt");
for(int i = 0;i < sorszamok.Count; i++)
{
    ir.WriteLine("{0}:{1}", sorszamok[i], fizetendo(erkezesNapja[i], tavozasNapja[i], vendegSzam[i], etkezes[i]));
}