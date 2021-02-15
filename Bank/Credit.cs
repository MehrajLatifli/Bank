using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Credit : Bank
    {
        public Credit()
        {
            ID = Guid.NewGuid();
            CreditDate = DateTime.Now;
         
        }
        public Credit(string name, decimal budget, decimal profit,  decimal decreasePercentage, int monthCount, decimal amount) : base(name, budget, profit, decreasePercentage)
        {
       
            Amound = amount;
            
            MonthCount = monthCount;

            
        }

        public Guid ID { get; set; }
        public DateTime CreditDate { get; set; }
        public decimal Amound { get; set; }

        public decimal Percent { get; set; }
        public int MonthCount { get; set; }
        public decimal CalculatePercent { get; set; }
        public decimal Payment { get; set; }




        public string CreditDateTime()
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

        public Client[] Clients { get; set; }
        public int ClientsCount { get; set; } = default;
        public void AddClients(ref Client clients)
        {
            Client[] temp = new Client[++ClientsCount];
            if (Clients != null)
            {
                Clients.CopyTo(temp, 0);

            }
            temp[temp.Length - 1] = clients;
            Clients = temp;
        }

        public void CreditClientShow()
        {
            foreach (var item in Clients)
            {
                item.HumanShow();
                item.Client_DataShow();
                
            }
        }

        public override void CreditShow()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"\n ===== Credit ============================================================ ");
            Console.WriteLine($" \n ID: \t\t\t\t {ID} \n Date of Credit: \t\t {CreditDateTime()} ");
            Console.WriteLine($" \n Amound of Credit: \t\t {Amound} \n Percent of Credit: \t\t {Percent} \n MonthCount of Credit: \t\t {MonthCount} \n Calculate Percent of Credit: \t {CalculatePercent} \n Payment of Credit: \t\t {Payment} ");
            Console.WriteLine($"\n ========================================================================= \n");

        }


    
    

        
    }
}
