using System;
using System.Collections.Generic;
using System.Linq;
class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Gpa { get; set; }
    public string Faculty { get; set; }
    public static int Counter = 1;
    public Student(string name, double gpa, string faculty)
    {
        Id = Counter++;
        Name = name;
        Gpa = gpa;
        Faculty = faculty;
    }
    public override string ToString() => $"[ID: {Id}] {Name} - GPA: {Gpa}, Faculty: {Faculty}";
}

class Registry
{
    private List<Student> students = new List<Student>();
    public void Add(Student s) => students.Add(s);
    public Student FindById(int id) => students.FirstOrDefault(x => x.Id == id);
    public List<Student> FindByName(string name) => students.Where(x => x.Name.ToLower().Contains(name.ToLower())).ToList();
    public List<Student> GetTopStudents(int n) => students.OrderByDescending(x => x.Gpa).Take(n).ToList();
    public void PrintAll() => students.ForEach(Console.WriteLine);
}
class Program
{
    static void Main()
    {
        Registry reg = new Registry();
        reg.Add(new Student("Asylai", 4.0, "IT"));
        reg.Add(new Student("Moldir", 3.2, "IT"));
        reg.Add(new Student("Aruzhan", 3.5, "IT"));
        reg.Add(new Student("Aiken", 2.8, "IT"));
        reg.Add(new Student("Asel", 3.1, "IT"));
        reg.Add(new Student("Inabat", 2.9, "IT"));
        reg.Add(new Student("Bauyrzhan", 3.7, "Engineering"));
        reg.Add(new Student("Alisher", 3.9, "Economics"));

        while (true)
        {
            Console.WriteLine("\n1. Add | 2. ID | 3. Name | 4. Top N | 5. All | 6. Exit");
            string c = Console.ReadLine();
            if (c == "1")
            {
                try
                {
                    Console.Write("Name: "); string n = Console.ReadLine();
                    Console.Write("GPA: "); double g = double.Parse(Console.ReadLine());
                    Console.Write("Faculty: "); string f = Console.ReadLine();
                    reg.Add(new Student(n, g, f));
                }
                catch { Console.WriteLine("Input error!"); }
            }
            else if (c == "2")
            {
                if (int.TryParse(Console.ReadLine(), out int id))
                {
                    var s = reg.FindById(id);
                    Console.WriteLine(s != null ? s.ToString() : "Not found");
                }
            }
            else if (c == "3")
            {
                string name = Console.ReadLine();
                var list = reg.FindByName(name);
                list.ForEach(Console.WriteLine);
            }
            else if (c == "4")
            {
                if (int.TryParse(Console.ReadLine(), out int n))
                    reg.GetTopStudents(n).ForEach(Console.WriteLine);
            }
            else if (c == "5") reg.PrintAll();
            else if (c == "6") break;
        }
    }
}
