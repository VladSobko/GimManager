using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Спортзал
{
   abstract class Person
    {
        public string SurName;
        public string Name;
        public string SecondName;
        public string Adres;
        public int PhoneNumber;
        public DateTime Data;

        public Person()
        {
            this.SurName = "";
            this.Name = "";
            this.SecondName = "";
            this.Adres = "";
            this.PhoneNumber = new int();
            this.Data = new DateTime(); 
        }
       
    }
}
