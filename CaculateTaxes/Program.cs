using System;

namespace CaculateTaxes
{
    class Program
    {
        static void Main(string[] args)
        {
            TaxCalculations taxes = new TaxCalculations();
            Console.Write("Please enter your total income: ");
            taxes.TotalIncome = Convert.ToDecimal(Console.ReadLine());
            Console.Write("\nPlease enter your expenses cost: ");
            taxes.Expenses = Convert.ToDecimal(Console.ReadLine());
            taxes.SetTaxableIncome();
            taxes.PRSIandUSC();
            taxes.TotalDue();

        }
    }
}
