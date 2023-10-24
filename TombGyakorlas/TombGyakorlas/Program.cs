/*
using System.ComponentModel.DataAnnotations;

Console.Write("Kérj be egy számot: ");
int sorSzam = Convert.ToInt32(Console.ReadLine());

string[] szavak=new string[sorSzam];

for (int i = 0; i < sorSzam; i++)
{
    Console.Write("Kérj be egy szót: ");
    szavak[i]= Console.ReadLine();
}

string max = "";
for (int i = 0;i < szavak.Length; i++)
{
    if (szavak[i].Length> max.Length)
    {
        max = szavak[i];
    }
}

Console.WriteLine(max);

//index kereses

int maxIndex = 0;
for (int i = 0; i< szavak.Length; i++)
{
    if (szavak[i]== max)
    {
        maxIndex = i;
    }
}

max = "";
maxIndex= 0;
for (int i = 0; i < szavak.Length; i++)
{
    if (szavak[i].Length >max.Length) 
    { 
    max = szavak[i];
    maxIndex = i;
    }
}

//max kereses 3

maxIndex = 0;
for (int i = 0;i < szavak.Length; i++)
{
    if (szavak[i].Length> szavak[maxIndex].Length) {
    maxIndex=i;
    }
}





// Console.WriteLine(szavak.OrderByDescending(s => s.Length).First());


//Console.WriteLine(hossz);
*/

using System.Net.Http.Headers;

string[] szavak=new string[] {"alma","körte","narancs","mandula","ananász","banán"};

string[] rovid = new string[szavak.Length];
string[] hosszu = new string[szavak.Length];

int rovidIndex = 0; 
int hosszuIndex=0;

for (int i = 0; i < szavak.Length; i++)
{
    if (szavak[i].Length <= 5)
    {
        rovid[rovidIndex] = szavak[i];
        rovidIndex++;
    }
    else
    {
        hosszu[rovidIndex++] = szavak[i];
    }
}

foreach(string s in rovid)
{
    Console.WriteLine(s);
}
foreach(string e in hosszu)
{
    Console.WriteLine(e);
}












