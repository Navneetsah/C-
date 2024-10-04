using System;
public class StringExample
{
    public static void Main(string[] args)
    {
        string str1 = "Hello";
        string str2 = (String)str1.Clone();
        Console.WriteLine(str1);
        Console.WriteLine(str2);
    }
}


using System;
public class StringDemo
{
    public static void Main(string[] args)
    {
        string str1 = "Hello";
        char[] ch = {'c','s','h','a','r','p'};
        String str2 = new String(ch);
        Console.WriteLine(str1);
        Console.WriteLine(str2);
    }
}



using System;
public class StringExample
{
    public static void Main(string[] args)
    {
        string str1 = "Hello";
        string str2 = "Hello";
        string str3 = "csharp";
        string str4 = "Mello";
        Console.WriteLine(string.Compare(str1,str2));
        Console.WriteLine(string.Compare(str2,str3));
        Console.WriteLine(string.Compare(str3,str4));
    }
}




using System;
public class Student
{
    int id;//data member/field
    String name;//data member/field
    public static void Main(string[] args)
    {
        Student s1 = new Student();//creating an object of student
        s1.id = 9003;
        s1.name = "Deva Beta";
        Console.Write(s1.id);
        Console.Write(s1.name);
    }
}





using System;
class Employee
{
    public Employee()
    {
        Console.WriteLine("Default Constructor Invoked");
    }
}
class TestEmployee
{
    public static void Main(string[] args)
    {
        Employee e1 = new Employee();
        Employee e2 = new Employee();
    }
}





using System;
public class Employee
{
    public int id;
    public String name;
    public float salary;
    public Employee(int i, String n, float s)
    {
        id = i;
        name = n;
        salary = s;
    }
    public void display()
    {
        Console.WriteLine(id+""+name+""+salary);
    }
}
class TestEmployee
{
    public static void Main(string[] args)
    {
        Employee e1 = new Employee(9003,"Deva Beta",150);
        Employee e2 = new Employee(9005,"Ankit",250);
        e1.display();
        e2.display();
    }
}






using System;
public class Employee
{
    public Employee()
    {
        Console.WriteLine("Constructor Invoked");
    }
    ~Employee()
    {
        Console.WriteLine("Destructor Invoked");
    }
}
class TestEmployee
{
    public static void Main(string[] args)
    {
        Employee e1 = new Employee();
        Employee e2 = new Employee();
    }
}
