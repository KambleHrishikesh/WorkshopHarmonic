namespace HarmonicWorkshop
{
    public class Harmonic
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Harmonic Number");
            Console.WriteLine("enter number");
            int num =Convert.ToInt32(Console.ReadLine());
            double sum = 0;
            for(double count=1;count<=num;count++)
            {
                Console.WriteLine("1/{0}",count);
                sum = sum + 1 / count;

            }
            Console.WriteLine("the sum of {0} series is {1}", num, sum);
            Console.ReadLine();
        }
    }
}