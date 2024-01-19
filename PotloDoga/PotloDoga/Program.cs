using System.IO;

StreamReader szoveg = new StreamReader("jarmu.txt");



List<int> szam1 = new List<int>();
List<int> szam2 = new List<int>();
List<int> szam3 = new List<int>();
List<string> szam4 = new List<string>();



while (!szoveg.EndOfStream)
{
    string line = szoveg.ReadLine();
    string[] adat = new string[0];
    adat = line.Split(" ");
    /*
    foreach (string a in adat)
    {
        Console.WriteLine(a);
    }
    */
    szam1.Add(int.Parse(adat[0]));
    szam2.Add(int.Parse(adat[1]));
    szam3.Add(int.Parse(adat[2]));
    szam4.Add(adat[3]);


}

szoveg.Close();


for (int i = 1; i < szam1.Count; i++)
{
    Console.WriteLine(szam1[i]);
}
