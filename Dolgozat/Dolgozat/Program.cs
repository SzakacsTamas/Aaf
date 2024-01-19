using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.InteropServices.ComTypes;

StreamReader szoveg = new StreamReader("adathalmaz.csv");
szoveg.ReadLine();
List<int> perc = new List<int>();
List<int> darab = new List<int>();
List<double> homero1=new List<double>();
List<double> homero2 = new List<double>();
List<double> homero3 = new List<double>();
List<double> homero4 = new List<double>();
while (!szoveg.EndOfStream)
{
    string line = szoveg.ReadLine();
    string[] adat = new string[6];
    adat = line.Split(";");
    
    foreach (string s in adat)
    {
        Console.WriteLine(s);
    }
    
    perc.Add(int.Parse(adat[0]));
    darab.Add(int.Parse(adat[5]));
  
    homero1.Add(Convert.ToDouble(adat[1]));
    homero2.Add(Convert.ToDouble(adat[2]));
    homero3.Add(Convert.ToDouble(adat[3]));
    homero4.Add(Convert.ToDouble(adat[4]));
}
szoveg.Close();
/*
for (int i = 1; i < perc.Count; i++)
{
    Console.WriteLine(perc[i]);
}
*/
Console.WriteLine("2. Feladat");
Console.WriteLine("Az adatok között {0} időpont szerepel",perc.Count());

int atlag = darab[darab.Count-1]/ 24;
Console.WriteLine("3.Feladat");
Console.WriteLine("Az átlagos napi termelés: {0}",atlag);


Console.WriteLine("4. Feladat");
Console.WriteLine("A legkisebb hőmérséklet az egyses fázisoban, {0}, {1}, {2}, {2}", homero1.Min(), homero2.Min(), homero3.Min(),homero4.Min());
//Console.WriteLine(homero1.Min());


double elsoMax = homero1.Max();

int index=homero1.IndexOf(elsoMax);

//Console.WriteLine(perc[index]);
Console.WriteLine("5.Feladat");
Console.WriteLine("Az első fázisban a legnagyobb hőmérséklet {0} Celsius fok és {1} percnél volt ekkora.", homero1.Max(), perc[index]);

Console.WriteLine("6.Feladat");
/*
int darabMax = darab.Max();
Console.WriteLine("A legnagyobb termelés {0} volt, {}-kor",darabMax);



int index2 = darab.IndexOf(darabMax);
double ido = perc[index2];
Console.WriteLine(ido/60);

Console.WriteLine();
*/
Console.WriteLine("---");


Console.WriteLine("7.Feladat");
Console.WriteLine("Az átlag hőmérséklet az egyes fázisokban, 1. fázis: {0:0.00}, 2. fázis: {1:0.00}, 3. fázis: {2:0.00}, 4. fázis: {3:0.00} (Celsius fok)", homero1.Sum() / homero1.Count(),
    homero2.Sum() / homero2.Count(),homero3.Sum()/homero3.Count(), homero4.Sum()/homero4.Count());

StreamWriter asd = new StreamWriter("termeles.csv");
for(int i = 0; i < perc.Count(); i++)
{
    if (perc[i] % 60 == 0)
    {
        
        asd.WriteLine(perc[i]);
        
        asd.WriteLine(darab[i]);

    }
    
    
}

asd.Close();

//+ feladat
StreamWriter asd2 = new StreamWriter("atlagKozeli.txt");

asd2.Close();