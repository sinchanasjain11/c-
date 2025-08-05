namespace squarenum
{
    internal class Program
    {
         public static void Main(string[] args)
        {
            squarenum calc = new squarenum(); // Create object of Calculator class

            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int result = calc.Square(num); // Call the Square method

            Console.WriteLine("Square of {0} is {1}", num, result);
        }
    }
}
