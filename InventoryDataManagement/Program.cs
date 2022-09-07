using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDataManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "D:\\Lfp194\\InventoryDataManagement\\InventoryData.json ";

            FetchForJsonRiceData fetchForJsonRiceData = new FetchForJsonRiceData();

            Rice data=fetchForJsonRiceData.Read(filePath);

            //Console.WriteLine(data.typeOfRice.name);
            //Console.WriteLine(data.typeOfRice.weight);
            //Console.WriteLine(data.typeOfRice.price);

            for(int i=0;i<data.typeOfRice.Count;i++)
            {
                Console.WriteLine(data.typeOfRice[i].name);
                Console.WriteLine(data.typeOfRice[i].weight);
                Console.WriteLine(data.typeOfRice[i].price);
                Console.WriteLine("________________________");
            }

            Console.ReadLine();

        }
    }
}
