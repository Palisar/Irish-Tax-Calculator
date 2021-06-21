using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaculateTaxes { 

    class TaxCalculations
    {
        private decimal temp = 0.00m;
        private decimal taxableIncome;
        private decimal totalIncome;
        public decimal TotalIncome {
            get { return totalIncome; }
            set { totalIncome = value; }
        }
        private decimal expenses;
        public decimal Expenses
        {
            get { return expenses; }
            set 
            {
              expenses = value;
              
            }
        }
        public void SetTaxableIncome() { taxableIncome = totalIncome - expenses; }

        public void PRSIandUSC() 
        {
            decimal temptotal;
            decimal temp = 0.00m;
            Console.WriteLine("\nFor your PRSI you owe the following: ");
            Console.WriteLine($"${taxableIncome} @ 4% = ${(taxableIncome * 0.04M)}\n");
            
                if (taxableIncome >= 100000.00M)
                {
                    Console.WriteLine("Universal Social Charge\n");
                    temptotal = taxableIncome - 100000m;
                    temp = (12012M * 0.005M) + (8675M * 0.02M) + (49357m * 0.045m) + (29955.99m * 0.08m) + (temptotal * 0.11m);
                    
                    Console.WriteLine("$12012    @ 0.5% = $60.06");
                    Console.WriteLine("$8675  @   2% = $173.50");
                    Console.WriteLine("$49357    @ 4.5% = $2221.07");
                    Console.WriteLine("$29955.99 @   8% = $2396.4792");
                    Console.WriteLine($"${temptotal}    @  11% = ${temptotal * 0.11m}");
                    Console.WriteLine("\nYour total  USC owed is: " + temp);
                }
                else if (taxableIncome >= 70044m)
                {
                    Console.WriteLine("Universal Social Charge");
                    temptotal = taxableIncome - 70044m;
                    temp = (12012M * 0.005M) + (8675M * 0.02M) + (49357m * 0.045m) + (temptotal * 0.08m) ;
                    
                    Console.WriteLine("$12012    @ 0.5% = $60.06");
                    Console.WriteLine("$8675  @   2% = $173.50");
                    Console.WriteLine("$49357    @ 4.5% = $2221.07");
                    Console.WriteLine($"${temptotal}    @  8% = ${temptotal * 0.08m}");
                    Console.WriteLine("\nYour total  USC owed is: " + temp);
                }
                else if (taxableIncome >= 20687m)
                {
                    Console.WriteLine("Universal Social Charge");
                    temptotal = taxableIncome - 20687m;
                    temp = (12012M * 0.005M) + (8675m * 0.02M) + (temptotal * 0.045m);
                    
                    Console.WriteLine("$12012    @ 0.5% = $60.06");
                    Console.WriteLine("$8675  @   2% = $173.50");
                    Console.WriteLine($"${temptotal}    @ 4.5% = ${temptotal * 0.045m}");
                    Console.WriteLine("\nYour total  USC owed is: " + temp);
                }
                else if (taxableIncome >= 12012m)
                {
                    Console.WriteLine("Universal Social Charge");
                    temptotal = taxableIncome - 12012m;
                    temp = (12012m * 0.005M) + (temptotal * 0.045m); ;
                    
                    Console.WriteLine("$12012    @ 0.5% = $60.06");
                    Console.WriteLine($"${temptotal}    @   2% = ${temptotal * 0.02m}");
                    Console.WriteLine("\nYour total  USC owed is: " + temp);

                }
                else if (taxableIncome >= 0)
                {
                    Console.WriteLine("Universal Social Charge");
                    temptotal = taxableIncome;
                    temp = (temptotal* 0.005M); 
                    
                    Console.WriteLine($"${temptotal}    @   2% = ${temptotal * 0.02m}");
                    Console.WriteLine("\nYour total  USC owed is: " + temp);

                }
            
            

        }
        public void TotalDue()
        {
            if (taxableIncome >= 35300m)
            {
                decimal HighRate = (taxableIncome - 35300.00m);
                Console.WriteLine($"\nStandard Rate $35300 @ 20% = {35300.00m * 0.20m}");
                Console.WriteLine($"Higher   Rate ${HighRate} @ 40% = {HighRate * 0.40m}");
                Console.WriteLine($"Total  = ${(35300m * 0.20m) + (HighRate * 0.40m) + temp + (taxableIncome * 0.04m)}");
            }
            else if (totalIncome < 35300)
            {
                Console.WriteLine($"\nStandard Rate ${taxableIncome} @ 20% = {taxableIncome * 0.20m}");
                Console.WriteLine($"Total  = ${(taxableIncome * 0.20m)+ temp +(taxableIncome * 0.04m)}");
            }
        }
    }
}
