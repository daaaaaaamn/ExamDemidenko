using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamDemidenko;


namespace ExamDemidenkoConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            //show
            Group ps = new Group("22 ИС", "1 Мок");
            Console.WriteLine("Show:");
            ps.Show();
            Student b1 = new Student("Иванов", 4);
            ps.Students.Add(b1);
            Student b2 = new Student("Сидоров", 5);
            ps.Students.Add(b2);
            Student b3 = new Student("Петров", 3);
            ps.Students.Add(b3);
            //showall
            Console.WriteLine();
            Console.WriteLine("ShowAll:");
            ps.ShowAll(ps);
            Console.WriteLine();
            List<Student> col = ps.newList(ps);
            col.Sort();
            //sort
            Console.WriteLine("Comparable по возростанию оценки:");
            foreach (Student lib in col)
            {
                Console.WriteLine(lib.ToString());
            }
            Console.ReadKey();
        }
    }
}
