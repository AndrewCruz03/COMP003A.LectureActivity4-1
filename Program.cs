namespace COMP003A.LectureActivity4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] grades = new int[5];  //array to store 5grades

            for (int i = 0; i < grades.Length; i++)
            {
                int grade = -1;
                while (grade < 0 || grade > 100)
                {
                    Console.Write($"Enter grade for students {i + 1} (0-100): ");
                    if (int.TryParse(Console.ReadLine(), out grade))
                    {
                        if (grade >= 0 && grade <= 100)
                        {
                            grades[i] = grade;
                        }
                        else
                        {
                            Console.WriteLine("Grade must be between 0 and 100.");
                        }

                    }
                    else
                    {
                        Console.WriteLine("Grade must be between 0 and 100.");
                    }

                }
            }


            double sum = 0;
            for (int i = 0; i < grades.Length; i++)
            { 
            sum += grades[i];
            }
            double average = sum / grades.Length;


            Console.WriteLine("\nGrades:");
            foreach (int grade in grades)
            {
                Console.WriteLine(grade);
            
            }
            Console.WriteLine($"Average Grade: {average:F2}");





            List<string> studentNames = new List<string>();

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter name for student {i + 1}: ");
                studentNames.Add( Console.ReadLine() );
            }


            Console.WriteLine("\nStudent Names: ");
            for (int i = 0; i < studentNames.Count; i++)
            {
                Console.WriteLine($"Student {i +1}: {studentNames[i]}");
            }

        }
    }
}
