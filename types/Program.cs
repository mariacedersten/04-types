using System;
public partial class Program
{

    public static void Main(string[] args)
    {
        //Kokonaisluku muuttuja//
        int luku1;
        // muuttujalle asetetaan arvo//
        luku1 = 52;
        // muuttujan arvo tulestetaan//
        Console.WriteLine(luku1);

        luku1 = 100 + 2;
        Console.WriteLine(luku1);

        //Kysy käyttäjältä tämän lempinumero//
        int lempinumero;
        Console.WriteLine("Kirjoita lempilukusi!");
        string vastaus;
        vastaus = Console.ReadLine();

        //Tulkitaan vastaus kokonaisluvuksi//
        Int32.TryParse(vastaus, out lempinumero);

        //Tulkitaan , tapa 2
        lempinumero = Convert.ToInt32(vastaus);

        Console.WriteLine("Vastasit: " + (lempinumero + 5));
    }
}