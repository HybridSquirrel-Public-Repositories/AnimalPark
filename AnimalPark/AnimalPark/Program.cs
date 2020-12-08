using System;
using System.IO;

namespace AnimalPark
{
    class Program
    {
        Utilities utilities = new Utilities();

        
        public static void Main()
        {

            string computername = Environment.MachineName;
            string username = Environment.UserName;
            

            var osNameAndVersion = System.Runtime.InteropServices.RuntimeInformation.OSDescription;
            string wanted_path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            if (osNameAndVersion.Contains("Windows"))
            {
                //works on any windows computer
                Utilities.pathway = (@"" + wanted_path + "\\..\\AnimalPark.txt") ;
                Utilities.pathwayRemove = (@"" + wanted_path + "\\..\\RemovedAnimals.txt");
                Utilities.pathwaySuper = (@"" + wanted_path + "\\..\\SuperClasses");
                Utilities.pathwaySub = (@"" + wanted_path + "\\..\\SubClasses");
            }
            else
            {
                //just works on my linux computer
                Utilities.pathway = @"/home/squirrel/Projects/C#/AnimalPark/AnimalPark/AnimalPark/AnimalPark.txt";
                Utilities.pathwayRemove = @"/home/squirrel/Projects/C#/AnimalPark/AnimalPark/AnimalPark/RemovedAnimals.txt";
                Utilities.pathwaySuper = @"/home/squirrel/Projects/C#/AnimalPark/AnimalPark/AnimalPark/SuperClasses";
                Utilities.pathwaySub = @"/home/squirrel/Projects/C#/AnimalPark/AnimalPark/AnimalPark/SubClasses";
                
            }
            
            OnceLoader();
            FileReader.Reader(Utilities.pathway, false);
            Program p = new Program();
            p.Commands("help");
            while (true)
            {
                    
                Console.Write(username + "@" + computername + ":~$ ");
                p.Commands(Console.ReadLine().ToLower());
            }
        }
        
        private void Commands(string command)
        {
        
            switch (command)
            {
                
                case ("list"):
                    Console.WriteLine("all - lists all animals\nlistindex - lists all animals with index\n" +
                                      "tiger - lists only tigers\nowl - lists only owls\nelephant - lists only elephants");
                    utilities.ListAnimals(Console.ReadLine().ToLower());
                    break;
                
                case ("add"):
                    Console.WriteLine("tiger - adds tiger\nowl - adds owl\nelephant - adds elephant");
                    utilities.AddAnimal(Console.ReadLine().ToLower());
                    break;
                
                case ("remove"):
                    try
                    {
                        utilities.ListAnimals("listindex");
                        utilities.RemoveAnimal(int.Parse(Console.ReadLine()));
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("that was not a number");
                    }

                    break;
                
                case ("listac"):
                    utilities.ListClasses();
                    break;
                
                case ("clear"):
                    Console.Clear();
                    break;
                
                case ("exit"):
                    utilities.Exit();
                    break;
                
                case ("sort"):
                    Console.WriteLine("all - shows all property's\nname - sorts by name\nage - sorts by age\nweight - sorts by weight\nlenght - sorts by length\n" +
                                      "elephanttrunk - sort elephant by trunklenth\nowlwingspan - sorts owls by wingspan\ntigetweight - sorts tigers by weight");
                    utilities.Sort(Console.ReadLine().ToLower());
                    break;
                case("help"):
                    Console.WriteLine("Commands:");
                    Console.WriteLine("help - shows commands\nlist - show animals\nadd - adds animals\nremove - removes animals\nlistac - lists all" +
                                      "\nclear - clears console\nexit - saves and exits the program\nsort - sorts animals");
                    break;
            }
        }

        static void PreLoader()
        {
            ParameterList.AnimalPara(true);
            ParameterList.MammalPara(true);
            ParameterList.BirdPara(true);
            ParameterList.ReptilePara(true);
            ParameterList.AmphibianPara(true);
            ParameterList.FishPara(true);
            
            ParameterList.TigerPara(true);
            ParameterList.ElephantPara(true);
            ParameterList.OwlPara(true);
        }

        static void OnceLoader()
        {
            bool once = false;
            if (!once)
            {
                PreLoader();
                once = true;
            }
        }
        
        
        
    }
}