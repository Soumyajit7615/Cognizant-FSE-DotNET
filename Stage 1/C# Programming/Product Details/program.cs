using System;
using System.Collections;
using System.Globalization;
using System.IO;


public class Program //DO NOT CHANGE the name of class 'Program'
{
    public static void Main(string[] args) //DO NOT CHANGE 'Main' Signature
    {
        //Fill the code here
        StreamReader reader = new StreamReader("input.csv");
        string line = "";
        ArrayList productList = new ArrayList();
        while ((line = reader.ReadLine()) != null)
        {
            string[] product = line.Split(',');
            string productName = product[0].Trim();
            string serialNumber = product[1].Trim();
            DateTime purchaseDate = DateTime.ParseExact(product[2].Trim(), "dd-MM-yyyy", null);
            double purchaseCost = Convert.ToDouble(product[3].Trim());

            productList.Add(new Product(productName, serialNumber, purchaseDate, purchaseCost));
        }

        Console.WriteLine(
            $"{"Product Name",-15}{"Serial Number",-15}{"Purchase Date",-15}{"Cost",-15}");
        
        foreach (Product obj in productList)
        {
            Console.WriteLine(obj.ToString());
        }
    }
}
