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
        class Worker : Human, I_Staff
        {
            public string Position { get ; set ; }
            public decimal Salary { get; set; }
           



            DateTime d1 = new DateTime(01, 02, 01, 10, 00, 00);
            DateTime d2 = new DateTime(01, 02, 01, 18, 00, 00);
            public Worker(string name, string surname, int age, string position, float salary) : base(name,surname, age)
            {
                

            }

            public Worker()
            {
            }

            public override void HumanShow()
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"\n ===== Worker ============================================================ ");
                Console.WriteLine($" \n ID: \t\t\t\t {ID} \n Name: \t\t\t\t {Name} \n Surname: \t\t\t {SurName} \n Age: \t\t\t\t {Age} ");
            }

            public void StaffShow()
            {
              
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($" \n Work Time: \t\t\t {d1.Hour} : {d1.Minute} - {d2.Hour} : {d2.Minute}");
                Console.WriteLine($" \n Position: \t\t\t {Position} \n Salary: \t\t\t {Salary} manat");
                Console.WriteLine($"\n ========================================================================= \n");
            }


            public Operation[] Operations { get; set; }
            public int OperationsCount { get; set; } = default;
            public void AddOperations(ref Operation operations)
            {
                Operation[] temp = new Operation[++OperationsCount];
                if (Operations != null)
                {
                    Operations.CopyTo(temp, 0);

                }
                temp[temp.Length - 1] = operations;
                Operations = temp;
            }

            public void WorkerOperationShow()
            {
                foreach (var item in Operations)
                {
                    item.OperationShow();
                }
            }

            public void Organize()
            {
                Console.WriteLine($" ");

            }
        }
    }
}
