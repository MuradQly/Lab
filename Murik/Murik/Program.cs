using Murik.Entities;
using Murik.Service;

while (true)
{
    Console.Clear();
    Console.WriteLine("1)Muellim");
    Console.WriteLine("2)Telebe");
    Console.WriteLine("3)Cixis");
    if (int.TryParse(Console.ReadLine(), out int s))
    {
        if (s == 3)
        {
            Console.WriteLine("End");
        }
        else if (s == 1)
        {
            IService<Teacher> service = new TeacherService();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1.GetAll");
                Console.WriteLine("2.Delete");
                Console.WriteLine("3.Add");
                Console.WriteLine("4.Save");
                Console.WriteLine("5.Exit");
                int a = 0;
                while (!int.TryParse(Console.ReadLine(), out a)) ;
                if (a == 1)
                {
                    var teachers = service.GetAll();
                    Console.Clear();
                    foreach (var teacher in teachers)
                    {
                        Console.WriteLine($"ID: {teacher.Id}");
                        Console.WriteLine($"Name: {teacher.Name}");
                        Console.WriteLine("Surname: {0}", teacher.Surname);
                        Console.WriteLine($"Faculty:{teacher.Faculty}");
                        Console.WriteLine($"Salary:{teacher.Salary}");


                        Console.WriteLine($"Subject:{teacher.Subject}");

                    }
                    Console.ReadLine();




                }
                else if (a == 2)
                {
                    Console.Write("ID?:");
                    int id = 0;
                    while (!int.TryParse(Console.ReadLine(), out id)) ;
                    service.Delete(id);
                    Console.Clear();

                }
                else if (a == 3)
                {
                    Console.Write("Add:");
                    Console.WriteLine("Name");
                    string Name = Console.ReadLine();
                    Console.WriteLine("Surname:");
                    string Surname = Console.ReadLine();
                    Console.WriteLine("Faculty: ");
                    string fac = Console.ReadLine();
                    Console.WriteLine("Salary: ");
                    int sal = int.Parse(Console.ReadLine());
                    Console.WriteLine("Subject:");
                    string subject = Console.ReadLine();
                    Random ran = new();
                    int id = ran.Next(1, 1000);

                    Teacher teacher = new Teacher()
                    {
                        Id = id,
                        Faculty = fac,
                        Name = Name,
                        Salary = sal,
                        Subject = subject,
                        Surname = Surname
                    };
                    service.Add(teacher);

                }
                else if (a == 4)
                {
                    service.Save();
                }
                else if (a == 5) break;


            }
        }
        else if (s == 2)
        {
            IService<Student> service = new StudentService();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1.GetAll");
                Console.WriteLine("2.Delete");
                Console.WriteLine("3.Add");
                Console.WriteLine("4.Save");
                Console.WriteLine("5.Exit");
                int a = 0;
                while (!int.TryParse(Console.ReadLine(), out a)) ;
                if (a == 1)
                {
                    var students = service.GetAll();
                    Console.Clear();
                    foreach (var student in students)
                    {
                        Console.WriteLine($"ID: {student.Id}");
                        Console.WriteLine($"Name: {student.Name}");
                        Console.WriteLine("Surname: {0}", student.Surname);
                        Console.WriteLine("AVG: {0}", student.Avg);
                        Console.WriteLine("Speciality, {0}", student.Speciality);

                    }
                    Console.ReadLine();




                }
                else if (a == 2)
                {
                    Console.Write("ID?:");
                    int id = 0;
                    while (!int.TryParse(Console.ReadLine(), out id)) ;
                    service.Delete(id);
                    Console.Clear();

                }
                else if (a == 3)
                {
                    Console.Write("Add:");
                    Console.WriteLine("Name");
                    string Name = Console.ReadLine();
                    Console.WriteLine("Surname:");
                    string Surname = Console.ReadLine();
                    Console.WriteLine("Speciality ");
                    string speciality = Console.ReadLine();
                    Console.WriteLine("Avg:");
                    int Avg = int.Parse(Console.ReadLine());
                    Random ran = new();
                    int id = ran.Next(1, 1000);

                    Student student = new Student()
                    {
                        Id = id,
                        Name = Name,
                        Surname = Surname,
                        Avg = Avg,
                        Speciality = speciality
                    };
                    service.Add(student);

                }
                else if (a == 4)
                {
                    service.Save();
                }
                else if (a == 5) break;

            }
        }
    }
}
