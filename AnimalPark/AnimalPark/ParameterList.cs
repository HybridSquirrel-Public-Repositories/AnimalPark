using System;
using System.Collections.Generic;

namespace AnimalPark
{
    public static class ParameterList
    {
        
        public static List<string> animalParaList = new List<string>();
        public static void AnimalPara(bool preload)
        {
            if(preload)
            {
                animalParaList.Add("Name");
                animalParaList.Add("Age");
                animalParaList.Add("Weight");
                animalParaList.Add("Length");
            }
            else
            {
                foreach (var para in animalParaList)
                {
                    Console.WriteLine(para);
                }
            }
        }
        
        public static List<string> amphibianParaList = new List<string>();
        public static void AmphibianPara(bool preload)
        {
            if(preload)
            {
                foreach (var para in animalParaList)
                {
                    amphibianParaList.Add(para);
                }
                amphibianParaList.Add("Tailsize");
                amphibianParaList.Add("Venomous");
            }
            else
            {
                
                foreach (var para in amphibianParaList)
                {
                    Console.WriteLine(para);
                }
            }

        }
        
        public static List<string> birdParaList = new List<string>();
        public static void BirdPara(bool preload)
        {
            if(preload)
            {
                foreach (var para in animalParaList)
                {
                    birdParaList.Add(para);
                }
                birdParaList.Add("Wingspan");
                birdParaList.Add("Clawsize");
                birdParaList.Add("Beaksize");
            }
            else
            {
                            
                foreach (var para in birdParaList)
                {
                    Console.WriteLine(para);
                }
            }
            

        }
        
        public static List<string> fishParaList = new List<string>();
        public static void FishPara(bool preload)
        {
            if(preload)
            {
                foreach (var para in animalParaList)
                {
                    fishParaList.Add(para);
                }
                fishParaList.Add("Dorsalfin");
                fishParaList.Add("Pectoralfin");
                fishParaList.Add("Caudalfin");
                fishParaList.Add("Venomous");
            }
            else
            {
                foreach (var para in fishParaList)
                {
                    Console.WriteLine(para);
                }
            }

        }
        
        public static List<string> mammalParaList = new List<string>();
        public static void MammalPara(bool preload)
        {
            if(preload)
            {
                foreach (var para in animalParaList)
                {
                    mammalParaList.Add(para);
                }
                mammalParaList.Add("Height");
            }
            else
            {
                foreach (var para in mammalParaList)
                {
                    Console.WriteLine(para);
                }
            }

        }
        
        public static List<string> reptileParaList = new List<string>();
        public static void ReptilePara(bool preload)
        {
            if(preload)
            {
                foreach (var para in animalParaList)
                {
                    reptileParaList.Add(para);
                }
                reptileParaList.Add("Tailsize");
                reptileParaList.Add("Venomous");
            }
            else
            {
                foreach (var para in reptileParaList)
                {
                    Console.WriteLine(para);
                }
            }

        }
        
        
        public static List<string> tigerParaList = new List<string>();
        public static void TigerPara(bool preload)
        {
            if(preload)
            {
                foreach (var para in mammalParaList)
                {
                    tigerParaList.Add(para);
                }
            }
        }
        
        
        public static List<string> owlParaList = new List<string>();
        public static void OwlPara(bool preload)
        {
            if(preload)
            {
                foreach (var para in birdParaList)
                {
                    owlParaList.Add(para);
                }
            }
            
        }
        
        
        public static List<string> elephantParaList = new List<string>();
        public static void ElephantPara(bool preload)
        {
            if(preload)
            {
                foreach (var para in mammalParaList)
                {
                    elephantParaList.Add(para);
                }
                elephantParaList.Add("Trunklenth");
            }
            else
            {
                foreach (var para in elephantParaList)
                {
                    Console.WriteLine(para);
                }
            }

            
        }
    }
}