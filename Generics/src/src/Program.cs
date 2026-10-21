namespace src
{
    public class Program
    {
        static void Main(string[] args)
        {
            Store<Student> studentStore = new Store<Student>();
            studentStore.Add(new Student(1, "Ali"));
            studentStore.Add(new Student(2, "Mona"));

            Store<Course> courseStore = new Store<Course>();
            courseStore.Add(new Course(1, "C#", 500));
            courseStore.Add(new Course(2, "SQL", 400));

            Console.WriteLine(studentStore.GetById(2)?.Name);
            Console.WriteLine(courseStore.GetById(1)?.Title);
        }
    }
}
