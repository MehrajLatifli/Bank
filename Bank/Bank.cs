using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Bank
    {
        public Bank(string name, decimal budget, decimal profit, decimal decreasePercentage)
        {
            Name = name;
            Budget = budget;
            Profit = profit;
            DecreasePercentage = decreasePercentage;
        }

        public Bank() { }

        public string Name { get; set; }
        public decimal Budget { get; set; }
        public decimal Profit { get; set; }
        public decimal DecreasePercentage { get; set; }

        public virtual void BankShow()
        {   
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine($"\n ===== Bank ============================================================== ");
            Console.WriteLine($" \n Name of Bank: \t\t\t {Name} \n Budget of Bank: \t\t {Budget} \n Profit of Bank: \t\t {Profit} \n Decrease Percentage of Bank: \t {DecreasePercentage} ");
            Console.WriteLine($"\n ========================================================================= \n");
        }

        public virtual void OperationShow()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n No activation for operation ");
        }

        public virtual void CreditShow()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n No activation for credit ");
        }

        public void ProfitShow()
        {
            Console.WriteLine($"\n Bank profit: {Profit} ");
        }
       
    }
}
