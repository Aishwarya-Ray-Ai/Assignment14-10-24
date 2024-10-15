namespace ques_17
{
      

public class Book
    {
        // Private fields for book details
        private string title;
        private string author;
        private int numPages;
        private DateTime dueDate;
        private DateTime returnedDate;

        // Default constructor
        public Book()
        {
            title = string.Empty;
            author = string.Empty;
            numPages = 0;
            dueDate = DateTime.Now;
            returnedDate = DateTime.Now;
        }

        // Parameterized constructor
        public Book(string title, string author, int numPages, DateTime dueDate, DateTime returnedDate)
        {
            this.title = title;
            this.author = author;
            this.numPages = numPages;
            this.dueDate = dueDate;
            this.returnedDate = returnedDate;
        }

        // Method to calculate average pages read per day
        public double AveragePagesReadPerDay(int daysToRead)
        {
            return (double)numPages / daysToRead;
        }

        // Method to calculate late fee
        public double CalculateLateFee(double dailyLateFeeRate)
        {
            int numberOfDaysLate = (returnedDate - dueDate).Days;
            if (numberOfDaysLate > 0)
            {
                return numberOfDaysLate * dailyLateFeeRate;
            }
            return 0; // No late fee if returned on time
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // Get book details from the user
            Console.WriteLine("Enter the title:");
            string title = Console.ReadLine();

            Console.WriteLine("Enter the author:");
            string author = Console.ReadLine();

            Console.WriteLine("Enter the number of pages:");
            int numPages = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the due date (MM/DD/YYYY):");
            DateTime dueDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter the return date (MM/DD/YYYY):");
            DateTime returnDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter the days to read:");
            int daysToRead = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the daily late fee rate:");
            double dailyLateFeeRate = double.Parse(Console.ReadLine());

            // Create a new Book object using the parameterized constructor
            Book book = new Book(title, author, numPages, dueDate, returnDate);

            // Calculate and display the average pages read per day
            double averagePages = book.AveragePagesReadPerDay(daysToRead);
            Console.WriteLine($"Average Pages Read Per Day : {averagePages}");

            // Calculate and display the late fee
            double lateFee = book.CalculateLateFee(dailyLateFeeRate);
            Console.WriteLine($"Late Fee : {lateFee}");
        }
    }

}

