

using System.Security.Cryptography;

class Student
{   

    public string name;
    public int age;
    public int score;


    public Student(string name,int age,int score)
    {
        this.name = name;
        this.age = age;
        this.score = score;
    }


    public override string ToString()
    {
        return $"Student name {this.name} and Student Grade {getGrade(this.score)} and age {this.age} ";
    }

    public char getGrade(int score)
    {
        if(score >= 90)
        {
            return 'A';
        }
        else if(score >= 80)
        {
            return 'B';
        }
        else if(score >= 60)
        {
            return 'C';
        }
        else
        {
            return 'F';
        }
    }

}


public class Program
{

    static List<Student> studentlist = new List<Student>{};

    public static void populate()
    {
        studentlist.Add(new Student("arvind",21,90));
        studentlist.Add(new Student("Vikram",20,80));
        studentlist.Add(new Student("harry",21,60));
    }

    public static void Main(String [] args)
    {

        Console.WriteLine("Enter the grade and students equal and above the grade will displayed");
        Char grade = Console.ReadLine()[0];
        int score = 0;

        if(grade  == 'A')
            score = 90;
        else if(grade == 'B')
            score = 80;
        else if(grade == 'C')
             score = 60;
        else if(grade == 'F')
            score = 0;

        populate();   
        IEnumerable<Student> queryList = from student in studentlist
                                   where student.score >= score
                                   orderby student.age
                                   select student;
                    

        
        Console.WriteLine($"{string.Join(", ",queryList)}");

    }
}