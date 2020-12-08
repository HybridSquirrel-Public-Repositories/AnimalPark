using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using AnimalPark.SubClasses;


namespace AnimalPark
{
    public class Utilities
    {


        public ClassAdder ca = new ClassAdder();

        public static string pathway;
        public static string pathwayRemove;
        public static string pathwaySuper;
        public static string pathwaySub;
       
        
        private void ListingClass(string path, string filePrefix)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(@"" + path);
            FileInfo[] fileInfos = directoryInfo.GetFiles("*" + filePrefix);
            foreach (var file in fileInfos)
            {
                Console.WriteLine(file.Name.Substring(0, file.Name.Length - 3));
            }
        }
        
        
        public void ListClasses()
        {
            Console.WriteLine();
            Console.WriteLine("Core Animal Categories: ");
            ListingClass(pathwaySuper, ".cs");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Sub Animal Categories: ");
            ListingClass(pathwaySub, ".cs");
            Console.WriteLine();
        }

        

        
        public void RemoveAnimal(int index)
        {
            RemoveManager.Remove(index, pathwayRemove, pathway);
        }
        
        
        
        
        
        
        

        
        
        

        
        
        
        
        


        
        
        
        
        
        
        public void Sort(string param)
        {
            SortManager.Sortings(param);
        }
        
        
        
        
        
        
        
        

        
        
        
        
        
        
        public void AddAnimal(string species)
        {
            switch (species)
            {
                case("tiger"):
                    ClassAdder.AnimalParkList.Add(ca.ReturnTiger());
                    break;
                
                case ("owl"):
                    ClassAdder.AnimalParkList.Add(ca.ReturnOwl());
                    break;
                
                case ("elephant"):
                    ClassAdder.AnimalParkList.Add(ca.ReturnElephant());
                    break;
            }
        }


        
        public Animal ListAnimals(string param)
        {
            switch (param)
            {
                case("all"):
                    foreach (var animal in ClassAdder.AnimalParkList)
                    {
                        Console.WriteLine(animal.Name);
                    }
                    break;
                case("listindex"):
                    int index = 0;
                    foreach (var animal in ClassAdder.AnimalParkList)
                    {
                        Console.WriteLine(index + " " +animal.Name);
                    }
                    break;
                case("tiger"):
                    foreach (var animal in ClassAdder.AnimalParkList)
                    {
                        if (animal is Tiger)
                        {
                            Console.WriteLine(animal.Name);
                        }
                    }
                    break;
                case("owl"):
                    foreach (var animal in ClassAdder.AnimalParkList)
                    {
                        if (animal is Owl)
                        {
                            Console.WriteLine(animal.Name);
                        }
                    }
                    break;
                case("elephant"):
                    foreach (var animal in ClassAdder.AnimalParkList)
                    {
                        if (animal is Elephant)
                        {
                            Console.WriteLine(animal.Name);
                        }
                    }
                    break;
            }
            return null;
        }
        
        
        public void Exit()
        {
            FileReader.preConvertion.Clear();
            FileWriter.Writer(pathway, ClassAdder.AnimalParkList, false);
            Environment.Exit(0);
        }
        
    }
}