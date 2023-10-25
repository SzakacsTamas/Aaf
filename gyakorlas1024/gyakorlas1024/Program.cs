//Kérjünk be egy szót, és ellenőrizni hogy szó-e, a bekért szót karakterentént megfordítani és ezt kiiratni, 2-esével, kérjünk be egy szöveget és  számoljuk meg melyik betüből
//hány db van, a 0 okat ne írjuk ki

//bekérünk egy szót végig nézzük betünként ciklussal minden betűt ellenőrzünk hogy benne van e a hasznalható betük stringjében, ha benne van, ha nincs akkor kiirjuk hogy ez nem szó

string betuk = "QWERTZUIOPŐÚASDFGHJKLÉÁŰÍYXCVBNMÖÜÓqwertzuiopőúöüóasdfghjkléáűíyxcvbnm";
string szo = "";
bool joE=true;
while (szo == "")
{
    Console.WriteLine("kérek egy szót: ");
    szo= Console.ReadLine();
    for(int i = 0; i < szo.Length; i++)
    {
        if (betuk.IndexOf(betuk[i]) < 0)
        {
            Console.WriteLine("Nem szó!");
            joE = false;
            break;

        }
        /*
        for(int j = 0; j < szo.Length; j++)
        {
            if (szo[i].ToString().ToLower() != betuk[j].ToString())
            {
                if (szo[i] == betuk[j])
                {

                }
            }
        }
        */
    }

    if(joE)
    {
        Console.WriteLine("{0} jó szó!", szo);
    }
    string ujSzo = "";
    for(int i = szo.Length-1; i>=0; i--)
    {
        ujSzo += szo[i];    
    }
    Console.WriteLine(ujSzo);


    ujSzo = "";
    for(int i = 0; i < szo.Length; i++)
    {
        ujSzo+= szo[szo.Length-i];
    }
    Console.WriteLine(ujSzo);

    ujSzo = "";
    for (int i = 0; i < szo.Length; i++)
    {
        ujSzo = szo[i]+ujSzo;
    }
    Console.WriteLine(ujSzo);

    ujSzo = "";
    for (int i = 0; i < szo.Length; i+=2)
    {
        ujSzo += szo.Substring(szo.Length - 1 - 1, 2);
    }
    Console.WriteLine(ujSzo);
}
//HÁZI:::: MELYIK BETŰBÓL HÁNY DB VAN?

