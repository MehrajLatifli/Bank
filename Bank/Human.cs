using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
   
        abstract class Human
        {
            public Human(string name, string surName, int age)
            {

                Name = name;
                SurName = surName;
                Age = age;
            }

            public Human() 
            {
                ID = Guid.NewGuid();
            }
            public Guid ID { get; set; }
            public string Name { get; set; }
            public string SurName { get; set; }
            public int Age { get; set; }
            public abstract void HumanShow();
            

        }
    
}
