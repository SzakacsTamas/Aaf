using Oop1_09_2024;

ember e1 = new ember("Szakács","Árpád");
ember e2 = new ember("Nagy", "Árpi");
Console.WriteLine(e1.teljesNev);
Console.WriteLine(e2.teljesNev);


udvariasember ue1 = new udvariasember("Horváth","Hugó");

Console.WriteLine();

ue1.koszon();

ue1.koszon(e1);

diak d1 = new diak("Tálas", "Miklós", 12);
diak d2 = new diak("Verbulecc", "Bécs", 19);
diak d3 = new diak("Alhendro", "Bogdábab", 12);

d3.koszonNevvel(ue1);
