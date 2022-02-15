using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgFundamentals2  //DO NOT change the namespace name
{
    public class Program      //DO NOT change the class name
    {
        public static void Main(string[] args)     //DO NOT change the 'Main' method signature
        {
            //Implement the code here
            int costPerPizza = 200, costPerPuffs = 40, costPerPepsi = 120;
            double GST, CESS;
            
            
            Console.WriteLine("Enter the number of pizzas bought: ");
            int noOfPizzas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of puffs bought: ");
            int noOfPuffs = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of pepsi bought: ");
            int noOfPepsi = Convert.ToInt32(Console.ReadLine());
            
            int totalCostOfPizzas = FindTotal(noOfPizzas, costPerPizza), 
            totalCostOfPuffs = FindTotal(noOfPuffs, costPerPuffs), 
            totalCostOfPepsi = FindTotal(noOfPepsi, costPerPepsi);
            
            int totalAmount = totalCostOfPizzas + totalCostOfPuffs + totalCostOfPepsi;
            
            GST = totalAmount * 0.12;
            CESS = totalAmount * 0.05;
            
            Console.WriteLine("Bill Details\n");
            Console.WriteLine($"Cost of Pizzas :{totalCostOfPizzas}");
            Console.WriteLine($"Cost of Puffs :{totalCostOfPuffs}");
            Console.WriteLine($"Cost of Pepsis :{totalCostOfPepsi}");
            
            Console.WriteLine($"GST 12% : {GST}");
            Console.WriteLine($"CESS 5% : {CESS}");
            
            Console.WriteLine($"Total Price :{totalAmount}");
            
        }
        
        public static int FindTotal(int itemQuantity, int costPerItem){
            return itemQuantity * costPerItem;
        }
    }
}
