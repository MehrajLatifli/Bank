using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Client : Human, I_Client_Data
    {
        public string Live_address { get; set; }
        public string Work_address { get; set; }
        public float Salary { get; set; }

        public override void HumanShow()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"\n ===== Client ============================================================ ");
            Console.WriteLine($" \n ID: \t\t\t\t {ID} \n Name: \t\t\t\t {Name} \n Surname: \t\t\t {SurName} \n Age: \t\t\t\t {Age} ");
        }

        public void Client_DataShow()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($" \n Live address: \t\t\t {Live_address} \n Work address: \t\t\t {Work_address} \n Salary: \t\t\t {Salary} manat");
            Console.WriteLine($"\n ========================================================================= \n");
        }
    }
}
