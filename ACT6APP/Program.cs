using System;
using System.Collections.Generic;

public class Course
{
    public string title;
    public int units;

    public Course(string t, int u)
    {
        title = t;
        units = u;
    }
}

public class Student
{
    public string name;
    public Course enrolledCourse;

    public Student(string n, Course c)
    {
        name = n;
        enrolledCourse = c;
    }
}

public class Teacher
{
    public string name;
    protected string subject;

    public Teacher(string n, string s)
    {
        name = n;
        subject = s;
    }

    public void Teach()
    {
        Console.WriteLine(name + " teaches " + subject);
    }
}

public class Department
{
    public string name;
    public List<Teacher> teachers = new List<Teacher>();

    public Department(string n)
    {
        name = n;
    }
}

public class Room
{
    public string name;
    public Room(string n) { name = n; }
}

public class House
{
    public string address;
    private List<Room> rooms = new List<Room>();

    public House(string addr)
    {
        address = addr;
        rooms.Add(new Room("Living Room"));
        rooms.Add(new Room("Bedroom"));
    }

    public void ShowRooms()
    {
        foreach (var r in rooms)
            Console.WriteLine(" - " + r.name);
    }
}

class Program
{
    static void Main()
    {
        Course OOP = new Course("OOP", 3);
        Student Alem = new Student("Alem", OOP);
        Console.WriteLine(Alem.name + " enrolled in " + Alem.enrolledCourse.title);

        Teacher t1 = new Teacher("ENGR. Umbay", "OOP");
        Teacher t2 = new Teacher("Mr. Lee", "Physics");

        Department ComEng = new Department("Computer Engineering Department");
        ComEng.teachers.Add(t1);
        ComEng.teachers.Add(t2);

        Console.WriteLine(ComEng.name + " Teachers:");
        foreach (var t in ComEng.teachers) t.Teach();

        House myHouse = new House("Caloocan");
        Console.WriteLine(myHouse.address + " has rooms:");
        myHouse.ShowRooms();
    }
}
