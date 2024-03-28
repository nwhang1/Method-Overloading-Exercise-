namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
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
