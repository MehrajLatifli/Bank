using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Bank
{
    namespace StaffofBank
    {
        class Manager : Human, I_Staff
        {
            public string Position { get; set; }
            public decimal Salary { get; set; }

          
            public Manager(string name, string surname, int age, string position, float salary) : base(name, surname, age)
            {

            }

            public Manager()
            {
            }
            public Worker[] Workers { get; set; }
            public int WorkersCount { get; set; } = default;
            public void AddWorker(ref Worker workers)
            {
                Worker[] temp = new Worker[++WorkersCount];
                if (Workers != null)
                {
                    Workers.CopyTo(temp, 0);

                }
                temp[temp.Length - 1] = workers;
                Workers = temp;
            }

            public void ShowWorker()
            {
                foreach (var item in Workers)
                {
                    item.HumanShow();
                    item.StaffShow();
                }
            }
            public override void HumanShow()
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\n ===== Manager =========================================================== ");
                Console.WriteLine($" \n ID: \t\t\t\t {ID} \n Name: \t\t\t\t {Name} \n Surname: \t\t\t {SurName} \n Age: \t\t\t\t {Age} ");
            }

            public void StaffShow()
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($" \n Position: \t\t\t {Position} \n Salary: \t\t\t {Salary} manat");
                Console.WriteLine($"\n ========================================================================= \n");
            }

            public void Organize()
            {
                Console.Write($"\n Organize:  Create Novruz party\n");
            }

            public decimal calculateSalaries()
            {
         
                Console.Write($"\n Enter minimum wage: ");
               
                string minicach = Console.ReadLine();
                decimal number;

                if (decimal.TryParse(minicach, out number)) ;

                else
                    Console.WriteLine(" Incorrect ",
                                      minicach);

                Console.Write($"\n Enter work experience: ");

                string experience = Console.ReadLine();
                decimal number2;

                if (decimal.TryParse(experience, out number2)) ;

                else
                    Console.WriteLine(" Incorrect ",
                                      experience);

                decimal salary = 0;
                if (number2 <=1)
                {
                    salary = number * 1M;


                }

                if (number2 >1 && number2 <= 3)
                {
                 salary = number * 1.5M;

            
                }

                if (number2 > 3 && number2 <= 5)
                {
                     salary = number * 1.75M;

            
                }


                if (number2 > 5)
                {
                    salary = number * 2M;

                }

                if (number2 >5 && number2 <= 7)
                {
                     salary = number * 2.5M;

                }

                if (number2 > 7 && number2 <= 10)
                {
                    salary = number * 2.75M;

                }

                if (number2 > 10 )
                {
                    salary = number * 3M;

                }

                return salary;
            }

        }
    }
}