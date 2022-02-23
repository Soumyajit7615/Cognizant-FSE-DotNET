using System;
using System.Collections.Generic;
using System.Text;

public class Product
{
    public string _productName;
    public string _serialNumber;
    public DateTime _purchaseDate;
    public double _purchaseCost;

    // Implement 4-Argument Constructor
    public Product(string productName, string serialNumber, DateTime purchaseDate, double purchaseCost)
    {
        this._productName = productName;
        this._serialNumber = serialNumber;
        this._purchaseDate = purchaseDate;
        this._purchaseCost = purchaseCost;
    }

    // Implement Properties
    public string ProductName
    {
        set => this._productName = value;
        get => this._productName;
    }
    public string SerialNumber
    {
        set => this._serialNumber = value;
        get => this._serialNumber;
    }
    public DateTime PurchaseDate
    {
        set => this._purchaseDate = value;
        get => this._purchaseDate;
    }
    public double Cost
    {
        set => this._purchaseCost = value;
        get => this._purchaseCost;
    }
    public override string ToString()
    {
        return $"{ProductName,-15}{SerialNumber,-15}{$"{PurchaseDate:d}",-15}{Cost,-15}";
    }
}
