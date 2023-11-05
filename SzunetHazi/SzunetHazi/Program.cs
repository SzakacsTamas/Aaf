static string szogeneralas(int hanybetus)
{
    string betuk = "qwertzuiopőúasdfghjkléáűíyxcvbnmöüó";

    string szo = "";
    var rand = new Random();
    for (int i = 0; i < hanybetus; i++)
    {
        szo += betuk[rand.Next(betuk.Length)];
    }

    return szo;
    
}

var rand = new Random();
string[] szavak = new string[10000];
for (int i = 0; i < 10000; i++)
{
    szavak[i] = szogeneralas(rand.Next(4, 7));
}

File.WriteAllLines("szavak.txt", szavak);

string[] szavak2 = File.ReadAllLines("szavak.txt");
