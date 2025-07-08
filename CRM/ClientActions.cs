namespace CRM;

public class ClientActions
{
    public static List<Client> clients = new List<Client>();

    public static void AddClient()
    {
        Client client = new Client();
        client.Id = clients.Count + 1;
        Console.WriteLine("Enter client name");
        client.Name = Console.ReadLine();
        Console.WriteLine("Enter client email");
        client.Email = Console.ReadLine();

        bool loop = true;
        while (loop) 
        {
            Console.WriteLine("The client is: ");
            Console.WriteLine("1. A company");
            Console.WriteLine("2. A private customer");
            int answer;
            int.TryParse(Console.ReadLine(), out answer);
            if (answer == 1)
            { 
                Console.WriteLine("Enter client NIP");
                client.Nip = Console.ReadLine(); 
                loop = false;
            }
            else if (answer == 2)
            {
                Console.WriteLine("Enter client PESEL");
                client.Pesel = Console.ReadLine();
                loop = false;
            }
            else
            {
                Console.WriteLine("Choose 1 or 2");
            }
        }
        clients.Add(client);
        Console.WriteLine("Client has been added successfully!");
       
        
        
       
}

    public static void RemoveClient()
    {
        
    }
}