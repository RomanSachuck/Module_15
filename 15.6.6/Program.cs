namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var classes = new[]
            {
               new ClassRoom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new ClassRoom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new ClassRoom { Students = {"Bulat", "Alex", "Galina"}, }
           };
            var allStudents = GetAllStudents(classes);

            Console.WriteLine(string.Join(" ", allStudents));
        }

        static string[] GetAllStudents(ClassRoom[] classes)
        {
            return (from classRoom in classes
                    from student in classRoom.Students
                    select student).ToArray();
        }
    }
}
