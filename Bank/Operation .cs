using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Operation : Bank
    {
        public Operation()
        {
            ID = Guid.NewGuid();
            OperationDate = DateTime.Now;
        }
        public Operation(string name, decimal budget, decimal profit, decimal decreasePercentage): base(name, budget, profit, decreasePercentage)
        {
            ID = Guid.NewGuid();
            OperationDate = DateTime.Now;
        }
        public Guid ID { get; set; }
        public DateTime OperationDate { get; set; }

        public string Date()
        {
            DateTime operationDate = DateTime.Now;

            string year_ = operationDate.Year.ToString();
            string month_ = operationDate.Month.ToString();
            string day_ = operationDate.Day.ToString();
            string hour_ = operationDate.Hour.ToString();
            string minute_ = operationDate.Minute.ToString();
            string second_ = operationDate.Minute.ToString();
            string millisecond_ = operationDate.Millisecond.ToString();


            string time = $"{day_} / {month_} / {year_}    ||    {hour_} : {minute_} : {second_}: {millisecond_}";

            return time;

        }

        public string RandomProcess_name()
        {
            string[] numberforRandom = new string[] { "Consumer loans ", "Micro loans "};
            Random r1 = new Random();
            int n = numberforRandom.Length;
            StringBuilder randomProcess_name = new StringBuilder();



            while (n > 1)
            {
                n--;
                int k = r1.Next(n + 1);
                string value = numberforRandom[k];
                numberforRandom[k] = numberforRandom[n];
                numberforRandom[n] = value;
            }

            for (int i = 0; i < n; i++)
            {
                randomProcess_name.Append(numberforRandom[0]);
                
            }

            string str = randomProcess_name.ToString();

            return str;
        }

        public Credit[] Credits { get; set; }
        public int CreditsCount { get; set; } = default;
        public void AddCredits(ref Credit operations)
        {
            Credit[] temp = new Credit[++CreditsCount];
            if (Credits != null)
            {
                Credits.CopyTo(temp, 0);

            }
            temp[temp.Length - 1] = operations;
            Credits = temp;
        }

        public void OperationCreditShow()
        {
            foreach (var item in Credits)
            {
                item.CreditShow();
            }
        }

        public override void BankShow()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            base.BankShow();
        }
        public override void OperationShow()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"\n ===== Operation ========================================================= ");
            Console.WriteLine($" \n ID: \t\t\t\t {ID} \n Type of Operation: \t\t {RandomProcess_name()} \n Date of Operation: \t\t {Date()} ");
            Console.WriteLine($"\n ========================================================================= \n");

        }
    }
}
