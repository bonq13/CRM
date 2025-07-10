namespace CRM;

class Program
{
    static void Main(string[] args)
    {
        
        ////c. wyświetlenie listy klientow
        ////d. filtrowanie klientow na podstawie rodzaju (firma/osoba prywatna)
        ////e. kontakt z klientem
        
        
        Console.WriteLine("Welcome to CRM!");
        bool loop = true;
        Console.WriteLine("Choose what You want to do:");
        while (loop)
        {
            
            Console.WriteLine("1) Add new client");
            Console.WriteLine("2) Remove client");
            Console.WriteLine("3) Show all clients");
            Console.WriteLine("4) Filter clients");
            Console.WriteLine("5) Exit");
            int choice = Convert.ToInt32(Console.ReadLine());

            
            switch (choice)
            {
                case 1:
                    ClientActions.AddClient();
                    break;
                case 2:
                    Console.WriteLine("Enter id to remove:");
                    int clientId = Convert.ToInt32(Console.ReadLine());
                    ClientActions.RemoveClient(clientId);
                    break;
                case 3:
                    ClientActions.ShowClients();
                    break;
                case 4:
                    ClientActions.FilterClients();
                    break;
                case 5:
                    loop = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
            
            
        }
       
        
        
        
        
    }
}