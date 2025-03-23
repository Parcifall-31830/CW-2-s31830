namespace APD;

public class KontenerNaGaz : Kontener, IHazardNotifier
{
    public int Atmosfery { get; set; }
    
    public KontenerNaGaz(double masaLadunku, int wysokosc, int wagaWlasna, int glebokosc, int maksLadownosc,int atmosfery) :
        base(masaLadunku, wysokosc, wagaWlasna, glebokosc, maksLadownosc)
    {
        NumerSeryjny = "KON-G-" + KontenerId;
        Atmosfery = atmosfery;
    }

    public KontenerNaGaz():base(0,300,3700,244,45000)
    {
        NumerSeryjny = "KON-G-" + KontenerId;
        Atmosfery = 1;
    }

    public new void Rozladuj()
    {
        MasaLadunku = MasaLadunku * 0.05;
    }

    public new void Zaladuj(double masa)
    {
        if (MasaLadunku + masa > MaksLadownosc)
        {
            throw new OverflowException("Za dużo ładunku");
        }
        else
        {
            MasaLadunku += masa;
        }
    }
    

    public void Notify(string msg)
    {
        Console.Error.WriteLine(msg);
    }

    public override string ToString()
    {
        return "Kontemer" + NumerSeryjny+", atmosfery: "+Atmosfery;
    }
}