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
                Console.WriteLine("Client is private customer.");
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

    public static void RemoveClient(int clientId)
    {
        bool loop = true;
        while (loop)
        {
            if (clients.Count == 0)
            {
                Console.WriteLine("List of clients is empty!");
                break;
            }
            int clientToRemove = -1;
            for (int i = 0; i < clients.Count; i++)
            {
                if (clients[i].Id == clientId)
                {
                    clientToRemove = i;
                    break;
                }
            }

            if (clientToRemove >= 0 && clientToRemove < clients.Count)
            {
                clients.RemoveAt(clientToRemove);
                Console.WriteLine("Client has been removed successfully!");
                loop = false;
            
            }
            else
            {
                Console.WriteLine("This client doesn't exist!");
                Console.WriteLine("Do you want to try again?");
                Console.WriteLine("1. Yes");
                Console.WriteLine("2. No");
                int answer = Convert.ToInt32(Console.ReadLine());
                if (answer == 1)
                {   
                    Console.WriteLine("Enter client's id again");
                    clientId = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    loop = false;
                }
            }
        }
            
        
        
    }

    public static void ShowClients()
    {
        foreach (var client in clients)
        {
            Console.WriteLine("ID: " + client.Id);
            Console.WriteLine("Name: " + client.Name);
            Console.WriteLine("Email: " + client.Email);
            if (client.Nip != null)
            {
                Console.WriteLine("Company tax number " + client.Nip);
            }
            Console.WriteLine("");
            
        }
    }

    public static void FilterClients()
    {
        if (clients.Count == 0)
        {
            Console.WriteLine("List of clients is empty!\n");
            return;
        }
        bool loop = true;
        while (loop)
        {
            Console.WriteLine("How do You want to search?");
            Console.WriteLine("1. By ID");
            Console.WriteLine("2. By name");
            Console.WriteLine("3. Companies / private customers (all)");
            Console.WriteLine("4. Quit searching");
            
            if (!int.TryParse(Console.ReadLine(), out int searchOption) || searchOption < 1 || searchOption > 4)
            {
                Console.WriteLine("Invalid choice, choose 1-4.");
                continue;
            }

            switch (searchOption)
            {
                case 1:
                    Console.WriteLine("Enter client's id");
                    if (!int.TryParse(Console.ReadLine(), out int clientId) || clientId < 1 || clientId > 4)
                    {
                        Console.WriteLine("Enter correct client's id");
                        continue;
                    }
                    bool foundC1 = false;
                    foreach (var client in clients)
                    {
                        if (client.Id == clientId)
                        {
                            Console.WriteLine("ID: " + client.Id);
                            Console.WriteLine("Name: " + client.Name);
                            Console.WriteLine("Email: " + client.Email);
                            if (client.Nip != null) Console.WriteLine("Company tax number " + client.Nip);
                            Console.WriteLine("");
                            foundC1 = true;
                            break; 
                        }
                    }
                    if (!foundC1) Console.WriteLine("Client is not found!");
                    break;
                case 2:
                    Console.WriteLine("Enter client's name");
                    string clientName = Console.ReadLine();
                    bool foundC2 = false;
                    foreach (var client in clients)
                    {
                        if (client.Name == clientName)
                        {
                            Console.WriteLine("ID: " + client.Id);
                            Console.WriteLine("Name: " + client.Name);
                            Console.WriteLine("Email: " + client.Email);
                            if (client.Nip != null)
                            {
                                Console.WriteLine("Company tax number " + client.Nip);
                            }

                            Console.WriteLine("");
                            foundC2 = true;
                            break;
                        }
                    }
                    if (!foundC2)
                    {
                        Console.WriteLine("Client is not found!");
                    }
                    break;
                
                case 3:
                    Console.WriteLine("1. Companies");
                    Console.WriteLine("2. Private customers");
                    
                    if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > 2)
                    {
                        Console.WriteLine("Choose 1 or 2");
                        continue;
                    }
                    bool foundC3 = false;
                    foreach (var client in clients)
                    {
                        if (choice == 1 && client.Nip != null)
                        {
                            Console.WriteLine("ID: " + client.Id);
                            Console.WriteLine("Name: " + client.Name);
                            Console.WriteLine("Email: " + client.Email);
                            Console.WriteLine("Company tax number " + client.Nip);
                            foundC3 = true;
                        }
                        else if (choice == 2 && client.Nip == null)
                        {
                            Console.WriteLine("ID: " + client.Id);
                            Console.WriteLine("Name: " + client.Name);
                            Console.WriteLine("Email: " + client.Email);
                            foundC3 = true;
                        }
                    }
                    if (!foundC3) Console.WriteLine("No matching clients found!");
                    break;
                case 4:
                    loop = false;
                    break;
                default:
                    Console.WriteLine("Choose 1 - 4");
                    break;
            }
        }

        
    }
}