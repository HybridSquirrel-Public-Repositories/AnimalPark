using System;
using System.Collections.Generic;
using AnimalPark.SubClasses;

namespace AnimalPark
{
    public static class SortManager
    {

        public static void Sortings(string param)
        {

            switch (param)
            {
                case ("all"):
                    SelectionSort(ClassAdder.AnimalParkList, "name");
                    foreach (var animal in ClassAdder.AnimalParkList)
                    {
                        Console.WriteLine(animal.Name + " " + animal.Age + " " +  animal.Weight  + " " +  animal.Length  + " " +  animal.Id);
                    }
                    break;
                
                case ("name"):
                    SelectionSort(ClassAdder.AnimalParkList, "name");
                    foreach (var animal in ClassAdder.AnimalParkList)
                    {
                        Console.WriteLine(animal.Name);
                    }

                    break;
                case ("age"):
                    SelectionSort(ClassAdder.AnimalParkList, "age");
                    foreach (var animal in ClassAdder.AnimalParkList)
                    {
                        Console.WriteLine(animal.Name + " " + animal.Age);
                    }

                    break;

                case ("weight"):
                    SelectionSort(ClassAdder.AnimalParkList, "weight");
                    foreach (var animal in ClassAdder.AnimalParkList)
                    {
                        Console.WriteLine(animal.Name + " " + animal.Weight);
                    }

                    break;
                case ("length"):
                    SelectionSort(ClassAdder.AnimalParkList, "length");
                    foreach (var animal in ClassAdder.AnimalParkList)
                    {
                        Console.WriteLine(animal.Name + " " + animal.Length);
                    }

                    break;

                
                case ("tigerweight"):
                    PropertySort("tiger");
                    break;

                case ("owlwingspan"):
                    PropertySort("owl");
                    break;
                                
                case ("elephanttrunk"):
                    PropertySort("elephant");
                    break;
            }
        }

        private static void SelectionSort(List<Animal> list, string mode)
        {
            int count, miniPos;
            count = list.Count;
            for (int i = 0; i < count - 1; i++)
            {
                miniPos = i;
                for (int j = i + 1; j < count; j++)
                {
                    switch (mode)
                    {
                        case ("name"):
                            if (list[j].Name.CompareTo(list[miniPos].Name) < 0)
                            {
                                miniPos = j;
                            }

                            break;
                        case ("age"):
                            if (list[j].Age.CompareTo(list[miniPos].Age) > 0)
                            {
                                miniPos = j;
                            }

                            break;
                        case ("weight"):
                            if (list[j].Weight.CompareTo(list[miniPos].Weight) > 0)
                            {
                                miniPos = j;
                            }

                            break;
                        case ("length"):
                            if (list[j].Length.CompareTo(list[miniPos].Length) > 0)
                            {
                                miniPos = j;
                            }

                            break;
                    }
                }

                Animal temp = list[miniPos];
                list[miniPos] = list[i];
                list[i] = temp;
            }
        }

        private static void PropertySort(string animalSelect)
        {
            int count, miniPos;
            switch (animalSelect)
            {
                    
                case ("tiger"):
                    List<Tiger> tigers = new List<Tiger>();
                    foreach (var animal in ClassAdder.AnimalParkList)
                    {
                        if (animal is Tiger)
                        {
                            Tiger tiger = animal as Tiger;
                            tigers.Add(tiger);
                        }
                    }
                    
                    count = tigers.Count;
                    for (int i = 0; i < count - 1; i++)
                    {
                        miniPos = i;
                        for (int j = i + 1; j < count; j++)
                        {
                            if (tigers[j].Weight.CompareTo(tigers[miniPos].Weight) < 0)
                            {
                                miniPos = j;
                            }


                            
                        }

                        Tiger temp = tigers[miniPos];
                        tigers[miniPos] = tigers[i];
                        tigers[i] = temp;
                    }

                    foreach (var tiger in tigers)
                    {
                        Console.WriteLine(tiger.Name + " " + tiger.Weight);
                    }
                    break;
                
                case ("owl"):
                    List<Owl> owls = new List<Owl>();
                    foreach (var animal in ClassAdder.AnimalParkList)
                    {
                        if (animal is Owl)
                        {
                            Owl owl = animal as Owl;
                            owls.Add(owl);
                        }
                    }

                    count = owls.Count;
                    for (int i = 0; i < count - 1; i++)
                    {
                        miniPos = i;
                        for (int j = i + 1; j < count; j++)
                        {
                            if (owls[j].Wingspan.CompareTo(owls[miniPos].Wingspan) < 0)
                            {
                                miniPos = j;
                            }


                            
                        }

                        Owl temp = owls[miniPos];
                        owls[miniPos] = owls[i];
                        owls[i] = temp;
                    }

                    foreach (var owl in owls)
                    {
                        Console.WriteLine(owl.Name + " " + owl.Wingspan);
                    }
                    break;

                
                case ("elephant"):
                    List<Elephant> elephants = new List<Elephant>();
                    foreach (var animal in ClassAdder.AnimalParkList)
                    {
                        if (animal is Elephant)
                        {
                            Elephant elephant = animal as Elephant;
                            elephants.Add(elephant);
                        }
                    }

                    count = elephants.Count;
                    for (int i = 0; i < count - 1; i++)
                    {
                        miniPos = i;
                        for (int j = i + 1; j < count; j++)
                        {
                            if (elephants[j].Trunklenth.CompareTo(elephants[miniPos].Trunklenth) < 0)
                            {
                                miniPos = j;
                            }


                            
                        }

                        Elephant temp = elephants[miniPos];
                        elephants[miniPos] = elephants[i];
                        elephants[i] = temp;
                    }

                    foreach (var elephant in elephants)
                    {
                        Console.WriteLine(elephant.Name + " " + elephant.Trunklenth);
                    }
                    break;
                    

                
            }
           

        
            
        }
        
        
        
        
    }
}