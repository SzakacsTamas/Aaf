//Kérjünk be egy szót, és ellenőrizni hogy szó-e, a bekért szót karakterentént megfordítani és ezt kiiratni, 2-esével, kérjünk be egy szöveget és  számoljuk meg melyik betüből
//hány db van, a 0 okat ne írjuk ki

//bekérünk egy szót végig nézzük betünként ciklussal minden betűt ellenőrzünk hogy benne van e a hasznalható betük stringjében, ha benne van, ha nincs akkor kiirjuk hogy ez nem szó

string betuk = "QWERTZUIOPŐÚASDFGHJKLÉÁŰÍYXCVBNMÖÜÓ";
string szo = "";
while (szo == "")
{
    Console.WriteLine("kérek egy szót: ");
    szo= Console.ReadLine();
    for(int i = 0; i < szo.Length; i++)
    {
        for(int j = 0; j < szo.Length; j++)
        {
            if (szo[i].ToString().ToLower() != betuk[j].ToString())
            {
                if (szo[i] == )
            }
        }
    }
}