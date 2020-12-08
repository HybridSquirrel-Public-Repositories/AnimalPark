using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using AnimalPark.SubClasses;

namespace AnimalPark
{
    public static class FileWriter
    {


        public static void Writer(string filePath, List<Animal> list, bool removed)
        {
            foreach (var animal in list)
            {
                if (animal is Tiger)
                {
                    Tiger tiger = animal as Tiger;
                   
                    if (removed)
                    {
                        FileReader.preConvertion.Add(nameof(tiger) + "|" + tiger.Name + "|" + tiger.Age + "|" + tiger.Id + "|" + tiger.Weight + "|" + tiger.Length + 
                                                     "|Removed|" + DateTime.Now.ToString("MM/dd/yyyy HH:mm"));
                    }
                    else
                    {
                        FileReader.preConvertion.Add(nameof(tiger) + "|" + tiger.Name + "|" + tiger.Age + "|" + tiger.Id + "|" + tiger.Weight + "|" + tiger.Length);
                    }
                }
                else if (animal is Owl)
                {
                    Owl owl = animal as Owl;
                    
                    if (removed)
                    {
                        FileReader.preConvertion.Add(nameof(owl) + "|" + owl.Name + "|" + owl.Age + "|" + owl.Id + "|" + owl.Weight + "|" + owl.Length + 
                                                     "|" + owl.Wingspan + "|" + owl.Clawsize + "|" + owl.Beaksize + "|Removed|" + DateTime.Now.ToString("MM/dd/yyyy HH:mm"));
                    }
                    else
                    {
                        FileReader.preConvertion.Add(nameof(owl) + "|" + owl.Name + "|" + owl.Age + "|" + owl.Id + "|" + owl.Weight + "|" + owl.Length + 
                                                     "|" + owl.Wingspan + "|" + owl.Clawsize + "|" + owl.Beaksize);
                    }
                }
                else if(animal is Elephant)
                {
                    Elephant elephant = animal as Elephant;
                   
                    if (removed)
                    {
                        FileReader.preConvertion.Add(nameof(elephant) + "|" + elephant.Name + "|" + elephant.Age + "|" + elephant.Id + "|" + elephant.Weight + "|" + elephant.Length + 
                                                     "|" + elephant.Trunklenth + "|Removed|" + DateTime.Now.ToString("MM/dd/yyyy HH:mm"));
                    }
                    else
                    {
                        FileReader.preConvertion.Add(nameof(elephant) + "|" + elephant.Name + "|" + elephant.Age + "|" + elephant.Id + "|" + elephant.Weight + "|" + elephant.Length + 
                                                     "|" + elephant.Trunklenth);
                    }
                }
            }

            foreach (var thing in FileReader.preConvertion)
            {
                Console.WriteLine("**" + thing);
            }
            
            File.WriteAllLines(filePath,FileReader.preConvertion);
            FileReader.preConvertion.Clear();
        }
    }
}