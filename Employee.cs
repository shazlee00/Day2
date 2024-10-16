namespace SampleNamespace;
public struct HiringDate
{
    public int Day { get; set; }
    public int Month { get; set; }
    public int Year { get; set; }

    public HiringDate(int day, int month, int year)
    {
        Day = day;
        Month = month;
        Year = year;
    }

 
    public override string ToString()
    {
        return $"{Day:00}/{Month:00}/{Year}";
    }

}

public class Employee 
{
    public int ID { get; set; }
    public double Salary { get; set; }
    public HiringDate HireDate { get; set; }
    public string Gender { get; set; }

    
    public Employee(){

    }

    public Employee(int id, double salary, HiringDate hireDate, string gender)
    {
        ID = id;
        Salary = salary;
        HireDate = hireDate;
        Gender = gender;
    }

    
    public override string ToString()
    {
        return $"ID: {ID}, Salary: {Salary}, Hire Date: {HireDate}, Gender: {Gender}";
    }

}