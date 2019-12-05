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
    public class Visitor
    {
        public string SurName;
        public string Name;
        public string SecondName;
        public string Adres;
        public int PhoneNumber;
        public DateTime Data;
        public bool abonement;

        public string[] formats;

        public Visitor()
        {
            this.SurName = "";
            this.Name = "";
            this.SecondName = "";
            this.Adres = "";
            this.PhoneNumber = new int();
            this.Data = new DateTime();
            this.abonement = false; 
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

        public Visitor Load(string fileName)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fsi = File.OpenRead(fileName);
            Visitor vi = (Visitor)formatter.Deserialize(fsi);
            
            fsi.Close();
            return vi;
        }
    }
}
