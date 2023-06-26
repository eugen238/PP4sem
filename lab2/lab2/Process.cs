using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public static class Process
    {
        static public List<JobVacancy> mergeJobVacancies(params IStaff[] stuff)
        {
            List<JobVacancy> rc = new List<JobVacancy>();
            foreach (var staff in stuff)
            {
                rc.AddRange(staff.GetJobVacancies());
            }
            return rc;
        }
        static public string printJobVacancies(List<JobVacancy> list) 
        {
            string rc = "";
            foreach (var job in list)
            {
                rc += string.Format($" {job.ID} {job.Name} \n");
            }
            return rc;
        }
    }
}
