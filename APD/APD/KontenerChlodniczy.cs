namespace APD;

public class KontenerChlodniczy : Kontener,IHazardNotifier
{
    public double Temperatura { get; set; }
    public String ProduktType { get; set; }

    public KontenerChlodniczy(double masaLadunku, int wysokosc,int wagaWlasna,int glebokosc,int maksLadownosc,String produktType) :
        base(masaLadunku, wysokosc, wagaWlasna, glebokosc, maksLadownosc)
    {
        NumerSeryjny = "KON-C-"+KontenerId;
        ProduktType = produktType;
        switch (ProduktType)
        {
            case "Banany":
                Temperatura = 13.3;
                break;
            case "Czekolada":
                Temperatura = 18;
                break;
            case "Ryba":
                Temperatura = 2;
                break;
            case "Mięso":
                Temperatura = -15;
                break;
            case "Lody":
                Temperatura = -18;
                break;
            case "Pizza mrożona":
                Temperatura = -30;
                break;
            case "Ser":
                Temperatura = 7.2;
                break;
            case "Maslo":
                Temperatura = 20.5;
                break;
            case"Jajka":
                Temperatura = 19;
                break;
            default:
                Temperatura = 15;
                break;
        };

    }
    public KontenerChlodniczy():base(0,300,3700,244,45000)
    {
        NumerSeryjny = "KON-G-" + KontenerId;
    }

    public void Zaladuj(String produkt, double masa)
    {

        if (produkt == ProduktType)
        {
            if (MasaLadunku + masa > MaksLadownosc)
            {
                Notify("!! Za dużo ładunku !!");
            }
            else
            {
                MasaLadunku += masa;
            }
        }
        else
        {
            Notify("!! Produkt niezgodny z typem kontenera !!");
        }


    }

    public void Notify(String msg)
    {
        Console.Error.WriteLine(msg);
    }

    public override String ToString()
    {
        return "KontenerChlodniczy "+NumerSeryjny+",typ ładunku: "+ProduktType+", temp: "+Temperatura;
    }


}