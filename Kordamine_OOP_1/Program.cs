using Kordamine_OOP_1;
using System.Security.Cryptography.X509Certificates;
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Koduloom kass = new Koduloom("Murka", "punane", 'E', 5.5, 7, true);
//kass.print_Info();
//Koduloom kassKloon = new Koduloom(kass);
//kassKloon.muuda_Nimi("Murkakloon");
//kassKloon.muuda_Sugu('I');
//kassKloon.muuda_Kaal 5.2;
//kassKloon.print_Info();

// Koer koer = new Koer("lambakoer", "Gray", "must", Koduloom.sugu.isane, 15.0, 10, true);
// koer.print_Info();

//Tootaja tootaja = new Tootaja();
//tootaja.amet = "Klienditeenindaja";

//tootaja.arvutaSissetulek(2.0, 5.0);
//tootaja.muudaNimi("Oleg");
//tootaja.tunnitasu = 6.0;
//tootaja.tootasu = 600;
//double tootunnid = tootaja.arvutaTootunnid();
//Console.WriteLine(tootunnid);
//tootaja.muudaAmet("juhataja");

//Kutsekooliopilane ko = new Kutsekooliopilane();
//ko.lisaTund("programmerimine");
//ko.lisaTund("matemaatika");


//Opilane opilane = new Opilane();
//opilane.eriala("Programmerija");

//opilane.lisaAine("informaatika");
//opilane.lisaHinne("informaatika", 4);
////opilane.vaataHinded();
//opilane.lisaAine("matemaatika");
//opilane.vaataHinded();
//opilane.lisaAine("eestikeel");
//opilane.lisaHinne("matemaatika", 3);
//opilane.lisaHinne("informaatika", 4);
////opilane.vaataHinded();
//opilane.lisaAine("matemaatika");

//opilane.vaataHinded();
//opilane.lisaHinne("matemaatika", 3);
//opilane.lisaHinne("informaatika", 5);
////opilane.vaataHinded();
//opilane.vaataHindedAineKohta("informaatika");

//opilane.eemaldaAine("matemaatika");



Tootaja Natasha = new Tootaja("Liis", 2003, Isik.Sugu.naine, "koolis", "fotograf", 200, 5.4);
Natasha.printinfo();
Tootaja Sergei = new Tootaja("Sasha", 2000, Isik.Sugu.mees, "kodus", "arvutimeister", 2000, 20.5);
Sergei.printinfo();
Tootaja Olesya = new Tootaja("Andra", 1998, Isik.Sugu.naine, "tehnikum", "kokk", 500, 6.2);
Olesya.printinfo();


List<Isik> kylastajad = new List<Isik>();
kylastajad.Add(Natasha);
kylastajad.Add(Sergei);
kylastajad.Add(Olesya);

//foreach (Isik s in kylastajad)
//{
//    Console.WriteLine(s.sugu);
//}



StreamWriter sw = new StreamWriter(@"..\..\..\opilane.txt");
foreach (Isik a in kylastajad)
{
    a.printinfo();
    double sissetulek = a.arvutaSissetulek(500, 20);
    Console.WriteLine("Reaalne sissetulek on: {0,7:f2}", sissetulek);
    sw.WriteLine(a.nimi + "," + a.synniAasta + "," + a.sugu + ",");
}
sw.Close();
List<Isik> LoetudFailist = new List<Isik>();
StreamReader fromFile = new StreamReader(@"C:\Users\opilane\source\repos\Kordamine_OOP\Kordamine_OOP_1\opilane.txt");
List<string> lines = new List<string>();
int n = fromFile.ReadToEnd().Split(new char[] { '\n' }).Length;
Console.WriteLine("-----" + n + "-----");

List<Tootaja> tootajad=new List<Tootaja>();
StreamReader p = new StreamReader(@"..\..\..\opilane.txt");
string text;
while ((text = p.ReadLine()) != null)
{
    string[] rida = text.Split(',');
    tootajad.Add(new Tootaja(rida[0],(Isik.Sugu)Enum.Parse (typeof(Isik.Sugu),rida[1],true)));
    //TextFailistEnumSugu(rida[1]) = rida[1], kui sugu on tavaline tekst;
}
p.Close();
foreach(var tootaja in tootajad)
{
    //Console.WriteLine(tootaja.nimi + "" + tootaja.synniAasta+""+ tootaja.sugu+""+ tootaja.asutus+""+tootaja.amet+""+ tootaja.tootasu+""+ tootaja.tunnitasu);
}
Console.ReadLine();

Isik.Sugu TextFailistEnumSugu(string andmed)
{
    
    switch(andmed)
    {
        case "naine":
            return Isik.Sugu.naine;
        default:
            return Isik.Sugu.mees;



    }
    
}



//string text = fromFile.ReadToEnd();
//Console.WriteLine();
//fromFile.Close();



//Isik inimene = new Opilane("Nikita", 2003, Isik.Sugu.mees, "tthk", "Programmeerija", 5000, 30.76);
//inimene.printinfo();
//int a = inimene.arvutaVanus();
//Console.WriteLine(a);
//inimene.printinfo();
