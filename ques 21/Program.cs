namespace ques_21
{
   

public abstract class Employee
    {
        // Properties
        public string Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; protected set; }

        // Method to validate the employee ID
        public bool ValidateEmployeeId()
        {
            if (Id.Length != 5)
                return false;

            if (Id.Substring(0, 2) != "EM")
                return false;

            if (!int.TryParse(Id.Substring(2, 3), out _))
                return false;

            return true;
        }

        // Abstract method for salary calculation
        public abstract Employee SalaryCalculation();
    }

    public class Permanent : Employee
    {
        // Property for basic pay
        public double BasicPay { get; set; }

        // Override the SalaryCalculation method
        public override Employee SalaryCalculation()
        {
            double da = 0.5 * BasicPay; // DA = 50% of Basic Pay
            double hra = 0.3 * BasicPay; // HRA = 30% of Basic Pay
            Salary = BasicPay + da + hra; // Calculate total salary
            return this; // Return the Employee object
        }
    }

    public class Temporary : Employee
    {
        // Properties for hours worked and hourly wages
        public int HrsWorked { get; set; }
        public int HrlyWages { get; set; }

        // Override the SalaryCalculation method
        public override Employee SalaryCalculation()
        {
            Salary = HrsWorked * HrlyWages; // Calculate salary based on hours worked
            return this; // Return the Employee object
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1. Permanent");
            Console.WriteLine("2. Temporary");
            Console.Write("Choose the employee type: ");
            int choice = int.Parse(Console.ReadLine());

            Employee employee;

            // Create employee based on user choice
            if (choice == 1)
            {
                employee = new Permanent();
            }
            else if (choice == 2)
            {
                employee = new Temporary();
            }
            else
            {
                Console.WriteLine("Invalid employee type.");
                return; // Exit if invalid option is selected
            }

            // Get common employee details
            Console.Write("Enter the employee id: ");
            employee.Id = Console.ReadLine();
            Console.Write("Enter the name: ");
            employee.Name = Console.ReadLine();

            // Validate employee ID
            if (!employee.ValidateEmployeeId())
            {
                Console.WriteLine("Invalid id");
                return; // Exit if ID is invalid
            }

            // Get specific details based on employee type
            if (employee is Permanent permanentEmployee)
            {
                Console.Write("Enter basic pay: ");
                permanentEmployee.BasicPay = double.Parse(Console.ReadLine());
                permanentEmployee.SalaryCalculation(); // Calculate salary
            }
            else if (employee is Temporary temporaryEmployee)
            {
                Console.Write("Enter hours worked: ");
                temporaryEmployee.HrsWorked = int.Parse(Console.ReadLine());
                Console.Write("Enter hourly wages: ");
                temporaryEmployee.HrlyWages = int.Parse(Console.ReadLine());
                temporaryEmployee.SalaryCalculation(); // Calculate salary
            }

            // Display the employee details and salary
            Console.WriteLine($"Employee id : {employee.Id}, Name : {employee.Name}, Salary : {employee.Salary}");
        }
    }

}

