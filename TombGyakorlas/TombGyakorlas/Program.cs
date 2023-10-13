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
    if (szavak[i])
}



// Console.WriteLine(szavak.OrderByDescending(s => s.Length).First());


//Console.WriteLine(hossz);
