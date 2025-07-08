namespace CRM;

class Program
{
    static void Main(string[] args)
    {
        //przywitanie uzytkownika
        //wyswietlenie podstawowego menu
        ////a. dodanie nowego klienta
        ////b. usuniecie klienta
        ////c. wyświetlenie listy klientow
        ////d. filtrowanie klientow na podstawie rodzaju (firma/osoba prywatna)
        ////e. kontakt z klientem
        
        
        Console.WriteLine("Welcome to CRM!");
        bool loop = true;
        // while (loop)
        // {
            Console.WriteLine("Choose what You want to do:");
            Console.WriteLine("1) Add new client");
            Console.WriteLine("2) Remove client");
            Console.WriteLine("3) Show all clients");
            Console.WriteLine("4) Filter clients");
            Console.WriteLine("6) Exit");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ClientActions.AddClient();
                    
                    break;
                case 6:
                    loop = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
            
            
        // }
       
        
        
        
        
    }
}