using System.Text.Json.Serialization.Metadata;

namespace APD;

public class KontenerNaPlyny : Kontener, IHazardNotifier
{
    public bool CzyNiebezpieczne { get; set; }

    public KontenerNaPlyny(double masaLadunku, int wysokosc, int wagaWlasna, int glebokosc, int maksLadownosc,bool czyNiebezpieczne) :
        base(masaLadunku, wysokosc, wagaWlasna, glebokosc, maksLadownosc)
    {
        NumerSeryjny = "KON-L-"+KontenerId;
        CzyNiebezpieczne = czyNiebezpieczne;
    }
    public KontenerNaPlyny():base(0,300,3700,244,45000)
    {
        NumerSeryjny = "KON-G-" + KontenerId;
        CzyNiebezpieczne = false;
    }

    public new void Zaladuj(double masa)
    {
        if (CzyNiebezpieczne)
        {
            if (MasaLadunku +masa> MaksLadownosc/2)
            {
                Notify("!! Załadunek przerwany: Za dużo niebezpiecznego ładunku(Max 50% ładowności) - Kontener: "+NumerSeryjny+" !!");
            }
            else
            {
                MasaLadunku += masa;
            }
        }
        else
        {
            if (MasaLadunku +masa> MaksLadownosc*0.9)
            {
                Notify("!! Za dużo ładunku(Max 90% ładowności) !!");
            }
            else
            {
                MasaLadunku += masa;
            }
        }
    }

    public new void Rozladuj()
    {
        MasaLadunku = 0;
    }

    public void Notify(String msg)
    {
        Console.Error.WriteLine(msg);
    }

    public override String ToString()
    {
        return "Kontener "+NumerSeryjny+", niebezpieczny: "+CzyNiebezpieczne;
        
    }
}