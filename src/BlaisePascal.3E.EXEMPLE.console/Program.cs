using BlaisePascal.LessonExempleDomain;

public class Program // questa è una classe 
{
    //metodo di entrata in esecuzione del codice
    public static void Main(string[] args)
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




        /* Enemy enemy = new Enemy(); // creazione di un oggetto nemico della classe Enemy
        enemy.Health = 1;
        Console.WriteLine($"La salute del nemico è {enemy.Health}."); */
        try
        {
            Console.WriteLine("Hi, this is the Player project.");
            Console.WriteLine("");
            Console.WriteLine("Give me a name for your player:");
            string name = Console.ReadLine();
            int MaxHealth = 100;
            Player player1 = new Player(name, 1, 0, MaxHealth, MaxHealth, true, 0);
            Console.WriteLine($"Player: {player1.Name} ");
            Console.WriteLine($"Level: {player1.Level} ");
            Console.WriteLine($"Experience: {player1.Experience} ");
            Console.WriteLine($"Health: {player1.Health} ");
            Console.WriteLine($"MaxHealth: {player1.MaxHealth} ");
            Console.WriteLine($"IsAlive: {player1.IsAlive} ");
            Console.WriteLine($"Gold: {player1.Gold} ");
            Console.WriteLine("");
            Console.WriteLine("Now, let's simulate some actions on the player.");
            Console.WriteLine("");
            player1.Addexperience(470);
            Console.WriteLine("Added 470 experience points.");
            Console.WriteLine("Current experience: " + player1.Experience);
            Console.WriteLine("Current level: " + player1.Level);
            Console.WriteLine("Resetting experience...");
            player1.ResetExperience();
            Console.WriteLine("");
            Console.WriteLine("Taking 30 damage...");
            player1.TakeDamage(30);
            Console.WriteLine("Current health: " + player1.Health);
            Console.WriteLine("");
            Console.WriteLine("Healing 20 health...");
            player1.Heal(20);
            Console.WriteLine("Current health: " + player1.Health);
            Console.WriteLine("");
            Console.WriteLine("Adding 50 gold...");
            player1.AddGold(50);
            Console.WriteLine("Current gold: " + player1.Gold);
            Console.WriteLine("");
            Console.WriteLine("Resetting health...");
            player1.resetHealth();
            Console.WriteLine("Current health: " + player1.Health);

        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");


        }
    }

}
