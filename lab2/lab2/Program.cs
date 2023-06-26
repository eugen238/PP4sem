using System.Diagnostics;

namespace lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            University bstu = new University("Белорусский государственный технологический унивеситет","БГТУ","г. Минск, Свердлова, 13A");

            Faculty fit = new Faculty("Информационных технологий", "ИТ","г. Минск, Свердлова, 13А, 101-4"); 
            Faculty fie = new Faculty("Инженерно-экономический", "ИЭ", "г. Минск, Свердлова, 13А, 304-4");
            Faculty flh = new Faculty("Лесохозяйственный", "ЛХ", "г. Минск, Свердлова, 13А, 210-1");

            bstu.addFaculty(fit);
            bstu.addFaculty(fie);
            bstu.addFaculty(flh);

            Organization org_bstu = bstu;
            Organization org_fit = fit;
            Organization org = new Organization("Стадион Динамо","Динамо", "г. Минск, ул. Ульяновская 8");

            IStaff x = new Faculty("Принттехнологий и медиакоммуникаций", "ПМ", "г. Минск, ул. Свердлова, 13А, 150-4");

           List<JobVacancy> list = Process.mergeJobVacancies(bstu,fit,fie,flh,org);
            Console.WriteLine(Process.printJobVacancies(list));
            Console.WriteLine("--------------------------------------------------------------------------------------------");

            org_bstu.PrintInfo();
            org_fit.PrintInfo();
            org.PrintInfo();
            Console.WriteLine(((IStaff)org).printJobVacancies());
            Console.WriteLine(((IStaff)bstu).printJobVacancies());
            Console.WriteLine(((IStaff)fit).printJobVacancies());
            Console.WriteLine(((IStaff)fie).printJobVacancies());
            Console.WriteLine(((IStaff)org_fit).printJobVacancies());
            Console.WriteLine(x.printJobVacancies());
        }
    }
}