﻿string szoveg = "Helló Bence!";
for (int i = 0; i < szoveg.Length; i++)
{
    Console.WriteLine(szoveg[i]);
}

foreach(char s in szoveg)
{
    Console.WriteLine(s);
}
for (int i = 0;i < szoveg.Length; i++)
{
    Console.WriteLine(szoveg.Substring(i,1));
}

Console.WriteLine(szoveg.ToUpper());

string[] darab=szoveg.Split(' ');
Console.WriteLine(darab[0] +" " + darab[1].ToUpper());

Console.WriteLine(szoveg.Substring(0,szoveg.IndexOf(" ")) +szoveg.Substring(szoveg.IndexOf("")+1;

//HÁZI:::: BEKÉRNI EGY TÖBB SZÓBÓL ÁLLÓ SZÖVEGET MINDEN SZÓ KEZDŐBETŰJE LEGYEN NAGY A TÖBBI KICSI