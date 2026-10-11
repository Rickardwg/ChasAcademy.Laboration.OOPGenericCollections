namespace OOPGenericCollections;

public class Employee(int id, string name, string gender, int salary)
{
    public int Id {  get; set; } = id;
    public string Name { get; set; } = name;
    public string Gender { get; set; } = gender;
    public int Salary { get; set; } = salary;
}
