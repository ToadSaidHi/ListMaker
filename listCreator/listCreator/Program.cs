using System;
using System.IO;

namespace listCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool active = true;
            while (active = true)
            {
                Console.WriteLine("New, existing, view or delete");
                string comm = Console.ReadLine();
                if (comm == "new")
                {
                    Console.WriteLine("Enter list name. Case and space sensitive.");
                    string newlist = Console.ReadLine();
                    File.Create("c:/lists/" + newlist + ".txt");
                    Console.WriteLine("Created!");
                }
                else if (comm == "existing")
                {
                    Console.WriteLine("Enter list name. Case and space sensitive.");
                    string list = Console.ReadLine();

                    while (active == true)
                    {
                        string file = "c:/lists/" + list + ".txt";
                        string contents = File.ReadAllText(file);

                        Console.WriteLine("Add new line");

                        File.WriteAllText(file, contents + Environment.NewLine + Console.ReadLine());
                    }

                }
                else if (comm == "delete")
                {
                    Console.WriteLine("WARNING! THERE IS NO UNDO! Press any key to enter");
                    comm = Console.ReadLine();
                    Console.WriteLine("Enter list name. Case and space sensitive.");
                    string list = Console.ReadLine();
                    string file = "c:/lists/" + list + ".txt";
                    File.Delete(file);
                    Console.WriteLine("Deleted!");
                }
                else if (comm == "view") {
                    Console.WriteLine("Enter list name. Case and space sensitive.");
                    string list = Console.ReadLine();
                    string file = "c:/lists/" + list + ".txt";
                    string contents = File.ReadAllText(file);
                    Console.WriteLine(contents);
                }
                else
                {
                    Console.WriteLine("Invalid Command");
                }





            }
        }
    }
}
