using BlaisePascal.LessonExempleDomain;

public class Program // questa è una classe 
{
    //metodo di entrata in esecuzione del codice
    public static void Main()
    {

       /*

        Console.WriteLine("Inserisci il nome del cliente");

        string nomeCliente = Console.ReadLine(); 

        Console.WriteLine($"Benvenuto nella Easy Class 3E { nomeCliente}");

        Console.WriteLine("Inserisci il tipo di spedizione");

        string tipoConsegna = Console.ReadLine();

        Console.WriteLine($"Inserisci il numero di pacchi aquistati");

        int numeroPacchi = int.Parse(Console.ReadLine());

        int costoSpedizione = 5; // dichiarazione di una variabile intera costoSpedizione e inizializzazione a 5
        costoSpedizione = 10; // riassegnazione del valore della variabile costoSpedizione a 10

        

      

        int costoTotale = costoSpedizione * numeroPacchi;

        Console.WriteLine($"Il tipo di consegna selezionato è {tipoConsegna} e il prezzo totale è {costoTotale}.");
       */




        Enemy enemy = new Enemy(); // creazione di un oggetto nemico della classe Enemy
        enemy.Health = 1;
        Console.WriteLine($"La salute del nemico è {enemy.Health}.");
    }

}
