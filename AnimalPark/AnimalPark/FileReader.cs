using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using AnimalPark.SubClasses;

namespace AnimalPark
{
    public static class FileReader
    {
        static List<string> lines = new List<string>();
        public static List<string> preConvertion = new List<string>();

        public static void Reader(string filePath, bool converter) 
        {
            lines = File.ReadAllLines(filePath).ToList();
            if (converter)
            {
                foreach (var line in lines)
                {
                    preConvertion.Add(line);
                }
            }
            else
            {
                foreach (var line in lines)
                {
                    string[] param = line.Split('|');
                    if (param[0] == "tiger")
                    {
                        try
                        {
                            Tiger tiger = new Tiger()
                            {
                                Name = param[1],
                                Age = float.Parse(param[2]),
                                Id = Int32.Parse(param[3]),
                                Weight = float.Parse(param[4]),
                                Length = float.Parse(param[5]),
                            };
                            ClassAdder.AnimalParkList.Add(tiger);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Something went wrong converting strings to objects");
                            Console.WriteLine(e);
                        }
                    }
                    else if (param[0] == "owl")
                    {
                        try
                        {
                            Owl owl = new Owl()
                            {
                                Name = param[1],
                                Age = float.Parse(param[2]),
                                Id = Int32.Parse(param[3]),
                                Weight = float.Parse(param[4]),
                                Length = float.Parse(param[5]),
                                Wingspan = float.Parse(param[6]),
                                Clawsize = float.Parse(param[7]),
                                Beaksize = float.Parse(param[8])
                            };
                            ClassAdder.AnimalParkList.Add(owl);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Something went wrong converting strings to objects");
                            Console.WriteLine(e);
                        }
                    }
                    else if(param[0] == "elephant")
                    {
                        try
                        {
                            Elephant elephant = new Elephant()
                            {
                                Name = param[1],
                                Age = float.Parse(param[2]),
                                Id = Int32.Parse(param[3]),
                                Weight = float.Parse(param[4]),
                                Length = float.Parse(param[5]),
                            };
                            ClassAdder.AnimalParkList.Add(elephant);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Something went wrong converting strings to objects");
                            Console.WriteLine(e);
                        }
                    }
                } 
            }
            
            
            
        }
 
       
    }
}