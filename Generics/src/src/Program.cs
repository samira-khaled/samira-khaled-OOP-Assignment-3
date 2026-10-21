namespace src
{
    public class Program
    {
        static void Main(string[] args)
        {
            StudentStore store = new StudentStore();

            store.Add(new Student(1, "Ali"));
            store.Add(new Student(2, "Mona"));
            store.Add(new Student(3, "Omar"));

            // GetById
            Student student = store.GetById(2);
            Console.WriteLine(student?.Name ?? "Not Found");

            // GetAll
            foreach (var s in store.GetAll())
            {
                Console.WriteLine($"{s.Id} - {s.Name}");
            }

            // Remove
            store.Remove(2);

            Console.WriteLine(store.GetById(2) == null
                ? "Student removed"
                : "Student still exists");
        }
    }
}
