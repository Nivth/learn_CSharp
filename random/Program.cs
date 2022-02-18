// coy dotnet cuman bisa run 1 file dengan nama Program 
namespace woi
{
    class Program
    {
        static void Main(string[] args)
        {
            // =================== Comment <-- comment lah apalagi
            // Console.WriteLine("Hello, World!");
            // Console.WriteLine("      /|");
            // Console.WriteLine("     / |");
            // Console.WriteLine("    /  |");
            // Console.WriteLine("   /   |");
            // Console.WriteLine("  /    |");
            // Console.WriteLine(" /_____|");

            // =================== Data Types
            // anjim kalo variable gak di pake kuning coy zzzz
            string name = "Squidward Tentacles"; // String
            // char Blood = 'O'; // single character
            int age = 35; // int is a whole number
            // float height = 1.75; // inches
            // double weight = 180.5; // double is a double-precision floating-point number
            // decimal money = 100.5; // decimal is a type of float
            // bool isMale = true; //true or false

            Console.WriteLine("⠀⠀⠀⢀⣀⣤⣴⣶⣶⣾⣿⣷⣶⣶⣦⣄⡀⠀⠀⠀");
            Console.WriteLine("⠀⢠⣴⣿⣿⣿⣿⣿⣭⣭⣭⣭⣭⣿⣿⣿⣿⣧⣀⠀");
            Console.WriteLine("⢰⣿⣿⣿⣿⣿⣯⣿⡶⠶⠶⠶⠶⣶⣭⣽⣿⣿⣷⣆");
            Console.WriteLine("⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿");
            Console.WriteLine("⠈⢿⣿⣿⡿⠋⠉⠁⠈⠉⠛⠉⠀⠀⠀⠈⠻⣿⡿⠃");
            Console.WriteLine("⠀⠀⠀⠉⠁⠀⢴⣐⢦⠀⠀⠀⣴⡖⣦⠀⠀⠈⠀⠀");
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠈⠛⠋⠀⠀⠀⠈⠛⠁⠀⠀⠀⠀⠀");
            Console.WriteLine("⠀⠀⠀⠀⠀⣀⡀⠀⠀⠀⣀⠀⠀⠀⢀⡀⠀⠀⠀⠀");
            Console.WriteLine("⠀⠀⢀⡔⣻⣭⡇⠀⣼⣿⣿⣿⡇⠦⣬⣟⢓⡄⠀⠀");
            Console.WriteLine("⠀⠀⠀⠉⠁⠀⠀⠀⣿⣿⣿⣿⡇⠀⠀⠉⠉⠀⠀⠀");
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠻⠿⠿⠟⠁⠀⠀⠀⠀⠀⠀⠀");
            Console.WriteLine($"the name is {name} and {age} years old");
            // Console.WriteLine("");
            // Console.WriteLine("");


            string yea = "yooo shit mannn";
            string y = yea[0].ToString(); // ok ok pal, i got it
            Console.WriteLine(yea.Length); // ok ok 
            Console.WriteLine(y.ToUpper());
            Console.WriteLine(yea.IndexOf("shit")); // if -1 then not found

            // ================Getting input
            Console.Write("What is your name? ");
            string nameInput = Console.ReadLine();
            Console.WriteLine("Hello, " + nameInput);
        }
    }
}
