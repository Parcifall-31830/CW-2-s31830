using APD;

KontenerChlodniczy k1 = new KontenerChlodniczy(200,0,0,0,25999,"Ser");
Kontener k2 = new KontenerNaPlyny(200,0,0,0,25999,false);
KontenerChlodniczy k3 = new KontenerChlodniczy(122,2,2,2,2123,"Jajka");
KontenerNaGaz k5 = new KontenerNaGaz();

KontenerNaPlyny k4 = new KontenerNaPlyny();

List<Kontener> konTAb = new List<Kontener>();
konTAb.Add(k1);
konTAb.Add(k2);
konTAb.Add(k3);



Kontenerowiec kon = new Kontenerowiec();
Kontenerowiec kon2 = new Kontenerowiec();
kon2.ZaladujKontener(k4);
kon2.ZaladujKontener(k5);
kon.ZaladujKontenerList(konTAb);

for (int i = 0; i < kon.KontenerTab.Count; i++)
{
    Console.WriteLine(kon.KontenerTab[i]);
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

kon.PokazKontenery();
kon.PrzeniesNaInnyStatek(kon2,k1);
kon.PokazKontenery();

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine(k3);
Console.WriteLine(k3.Temperatura);




// Console.WriteLine(kon);

// kon.ZaladujKontener(k1);
// kon.ZaladujKontener(k2);
// kon.ZaladujKontener(k3);
// kon.ZaladujKontener(k4);
// kon.ZaladujKontener(k5);

// kon.UsunKontener("KON-G-4");
// Console.WriteLine(k1.Temperatura);
// Console.WriteLine(k1.MasaLadunku);
// k1.rozladuj();
// Console.WriteLine(k1.MasaLadunku);
// k1.zaladuj(400);
// Console.WriteLine(k1.MasaLadunku);
// Console.WriteLine(k1.NumerSeryjny);
// Console.WriteLine(k2.NumerSeryjny);
// Console.WriteLine(k2.CzyNiebezpieczne);
// Console.WriteLine(k3.NumerSeryjny);
