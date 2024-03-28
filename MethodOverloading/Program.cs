namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(10, 20));
            Console.WriteLine(Add(10.5, 20.5));
            Console.WriteLine(Add(10, 20, true));
        }
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static double Add(double x, double y)
        {
            return x + y;
        }
        
        public static string Add(int x, int y, bool z)
        {
            if (z == true)
            {
                if (x + y > 1)
                {
                    return x + y + "dollars";
                }
                else
                {
                    return x + y + "dollar";
                }          
            }
            else
            {
                return $"x + y";
            }
        }
    }
}
