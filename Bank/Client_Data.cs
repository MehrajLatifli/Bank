using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
   
        interface I_Client_Data
        {
        string Live_address { get; set; }
        string Work_address { get; set; }
        float Salary { get; set; }
        void Client_DataShow();

        }
   
}
