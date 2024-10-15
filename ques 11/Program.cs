namespace ques_11
{
    internal class Program
    {
       
        // Method to find and return students' ranks based on their marks
        public static int[] FindStudentsRank(int[,] stdMarks)
        {
            int numStudents = stdMarks.GetLength(0);
            int numSubjects = stdMarks.GetLength(1);
            int[] totalMarks = new int[numStudents];
            int[] ranks = new int[numStudents];

            // Step 1: Calculate the total marks for each student
            for (int i = 0; i < numStudents; i++)
            {
                int sum = 0;
                for (int j = 0; j < numSubjects; j++)
                {
                    sum += stdMarks[i, j];
                }
                totalMarks[i] = sum; // Store the total marks of the student
            }

            // Step 2: Calculate ranks based on the total marks
            for (int i = 0; i < numStudents; i++)
            {
                int rank = 1;
                for (int j = 0; j < numStudents; j++)
                {
                    if (totalMarks[j] > totalMarks[i])
                    {
                        rank++; // Increment rank if another student's total marks are higher
                    }
                }
                ranks[i] = rank; // Store the rank of the student
            }

            return ranks;
        }

        public static void Main(string[] args)
        {
            // Get the number of students from the user
            Console.WriteLine("Enter the number of students");
            int numStudents = int.Parse(Console.ReadLine());

            // Create a 2D array to store the marks of students
            int[,] studentMarks = new int[numStudents, 5]; // 5 subjects

            // Get the marks for each student
            for (int i = 0; i < numStudents; i++)
            {
                Console.WriteLine($"Enter marks for Student {i + 1}");
                for (int j = 0; j < 5; j++)
                {
                    studentMarks[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Call the method to find the ranks of the students
            int[] studentRanks = FindStudentsRank(studentMarks);

            // Display the rank of each student
            for (int i = 0; i < numStudents; i++)
            {
                Console.WriteLine($"Rank of student {i + 1} is {studentRanks[i]}");
            }
        }
    }

}

