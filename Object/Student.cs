using System.Drawing;

internal class Student
{
    public string Name;
    public string Surname;
    public string Group;
    public double Point;
    public bool isGraduated;
    

    public Student()
    {
        
    }

    public Student(string name, string surname, string group, double point, bool isgraduated)
    {
        Name = name;
        Surname = surname;
        Group = group;
        Point = point;
        isGraduated = isgraduated;

    }

    public void GetFullName()
    {
        Console.WriteLine($"{Name} {Surname}");
    }

    public void GetFullInfo()
    {
        if (isGraduated )
        {
            Console.WriteLine($"{Name} {Surname} {Group} {Point} - Bu telebe mezun olub.");

        }
        else
        {
            Console.WriteLine($"{Name} {Surname} {Group} {Point} - Bu telebe mezun olmayıb.");

        }
    }

    public void NextExam()
    {
        if (Point>80)
        {
            Console.WriteLine("Bu telebe novbeti imtahana gire biler.");
        }
        else
        {
            Console.WriteLine("Bu telebe novbeti imtahana gire bilmez");
        }
    }

   
}

