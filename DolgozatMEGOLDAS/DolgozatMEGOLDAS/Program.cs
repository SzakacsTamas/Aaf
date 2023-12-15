using Microsoft.VisualBasic;

List <int> percek=new List<int> ();
List<double> ho1 = new List<double>();
List<double> ho2 = new List<double>();
List<double> ho3 = new List<double>();
List<double> ho4 = new List<double>();
List<int>darab=new List<int> ();

void betolt()
{
    StreamReader olvas = new StreamReader("adathalmaz.csv");
    olvas.ReadLine();
    while (!olvas.EndOfStream)
    {
        string sor = olvas.ReadLine();
        string[] vag = sor.Split(";");
        percek.Add(int.Parse(vag[0]));
        ho1.Add(double.Parse(vag[1]));
        ho2.Add(double.Parse(vag[2]));
        ho3.Add(double.Parse(vag[3]));
        ho4.Add(double.Parse(vag[4]));
        darab.Add(int.Parse(vag[5]));
        
    }
    
    olvas.Close();
}
void betolt2()
{
    string[] sorok = File.ReadAllLines("adathalmaz.csv");
    for (int i = 1; i < sorok.Length; i++)
    {
        string[] vag = sorok[i].Split(";");
        percek.Add(int.Parse(vag[0]));
        ho1.Add(double.Parse(vag[1]));
        ho2.Add(double.Parse(vag[2]));
        ho3.Add(double.Parse(vag[3]));
        ho4.Add(double.Parse(vag[4]));
        darab.Add(int.Parse(vag[5]));
    }
}

void betolt3()
{
    string[] sorok = File.ReadAllLines("adathalmaz.csv").ToList().Skip(1).ToArray();
    foreach(string sor in sorok) 
    {
        string[] vag = sor.Split(";");
        percek.Add(int.Parse(vag[0]));
        ho1.Add(double.Parse(vag[1]));
        ho2.Add(double.Parse(vag[2]));
        ho3.Add(double.Parse(vag[3]));
        ho4.Add(double.Parse(vag[4]));
        darab.Add(int.Parse(vag[5]));
    }
}


Console.WriteLine("2 Feladat \n Ennyi adatsor van{0}",percek.Count);

Console.WriteLine("3 Feladat \n Átlagos termelés {0} db/óra", darab[darab.Count -1]/24);

Console.WriteLine("4 Feladat \n Min1 {0}, Min2 {1} Min3 {2}, Min4");
double maximum = ho1[0];
int maxIndex = 0;


List<int> darab5Perc = new List<int>();
darab5Perc.Add(darab[0]);