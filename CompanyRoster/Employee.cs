public class Employee
{
    public string name;
    public double salary;
    public string position;
    public string department;
    public string email = "n/a";
    public int age = -1;

    //public string Name { get; set; }
    //public double Salary { get; set; }
    //public string Position { get; set; }
    //public string Department { get; set; }
    //public string Email { get; set; }
    //public int Age { get; set; }

    public Employee(string name, double salary, string position, string department)
    {
        this.name = name;
        this.salary = salary;
        this.position = position;
        this.department = department;
    }

    public Employee(string name, double salary, string position, string department, int age)
    {
        this.name = name;
        this.salary = salary;
        this.position = position;
        this.department = department;
        this.age = age;
    }

    public Employee(string name, double salary, string position, string department, string email)
    {
        this.name = name;
        this.salary = salary;
        this.position = position;
        this.department = department;
        this.email = email;
    }

    public Employee(string name, double salary, string position, string department, string email, int age)
    {
        this.name = name;
        this.salary = salary;
        this.position = position;
        this.department = department;
        this.email = email;
        this.age = age;
    }
}

