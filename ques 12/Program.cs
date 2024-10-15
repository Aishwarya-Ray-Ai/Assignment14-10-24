namespace ques_12
{
    internal class Program
    {
       
        // Method to find which student got the maximum points
        public static string FindWhoGotMaximumPoints(int[][] points)
        {
            int maxPoints = 0;
            int studentIndex = -1;

            // Calculate total points for each student
            for (int i = 0; i < points.Length; i++)
            {
                int totalPoints = 0;

                // Sum up points for student 'i'
                for (int j = 0; j < points[i].Length; j++)
                {
                    totalPoints += points[i][j];
                }

                // Check if this student has the maximum points so far
                if (totalPoints > maxPoints)
                {
                    maxPoints = totalPoints;
                    studentIndex = i;
                }
            }

            // Return the student with the maximum points
            return $"Student {studentIndex + 1} got maximum points.";
        }

        public static void Main(string[] args)
        {
            // Get the number of students
            Console.WriteLine("Enter the number of students");
            int numStudents = int.Parse(Console.ReadLine());

            // Create a jagged array for storing points for each student
            int[][] studentPoints = new int[numStudents][];

            // Get the points for each student
            for (int i = 0; i < numStudents; i++)
            {
                Console.WriteLine($"Enter the number of competitions attended by student {i + 1}");
                int numCompetitions = int.Parse(Console.ReadLine());

                // Initialize the array for each student based on the number of competitions
                studentPoints[i] = new int[numCompetitions];

                Console.WriteLine($"Enter the student {i + 1} points");
                for (int j = 0; j < numCompetitions; j++)
                {
                    studentPoints[i][j] = int.Parse(Console.ReadLine());
                }
            }

            // Call the method to find who got maximum points
            string result = FindWhoGotMaximumPoints(studentPoints);

            // Display the result
            Console.WriteLine(result);
        }
    }

}

