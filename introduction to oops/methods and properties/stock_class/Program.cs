using System;

class Stock
{
    string name, symbol;
    double previousPrice, currentPrice;

    public Stock(string n, string s, double p, double c)
    {
        name = n;
        symbol = s;
        previousPrice = p;
        currentPrice = c;
    }

    public double GetChangePercentage()
    {
        return ((currentPrice - previousPrice) / previousPrice) * 100;
    }

    static void Main()
    {
        Stock s = new Stock("Infosys", "INFY", 1500, 1650);

        Console.WriteLine("Stock Name : Infosys");
        Console.WriteLine("Percentage Change : " + s.GetChangePercentage() + "%");
    }
}
