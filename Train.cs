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
    public class Train
    {
        public DateTime Data;
        public DateTime Time;
        public Coach CoachName;
        public Visitor VisitorName;
        public bool payment;

        //public double Y
        //{
        //    get { return this.y; }
        //    set { this.y = value; }
        //}
        public string[] formats;

        public Train()
        {
            
            this.Data = new DateTime();
            this.Time = new DateTime();
            this.CoachName = new Coach();
            this.VisitorName = new Visitor(); 

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

        public Train Load(string fileName)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fsi = File.OpenRead(fileName);
            Train t = (Train)formatter.Deserialize(fsi);
            
            fsi.Close();
            return t;
        }
    }
}
