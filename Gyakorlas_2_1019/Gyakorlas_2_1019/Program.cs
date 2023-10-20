//FELADAT1: Készíteni egy függvényt ami visszaad egy 10 ezer tagú, 4-jegyű pozitív számokat
//tarlamazó tömböt 
//FELADAT2: Megkeresni az olyan pontosan 3 tagú szakaszokat ami egymástól maximum 10 távolságra vannak

int[] tombKeszit(int darab, int legkisebb, int legnagyobb)
{
    int[] tomb = new int[darab];
    for (int i = 0; i < tomb.Length; i++)
    {
        Random rand = new Random();
        tomb[i] = rand.Next(legkisebb, legnagyobb + 1);
    }
    return tomb;
}
int[] szamok = tombKeszit(10000, 1000, 9999);

void szakasz2(int[] szamok)
{
    int kezd = 0;
    int veg = 0;
    int maxKezd = 0;
    int maxVeg = 0;
    for (int i = 1; i < szamok.Length; i++)
    {
        if ( <= szamok[i]szamok[i - 1])
        {

        }
        else
        {
            veg = i - 1;
            if (veg - kezd + 1 > maxVeg - maxKezd + 1)
            {
                maxVeg = veg;
                maxKezd = kezd;
            }
            kezd = i;

        }
    }
    for (int i = maxKezd; i < maxVeg + 1; i++)
    {
        Console.Write("{0}, ", szamok[i]);
    }
    Console.WriteLine();
}
szakasz2(szamok);