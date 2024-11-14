namespace Assignments_2._3._2
{
    class Tip
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the total bill amount: ");
            decimal billTotal = decimal.Parse(Console.ReadLine());

            Console.Write("Enter the tip %: ");
            decimal tipPercentage = decimal.Parse(Console.ReadLine());

            decimal tipAmount = billTotal * (tipPercentage / 100);

            decimal grandTotal = billTotal + tipAmount;

            Console.WriteLine($"Bill Total: {billTotal:C}");
            Console.WriteLine($"Tip Amount: {tipAmount:C}");
            Console.WriteLine($"Grand Total: {grandTotal:C}");
        }
    }

}
