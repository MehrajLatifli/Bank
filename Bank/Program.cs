using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Drawing;

namespace Bank
{
    class Program
    {


        static void Main(string[] args)
        {


            LogoofBank.Logo logo = new LogoofBank.Logo();



            Console.ForegroundColor = ConsoleColor.Yellow;
            logo.Logotype();
            Thread.Sleep(500);
            Console.Clear();


            Console.ForegroundColor = ConsoleColor.DarkYellow;
            logo.Logotype();
            Thread.Sleep(500);
            Console.Clear();


            Console.ForegroundColor = ConsoleColor.Yellow;
            logo.Logotype();
            Thread.Sleep(500);
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            logo.Logotype();
            Thread.Sleep(500);
            Console.Clear();



            #region Bank

          


                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"\n Enter decrease Percentage: ");

                string experience = Console.ReadLine();
                decimal decreasePercentage;

                if (decimal.TryParse(experience, out decreasePercentage)) ;

                else
                    Console.WriteLine(" Incorrect ",
                                      experience);

                decimal profit = 80_000_000M;

                decimal amount = 1000M;
                decimal calculatePercent = amount + ((1000 * decreasePercentage) / 100);
                int monthCount = 12;

                Bank bank = new Bank("Fox's family Bank", 1_000_000_000, profit, decreasePercentage);

                bank.BankShow();



                StaffofBank.CEO ceo = new StaffofBank.CEO
                {
                    ID = Guid.NewGuid(),
                    Name = "Artur",
                    SurName = "Fox",
                    Age = 38,

                    Position = "CEO",
                    Salary = 15000,
                };

                ceo.HumanShow();
                ceo.StaffShow();
                ceo.Control();
                ceo.Organize();
                ceo.MakeMeeting();


                Thread.Sleep(500);

                StaffofBank.Manager manager = new StaffofBank.Manager
                {
                    ID = Guid.NewGuid(),
                    Name = "Jane",
                    SurName = "Brown",
                    Age = 28,

                    Position = "Manager",
                    Salary = 1500 + (50 - amount / 50),
                };


                ceo.AddManager(ref manager);
                ceo.ShowManagers();

                Thread.Sleep(500);

                StaffofBank.Worker worker = new StaffofBank.Worker
                {
                    ID = Guid.NewGuid(),
                    Name = "Oktay",
                    SurName = "Ceferov",
                    Age = 25,

                    Position = "Operator",

                    Salary = manager.calculateSalaries() + ((250 / amount) * 250),
                };



                manager.AddWorker(ref worker);
                manager.ShowWorker();

                Thread.Sleep(500);

                Operation operation = new Operation()
                {
                    ID = Guid.NewGuid(),
                    OperationDate = DateTime.Now,


                };

                worker.AddOperations(ref operation);
                worker.WorkerOperationShow();


                Credit credit = new Credit()
                {
                    ID = Guid.NewGuid(),
                    CreditDate = DateTime.Now,
                    MonthCount = monthCount,
                    Amound = amount,
                    Percent = bank.DecreasePercentage,
                    CalculatePercent = calculatePercent,
                    Payment = calculatePercent / monthCount,

                };

                profit += credit.Payment * credit.MonthCount - credit.Amound;
                bank.Profit = profit;

                operation.AddCredits(ref credit);
                operation.OperationCreditShow();

                Client client = new Client
                {
                    ID = Guid.NewGuid(),
                    Name = "Oktay",
                    SurName = "Hesenov",
                    Age = 28,

                    Live_address = "Baku city, Narimanov r",
                    Work_address = "Baku city, Anem MMC",
                    Salary = 500,

                };

                credit.AddClients(ref client);
                credit.CreditClientShow();

                bank.BankShow();



                Thread.Sleep(500);



            #endregion Bank  
            Console.ReadKey();

        }
    }
}
