namespace APD;

public class Kontenerowiec
{
    public List<Kontener> KontenerTab;
    public int MaksPredkosc;
    public int MaksKontenerow;
    public int MaksWaga;
    public int i = 0;

    public Kontenerowiec()
    {
        
        MaksPredkosc =25 ;//węzły
        MaksKontenerow =10;
        MaksWaga = 37;//Tony
        KontenerTab = new List<Kontener>();
    }

    public void ZaladujKontener(Kontener k)
    {
        if (i < MaksKontenerow)
        {
            KontenerTab.Add(k);
            Console.WriteLine("Kontenerowiec załadowany");
            i++;
        }
        else
        {
            Console.Error.WriteLine("Kontenerwoiec zapełniony!!!");
        }
    }

    public void ZaladujKontenerList(List<Kontener> konTab)
    {
        if (10-i - konTab.Count <= 0)
        {
            Console.Error.WriteLine("Kontenerowiec zapełniony!! ");
           
        }
        else
        {
            for (int j = 0; j < konTab.Count; j++)
            {
                KontenerTab.Add(konTab[j]);
                i++;
                Console.WriteLine("Kontenerowiec załadowany");
            }
        }
    }

    public void UsunKontener(String nazwa)
    {
        
        Kontener k = null;
        foreach (var o in KontenerTab)
        {
            if (o.NumerSeryjny == nazwa)
            {
                k = o;
                
            }
        }

        if (k != null)
        {
            KontenerTab.Remove(k);
            i--;
            Console.WriteLine("Usunięto kontener");
        }
        else
        {
            Console.WriteLine("Brak takiego kontenera");
        }

    }


    public void ZamienKontener(String nazwa,Kontener k)
    {
        for (i = 0; i < KontenerTab.Count; i++)
        {
            if (KontenerTab[i].NumerSeryjny == nazwa)
            {
                KontenerTab[i] = k;
                Console.WriteLine("Kontenery zamienione");
                break;
            }
        }
        
        
    }

    public void PrzeniesNaInnyStatek(Kontenerowiec statek, Kontener kon)
    {
        Kontener k=null;
        for (i = 0; i < KontenerTab.Count; i++)
        {
            if (KontenerTab[i] == kon)
            {
                k = kon;
            }
        }

        if (k != null)
        {
            KontenerTab.Remove(k);
            statek.KontenerTab.Add(k);
            Console.WriteLine("Kontenery przeniesione z statku na statek");
            i--;
        }
        else
        {
            Console.WriteLine("Brak takiego kontenera");
        }
    }

    public void PokazKontenery()
    {
        for (i = 0; i < KontenerTab.Count; i++)
        {
            Console.WriteLine(KontenerTab[i].NumerSeryjny);
        }
    }


    public override string ToString()
    {
        return "Kontenerowiec, ilość ładunku "+i+"/"+MaksKontenerow;
    }
}