namespace ques_2
{
    internal class Program
    {

        public class Movie
        {
            // Static variable
            public static string name;

            // Instance variables
            public int ticketId;
            public string seatNumber;

            // Method to set and return movie details
            public Movie ReturnMovieDetails(string movieName, int ticketId, string seatNumber)
            {
                // Local variables
                Movie movie = new Movie();  // Reference variable
                Movie.name = movieName;     // Assign to static variable
                movie.ticketId = ticketId;  // Assign to instance variable
                movie.seatNumber = seatNumber; // Assign to instance variable

                return movie; // Return the movie object
            }
        }

        public class Program
        {
            public static void Main(string[] args)
            {
                // Get input from the user
                Console.WriteLine("Enter the movie name");
                string movieName = Console.ReadLine();

                Console.WriteLine("Enter the ticket id");
                int ticketId = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the seat number");
                string seatNumber = Console.ReadLine();

                // Create an instance of Movie and call the method to set details
                Movie movie = new Movie();
                Movie movieDetails = movie.ReturnMovieDetails(movieName, ticketId, seatNumber);

                // Display the result
                Console.WriteLine($"Movie name : {Movie.name}");
                Console.WriteLine($"Ticket id : {movieDetails.ticketId}");
                Console.WriteLine($"Seat number : {movieDetails.seatNumber}");
            }
        }

    }

