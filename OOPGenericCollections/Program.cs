namespace OOPGenericCollections;

internal class Program
{
    static void Main(string[] args)
    {
        var employee1 = new Employee(101, "Sara", "Female", 40000);
        var employee2 = new Employee(102, "Tobias", "Male", 38000);
        var employee3 = new Employee(103, "Hanna", "Female", 41000);
        var employee4 = new Employee(104, "Ben", "Male", 42000);
        var employee5 = new Employee(105, "Anna", "Female", 49000);

        var employees = new Stack<Employee>();

        employees.Push(employee1);
        employees.Push(employee2);
        employees.Push(employee3);
        employees.Push(employee4);
        employees.Push(employee5);

        foreach (var employee in employees)
        {
            Console.WriteLine($"{employee.Id} - {employee.Name} - {employee.Gender} - {employee.Salary}");
            Console.WriteLine($"Items left on the stack = {employees.Count}");
        }

        Console.WriteLine("Retrieve Using Pop Method");
        Console.WriteLine("------------------------------");

        List<Employee> temp = new List<Employee>();
        while (employees.Count > 0)
        {
            var employee = employees.Pop();

            Console.WriteLine($"{employee.Id} - {employee.Name} - {employee.Gender} - {employee.Salary}");
            Console.WriteLine($"Items left on the stack = {employees.Count}");

            temp.Add(employee);
        }

        for (int i = temp.Count - 1; i >= 0; i--)
        {
            employees.Push(temp[i]);
        }

        Console.WriteLine("Retrieve Using Peek Method");
        Console.WriteLine("------------------------------");

        for (int i = 0; i < 2; i++)
        {
            var employee = employees.Peek();
            Console.WriteLine($"{employee.Id} - {employee.Name} - {employee.Gender} - {employee.Salary}");
            Console.WriteLine($"Items left on the stack = {employees.Count}");
        }

        Console.WriteLine("------------------------------");

        if (employees.Contains(employee3))
        {
            Console.WriteLine("Emp3 is in stack");
        }
        else
        {
            Console.WriteLine("Emp3 is not in stack");
        }
    }
}
