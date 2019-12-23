using System;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args) 
        {
            CustomList<object> customList = new CustomList<object>();

            customList.Add("Gosho");
            customList.Add("Iv4o");
            customList.Add("12");
            customList.Add("10.5");
            
            //customList.Remove("Iv4o");

            customList[3] = "Victor";

            for (int i = 0; i < customList.Count; i++)
            {
                Console.WriteLine(customList[i]);
            }


        }
    }
}
