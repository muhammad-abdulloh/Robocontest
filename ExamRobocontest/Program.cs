using System;

namespace ExamRobocontest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // #0012 O'yin Robocontest

            int a = int.Parse(Console.ReadLine());
            int number_of_primes = 0;
            for (int i = 1; i <= a; ++i)
            {

                if (IsBool(i))
                {
                    number_of_primes++;
                }
            }
                    
            if (number_of_primes % 2 == 0)
                Console.WriteLine("Bobur");
            else
                Console.WriteLine("Ali");

        }
        
        static bool IsBool(long n)
        {
            if (n < 2)
                return false;
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        } 
    }
}



/*  DK Xiyoboni #0230 Robocontest
 * long x = long.Parse(Console.ReadLine());
  Console.WriteLine(x % 4 == 0 ? "Yes" : "No");
*/









/** static void Main(string[] args)  //G'aroyib son #0017 Robocontest
        {
            
            long N = long.Parse(Console.ReadLine());
            long  h = 0;
            long  k = 0;
            while (h != N)
            {
                k++;
                if ((k % sums(k)) == 0)
                {
                    h++;
                }
            }
            Console.WriteLine(k);

        }
        
        static long sums(long n)
        {
            long sum = 0;
            while (n != 0)
            {
                sum = sum + n % 10;
                n = n / 10;
            }
            return (long)Math.Pow(sum, 2);
        } */


