using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class JobVacancy
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public JobVacancy(int id, string name)
        {
            ID = id;
            Name = name;
        }
    }
}
