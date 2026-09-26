public class Program // questa è una classe 
{
    //metodo di entrata in esecuzione del codice
    public static void Main()
    {

        Console.WriteLine("Benvenuto nella Easy Class 3E");

        int costoSpedizione = 5; // dichiarazione di una variabile intera costoSpedizione e inizializzazione a 5
        costoSpedizione = 10; // riassegnazione del valore della variabile costoSpedizione a 10

        int numeroPacchi = 2;

        string tipoConsegna = "Standard"; // dichiarazione

        int costoTotale = costoSpedizione * numeroPacchi;

        Console.WriteLine($"Il tipo di consegna selezionato è {tipoConsegna} e il prezzo totale è {costoTotale}.");
        
    }

}
