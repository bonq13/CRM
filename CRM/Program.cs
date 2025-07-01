namespace CRM;

class Program
{
    public const string FILE_NAME = "clients.json";
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to CRM app!");
        Console.WriteLine("Please let me know what you would like to do:");
        Console.WriteLine("1. Add a client");
        Console.WriteLine("2. Remove a clietn");
        Console.WriteLine("3. List all clients");
        Console.WriteLine("4. Edit client data");
        Console.WriteLine("5. Exit");
        Console.WriteLine("Choose an option 1 - 5:");
        
        string choice = Console.ReadLine();
        Console.WriteLine($"You have choosen option number {choice}.");
        
        //stała - uzywamy const
        //const string FILE_NAME = "clients.json";
        
        //zmienna - bez const
        int choosenOption = int.Parse(choice);  
        
        Console.WriteLine("Please choose another option 1 - 5:");
        choice = Console.ReadLine();
        Console.WriteLine($"You have choosen option number {choice}.");
        choosenOption = int.Parse(choice);  
    }
}