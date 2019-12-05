using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;


namespace Спортзал
{
    [Serializable]
    public class Coach
    {
        public string SurName;
        public string Name;
        public string SecondName;
        public string Adres;
        public int PhoneNumber;
        public double Salary;
        public DateTime Data;

        public string[] formats;
       
        public Coach()
        {
            
            this.SurName = "";
            this.Name = "";
            this.SecondName = "";
            this.Adres = "";
            this.PhoneNumber = new int();
            this.Salary = new double();
            this.Data = new DateTime(); 

        }

        public void SetFormats(string[] arr)
        {
            this.formats = arr;
        }

        public void Save(string fileName)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fso = File.OpenWrite(fileName);
            formatter.Serialize(fso, this);
            fso.Close();
        }

        public Coach Load(string fileName)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fsi = File.OpenRead(fileName);
            Coach co = (Coach)formatter.Deserialize(fsi);
            
            fsi.Close();
            return co;
        }

    }
}
