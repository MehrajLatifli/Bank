using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    namespace StaffofBank
    {
        interface I_Staff
        {
            string Position { get; set; }
            decimal Salary { get; set; }

            void StaffShow();
            void Organize();

        }
    }
}
