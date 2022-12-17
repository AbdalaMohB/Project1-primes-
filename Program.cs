using System.Security.Cryptography.X509Certificates;

namespace Primenums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first number");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            int y = int.Parse(Console.ReadLine());
            printprimes(x,y);
            Console.ReadKey();
        }
        public static bool primecheck(int z)
        {   if (z<2) return false;
            for(int i=2; i<=z/2; i++)
            {
                if (z%i==0)
                {
                    return false;
                }
            }
            return true;
        }
        public static void printprimes(int num1, int num2)
        {
            int o = num2 > num1 ? num2 : num1;//bigger
            int p = num2 > num1 ? num1 : num2;//smaller
            while (o >= p)
            {
                if (primecheck(p))
                {
                    Console.WriteLine(p);
                }
                ++p;
            }
        }
    }
    }