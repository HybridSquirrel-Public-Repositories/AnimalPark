using System.Collections.Generic;
using System.Net;

namespace AnimalPark
{
    public static class RemoveManager
    {
        public static void Remove(int index,string pathwayRemove, string pathway)
        {
            FileReader.preConvertion.Clear();
            List<Animal> animalRemove = new List<Animal>();
            
            animalRemove.Add(ClassAdder.AnimalParkList[index]);
            FileReader.preConvertion.Clear();
            FileReader.Reader(pathwayRemove, true);

            
            
            FileWriter.Writer(pathwayRemove, animalRemove, true);
            FileReader.preConvertion.Clear();
            animalRemove.Clear();
            
            
            ClassAdder.AnimalParkList.RemoveAt(index);
            
            FileWriter.Writer(pathway, ClassAdder.AnimalParkList, false);

            
        }
    }
}