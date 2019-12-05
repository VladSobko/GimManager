using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Спортзал.Classes
{
    [Serializable]
    public class DB
    {
        public List<Coach> teachers = new List<Coach>();
        public List<Visitor> sportsmens = new List<Visitor>();
        public List<Train> trainings = new List<Train>();    
    }
}
