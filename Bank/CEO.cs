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
        class CEO : Human, I_Staff
        {
      

            public string Position { get; set; }
            public decimal Salary { get; set; }


            public CEO(string name, string surname, int age, string position, float salary) : base(name, surname, age)
            {

            }

            public CEO()
            {
            }

            public string CEOControlDate()
            {
                DateTime controlDate = new DateTime(01, 02, 01, 10, 00, 00);
      

                string year_ = controlDate.Year.ToString();
                string month_ = controlDate.Month.ToString();
                string day_ = controlDate.Day.ToString();
                string hour_ = controlDate.Hour.ToString();
                string minute_ = controlDate.Minute.ToString();
                string second_ = controlDate.Minute.ToString();
                string millisecond_ = controlDate.Millisecond.ToString();


                string time = $" {hour_} : {minute_} ";

                return time;

            }

            public string CEOMeetingDate()
            {
                DateTime controlDate = new DateTime(01, 02, 01, 18, 00, 00);


                string year_ = controlDate.Year.ToString();
                string month_ = controlDate.Month.ToString();
                string day_ = controlDate.Day.ToString();
                string hour_ = controlDate.Hour.ToString();
                string minute_ = controlDate.Minute.ToString();
                string second_ = controlDate.Minute.ToString();
                string millisecond_ = controlDate.Millisecond.ToString();


                string time = $" {hour_} : {minute_} ";

                return time;

            }

            public override void HumanShow()
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n ===== CEO =============================================================== ");
                Console.WriteLine($" \n ID: \t\t\t\t {ID} \n Name: \t\t\t\t {Name} \n Surname: \t\t\t {SurName} \n Age: \t\t\t\t {Age} ");
            }

            public void StaffShow()
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($" \n Position: \t\t\t {Position} \n Salary: \t\t\t {Salary} manat");
                Console.WriteLine($"\n ========================================================================= \n");
            }

            public void Control()
            {
                Console.WriteLine($"\n Control time:  {CEOControlDate()}\n");
            }

            public void Organize()
            {
                Console.WriteLine($"\n Organize:  Prepare bonus chash for staff at Novruz party\n");
            }

            public void MakeMeeting()
            {
                Console.WriteLine($"\n Meeting time:{CEOMeetingDate()}\n");
            }

            public Manager[] Managers { get; set; }
            public int ManagersCount { get; set; } = default;
            public void AddManager(ref Manager managers)
            {
                Manager[] temp = new Manager[++ManagersCount];
                if (Managers != null)
                {
                    Managers.CopyTo(temp, 0);

                }
                temp[temp.Length - 1] = managers;
                Managers = temp;
            }

            public void ShowManagers()
            {
                foreach (var item in Managers)
                {
                    item.HumanShow();
                    item.StaffShow();
                }
            }
        }
    }
}