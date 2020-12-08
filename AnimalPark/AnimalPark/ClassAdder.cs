using System;
using System.Collections.Generic;
using AnimalPark.SubClasses;
using System.Text;
namespace AnimalPark
{
    public class ClassAdder
    {
        
        
        static public List<Animal> AnimalParkList = new List<Animal>();

        
        static int Random(int min, int max)
        {
            Random rnd = new Random();
            return rnd.Next(min, max);
        }

        private int GenID(string mode, string firstValue, string secondValue)
        {
            if (mode == "tiger")
            {
                try
                {
                    string tempName;
                    string tempName2 = "";

                    byte[] charValue = Encoding.ASCII.GetBytes(firstValue.Substring(0, 3));

                    for (int i = 0; i < charValue.Length; i++)
                    {
                        tempName = charValue[i].ToString();
                        tempName2 += tempName;
                    }

                    int tempId = Int32.Parse(tempName2);
                    tempId *= int.Parse(secondValue);
                    return Math.Abs(Int32.Parse(tempId.ToString().Substring(0, 6)));
                }
                catch (Exception e)
                {
                    Console.WriteLine("The name does not contain 3 letters!");
                    
                }
            }
            else if (mode == "owl")
            {
                int temp = int.Parse(firstValue);
                for (int i = firstValue.Length; i <= 2; i++)
                {
                    temp = temp * 10;
                }

                string str = temp.ToString();
                return int.Parse(str + Random(100, 999).ToString());

            }
            else if (mode == "elehpant")
            {
                string temp = firstValue;
                for (int i = 0; i < 3; i += temp.Length)
                {
                    temp += temp;
                }

                temp += temp;
                return int.Parse(temp.Substring(0, 6));

            }
            else if (mode == "random")
            {
                return Random(99999, 1000000);
            }

            return 0;
        }
        
      
        public Tiger ReturnTiger()
        {

            List<string>tigerParam = new List<string>();
            bool ms = true;
            foreach (var para in ParameterList.tigerParaList)
            {
                Console.WriteLine(para + ": ");
                string str = Console.ReadLine();
                if (ms)
                {
                    
                    
                    if (String.IsNullOrEmpty(str))
                    {
                        Console.WriteLine("Invaild, retry!");
                        return null;
                    }
                    StringBuilder sb = new StringBuilder(str);
                    if (Char.IsLower(sb[0]))
                    {
                        sb[0] = Char.ToUpper(sb[0]);
                        str = sb.ToString();

                    }
                    
                    
                    foreach (Animal animal in AnimalParkList)
                    {
                        if (animal is Tiger)
                        {
                            if (str == animal.Name)
                            {
                                Console.WriteLine("Can't have same in same kind of species");
                                return null;
                            }
                        }
                    }

                    
                    tigerParam.Add(str);
                    ms = false;
                }
                else
                {
                    try
                    {
                        float num = float.Parse(str);
                        tigerParam.Add(num.ToString());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("That's not a decimal number!");
                        return null;
                    }
                }
            }
            Tiger tiger = new Tiger()
            {
                Name = tigerParam[0],
                Age = float.Parse(tigerParam[1]),
                Weight = float.Parse(tigerParam[2]),
                Length = float.Parse(tigerParam[3]),
                Height = float.Parse(tigerParam[4]),
                Id = GenID("tiger", tigerParam[0],tigerParam[2])
            };
            return tiger;
        }
        
        
        public Owl ReturnOwl()
        {

            List<string>owlParam = new List<string>();
            bool ms = true;
            foreach (var para in ParameterList.owlParaList)
            {
                Console.WriteLine(para + ": ");
                string str = Console.ReadLine();
                if (ms)
                {
                    
                    
                    if (String.IsNullOrEmpty(str))
                    {
                        Console.WriteLine("Invaild, retry!");
                        return null;
                    }
                    StringBuilder sb = new StringBuilder(str);
                    if (Char.IsLower(sb[0]))
                    {
                        sb[0] = Char.ToUpper(sb[0]);
                        str = sb.ToString();

                    }
                    
                    
                    foreach (Animal animal in AnimalParkList)
                    {
                        if (animal is Owl)
                        {
                            if (str == animal.Name)
                            {
                                Console.WriteLine("Can't have same in same kind of species");
                                return null;
                            }
                        }
                    }

                    
                    owlParam.Add(str);
                    ms = false;
                }
                else
                {
                    try
                    {
                        float num = float.Parse(str);
                        owlParam.Add(num.ToString());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("That's not a decimal number!");
                        return null;
                    }
                }
            }
            Owl owl = new Owl()
            {
                Name = owlParam[0],
                Age = float.Parse(owlParam[1]),
                Weight = float.Parse(owlParam[2]),
                Length = float.Parse(owlParam[3]),
                Wingspan = float.Parse(owlParam[4]),
                Clawsize = float.Parse(owlParam[5]),
                Beaksize = float.Parse(owlParam[6]),
                Id = GenID("owl", owlParam[4],owlParam[3])
            };
            return owl;
        }
          
          
        public Elephant ReturnElephant()
        {

            List<string>elephantParam = new List<string>();
            bool ms = true;
            foreach (var para in ParameterList.elephantParaList)
            {
                Console.WriteLine(para + ": ");
                string str = Console.ReadLine();
                if (ms)
                {
                    
                    
                    if (String.IsNullOrEmpty(str))
                    {
                        Console.WriteLine("Invaild, retry!");
                        return null;
                    }
                    StringBuilder sb = new StringBuilder(str);
                    if (Char.IsLower(sb[0]))
                    {
                        sb[0] = Char.ToUpper(sb[0]);
                        str = sb.ToString();

                    }
                    
                    
                    foreach (Animal animal in AnimalParkList)
                    {
                        if (animal is Owl)
                        {
                            if (str == animal.Name)
                            {
                                Console.WriteLine("Can't have same in same kind of species");
                                return null;
                            }
                        }
                    }

                    
                    elephantParam.Add(str);
                    ms = false;
                }
                else
                {
                    try
                    {
                        float num = float.Parse(str);
                        elephantParam.Add(num.ToString());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("That's not a decimal number!");
                        return null;
                    }
                }
            }
            Elephant elephant = new Elephant()
            {
                Name = elephantParam[0],
                Age = float.Parse(elephantParam[1]),
                Weight = float.Parse(elephantParam[2]),
                Length = float.Parse(elephantParam[3]),
                Trunklenth = float.Parse(elephantParam[4]),
                Id = GenID("elephant", elephantParam[4],elephantParam[4])
            };
            return elephant;
        }
        
        
        

    }
}