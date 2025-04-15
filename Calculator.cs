namespace Assignment_2._3;

public class Calculator
{
    
    public float TipAmount { get ; set; }
    public float BillAmount { get; set; }
    public float TotalAmount { get; set; }

    public float CalculateTipAmount(float billAmount, float tipPercentage)
    {
        TipAmount = billAmount * tipPercentage / 100;
        return TipAmount;
    }
    public float CalculateTotalAmount(float billAmount, float tipAmount)
    {
        TotalAmount = billAmount + tipAmount;
        return TotalAmount;
    }

    public void GetTipPercentageAndTotalBill()
    {
        Console.WriteLine("Enter the tip percentage: ");
        float tipPercentage = float.Parse(Console.ReadLine());
        CalculateTipAmount(BillAmount, tipPercentage);
        CalculateTotalAmount(BillAmount, TipAmount);
        PrintTransaction();
    }
    
    public void PrintTransaction()
    {
        Console.WriteLine($"""
                           Your bill is {BillAmount}
                           Your tip is {TipAmount}
                           Your total is {TotalAmount}
                           """);
    }
    
}