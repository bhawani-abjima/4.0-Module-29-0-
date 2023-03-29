using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Text;  
using System.Threading.Tasks;  
  
namespace add
{
    class Program
    {
       public static int monthlywage = 1234;
        public static int months = 12;
        static void Main(string[] args)
        {
            int Number1, Number2, runs, balls, Strike;
            Console.WriteLine("enter the batsman total runs");      
            Number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the no of innings");
            Number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter last matches run");
            runs = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter ball faced by batsman");
            balls = Convert.ToInt32(Console.ReadLine());
            int Result;
            Result = Number1/Number2;
            Strike = (runs / balls)*100;
            Console.WriteLine("Batsman avg:" + Result.ToString());
            Console.WriteLine("Batsman strike rate:" + Strike.ToString());

            
            int yearlywage=Calculatewage(monthlywage, months);
            Console.WriteLine(yearlywage);
            Console.ReadLine();
        }
        public static int Calculatewage(int monthlywage, int number)
        {
            int bonus;
            Console.WriteLine("enter the monthly bonus");
            bonus = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"yearly wage:{monthlywage*number}");
            return monthlywage * number + bonus;
        }
    }
}