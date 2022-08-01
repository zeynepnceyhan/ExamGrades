namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int midterm, final, makeup, avg;
            Console.WriteLine("Please enter your midterm exam's grade: ");
            midterm = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your final exam's grade: ");
            final = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your makeup exam's grade: ");
            makeup = Convert.ToInt32(Console.ReadLine());

            avg = (midterm + final + makeup) / 3;

            if (avg >= 50)
            {
                Console.WriteLine("CONGRATULATIONS SUCCESSFULLY PASSED THE CLASSES... Your Average: " + avg);
            }
            else
            {
                Console.WriteLine("SORRY YOU FAILED... Your Average: " + avg);
            }


            Console.ReadLine();
        }

    }

}