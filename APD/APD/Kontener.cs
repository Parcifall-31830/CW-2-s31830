namespace APD;

public abstract class Kontener
{
    private static int Id;
    public double MasaLadunku { get; set; }
    public int Wysokosc { get; set; }
    public int WagaWlasna{ get; set; }
    public int Glebokosc{ get; set; }
    public string NumerSeryjny{ get; set; }
    public int MaksLadownosc{ get; set; }
    public int KontenerId{ get; set; }
    public Kontener(double masaLadunku, int wysokosc,int wagaWlasna,int glebokosc,int maksLadownosc)
    {
        MasaLadunku = masaLadunku;
        Wysokosc = wysokosc;
        WagaWlasna = wagaWlasna;
        Glebokosc = glebokosc;
        MaksLadownosc = maksLadownosc;
        KontenerId = Id++;
    }
    
    public void Rozladuj()
    {
        MasaLadunku = 0;
    }

    public void Zaladuj(double waga)
    {
        if (MasaLadunku + waga < MaksLadownosc)
        {
            MasaLadunku += waga;
        }
        else
        {
            throw new OverflowException("Przekroczono ładowność!");
        }
    }

    public override String ToString()
    {
        return "Kontener "+NumerSeryjny;
    }
}