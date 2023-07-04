using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDemidenko
{
    //КлассГруппы
    public class Group
    {
        public string Name { get; set; }
        public string College { get; set; }
        public List<Student> Students = new List<Student>();
        public Group(string name, string college)
        {
            Name = name;
            College = college;

        }
        public void Show()
        {
            Console.WriteLine($"Студенческая группа: Название группы = {Name}," +
                $" Название колледжа = {College}");
        }
        public List<Student> newList(Group user)
        {
            List<Student> col = new List<Student>();
            foreach (Student b in user.Students)
            {
                Student book1 = new Student(b.Name, b.Ocenka);
                col.Add(book1);
            }
            return col;
        }
        public void ShowAll(Group ps)
        {
            ps.Show();
            foreach (Student b in ps.Students)
            {
                b.Show();
            }
        }

    }
    //КлассСтудент
    public class Student : IComparable<Student>
    {
        public string Name { get; set; }
        public int Ocenka { get; set; }
        public Student(string name, int ocenka)
        {
            Name = name;
            Ocenka = ocenka;

        }
        public override string ToString()
        {
            string s = $"Данные о студенте: \n" +
                       $"- Имя: {Name} \n" +
                       $"- Оценка: {Ocenka} \n";
            return s;
        }
        public int CompareTo(Student other)
        {
            if (this.Ocenka < other.Ocenka)
            {
                return -1;
            }
            else if (this.Ocenka > other.Ocenka)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public void Show()
        {
            Console.WriteLine($"Данные о студенте: Имя: {Name}, Оценка: {Ocenka}");
        }
    }
}
