namespace AnimalCompiler
{ 
using System;
using System.Collections.Generic;
using System.IO;

class ClassCreation
{
    readonly List<ClassCreation> createClasses = new List<ClassCreation>();
    readonly List<string> strings = new List<string>();
    readonly List<string> integers = new List<string>();

    public string className;
    
    public static string ToUpperFirstLetter(string source)
    {
        if (string.IsNullOrEmpty(source))
            return string.Empty;
        // convert to char array of the string
        char[] letters = source.ToCharArray();
        // upper case the first char
        letters[0] = char.ToUpper(letters[0]);
        // return the array made of the new char array
        return new string(letters);
    }

    public void CreateClass()
    {
        ClassCreation cc = new ClassCreation();
        Console.WriteLine("Enter name: \n>>>");
        cc.className = (ToUpperFirstLetter(Console.ReadLine().ToLower()));
        Console.WriteLine("Add Integer attribute y/n?");
        if (Console.ReadLine().ToLower() == "y")
        {
            while (true)
            {
                Console.WriteLine("Enter atribute name\n>>>");
                cc.integers.Add(Console.ReadLine().ToLower());
                Console.WriteLine("Add another y/n?");
                if (Console.ReadLine().ToLower() == "n")
                {
                    break;
                }
            }
        }
        Console.WriteLine("Add String attribute y/n?");
        if (Console.ReadLine().ToLower() == "y")
        {
            while (true)
            {
                Console.WriteLine("Enter atribute name\n>>>");
                cc.strings.Add(Console.ReadLine().ToLower());
                Console.WriteLine("Add another y/n?");
                if (Console.ReadLine().ToLower() == "n")
                {
                    break;
                }
            }
        }
        createClasses.Add(cc);
        //cc.Write();
        cc.GetFinal();
    }

    public string GenerateClass()
    {
        return "class " + className + " : Animal\n{";
    }

  
    

    public string GenerateBody()
    {
        string bod1 = "";
        string bod2 = "";
        foreach (string s in strings)
        {
            bod1 = bod1 + "\n     public string " + s + ";";
        }
        foreach (string i in integers)
        {
            bod2 = bod2 + "\n     public int " + i + ";";
        }
        return bod1 + bod2;
    }

    public string FinalGeneration()
    {
        string gClass = GenerateClass();
        string gBody = GenerateBody();
        string final = gClass + gBody + "\n}";
        return final;
    }
/*
    public void Write()
    {
        using (StreamWriter sw = new StreamWriter(@"..\..\..\animals\" + className + ".cs"))
        {
            sw.Write(FinalGeneration());
        }
    }s
*/
    public void GetFinal()
    {
        Console.WriteLine(FinalGeneration());
    }
}

}