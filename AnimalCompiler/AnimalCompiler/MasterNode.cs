using System;

namespace AnimalCompiler
{
    class MasterNode
    {
        static void Main()
        {
            MasterNode masterNode = new MasterNode();
            while (true)
            {
                Console.Write("~$ ");
                masterNode.Commands(Console.ReadLine());
            }
        }
        
        private void Commands(string command)
        {
            var utilities = new Utilities();
            switch (command)
            {
                
                
                
                
                
                
                
                
                
                
                case ("CreateClass"):
                    utilities.AddClass();
                    break;
                
                case ("Exit"):
                    utilities.Exit();
                    break;
            }
        }
        
        
    }
}