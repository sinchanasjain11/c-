namespace Student_Management_System
{
    class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>();
            int choice;

            do
            {
                Console.WriteLine("\n1.Add  2.Display  3.Search  4.Remove  5.Topper  6.Exit");
                Console.Write("Enter choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("ID: "); int id = int.Parse(Console.ReadLine());
                        Console.Write("Name: "); string name = Console.ReadLine();
                        Console.Write("Marks: "); int marks = int.Parse(Console.ReadLine());
                        students.Add(new Student { Id = id, Name = name, Marks = marks });
                        break;

                    case 2:
                        students.ForEach(s => Console.WriteLine(s));
                        break;

                    case 3:
                        Console.Write("Search ID: ");
                        int sid = int.Parse(Console.ReadLine());
                        var s1 = students.FirstOrDefault(s => s.Id == sid);
                        Console.WriteLine(s1 != null ? s1 : "Not found");
                        break;

                    case 4:
                        Console.Write("Remove ID: ");
                        int rid = int.Parse(Console.ReadLine());
                        students.RemoveAll(s => s.Id == rid);
                        Console.WriteLine("Removed (if existed).");
                        break;

                    case 5:
                        if (students.Count > 0)
                            Console.WriteLine("Topper: " + students.OrderByDescending(s => s.Marks).First());
                        else
                            Console.WriteLine("No students.");
                        break;
                }
            } while (choice != 6);
        }
    }
}