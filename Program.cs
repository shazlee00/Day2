namespace LearnitLab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter The List Size:");
            int size = int.Parse(Console.ReadLine());

            var employees = new Employee[size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"\nEnter details for Employee {i + 1}:");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());

                Console.Write("HireDate(DD,MM,YYYY):");

                string date = Console.ReadLine();

                var dateArr = date.Split(',');
                var hireDate = new HiringDate(int.Parse(dateArr[0]), int.Parse(dateArr[1]), int.Parse(dateArr[2]));

                Console.Write("Gender: ");
                string gender = Console.ReadLine();

                employees[i] = new Employee(id, salary, hireDate, gender);

                Console.WriteLine(employees[i].ToString());
            }

            Console.WriteLine("------------------------------------------------");


            //var employees = new Employee[5]
            //{
            //    new Employee(1,1000,new HiringDate(1,1,2000),"Male"),
            //    new Employee(2,2000,new HiringDate(2,2,2021),"Female"),
            //    new Employee(3,3000,new HiringDate(3,3,2023),"Male"),
            //    new Employee(4,4000,new HiringDate(4,4,2024),"Female"),
            //    new Employee(5,5000,new HiringDate(5,5,2022),"Male"),
            //};
            
            //var size = employees.Length;


           

            for (int i = 0; i < size - 1; i++)
            {
                var oldestIndex = i;

                for (int j = i + 1; j < size; j++)
                {

                    if (EmpComp(employees[oldestIndex], employees[j]) >= 0)
                    {
                        oldestIndex = j;
                    }
                }

                if (oldestIndex != i)
                {
                    var temp = employees[i];
                    employees[i] = employees[oldestIndex];
                    employees[oldestIndex] = temp;
                }
            }


            foreach (var emps in employees)
            {
                Console.WriteLine(emps.ToString());
            }
        }


       static int EmpComp(Employee emp1, Employee emp2)
        {

            if (emp1.HireDate.Year == emp2.HireDate.Year)
            {
                if (emp1.HireDate.Month == emp2.HireDate.Month)
                    return emp1.HireDate.Day - emp2.HireDate.Day;
                else
                    return emp1.HireDate.Month - emp2.HireDate.Month;
            }
            return emp1.HireDate.Year - emp2.HireDate.Year;
        }
    }
}
