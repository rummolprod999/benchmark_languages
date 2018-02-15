using System;
namespace HelloApp
{
    class Program
    {
        private static void Main(string[] arg)
        {
            var a = DateTime.Now;
            long s = 0L;
            for(int i = 0; i <3; i++){
                s = fib(45);
            }
            var b = DateTime.Now;
            TimeSpan c = b.Subtract(a);
            Console.WriteLine(s);
            Console.WriteLine(c.Seconds);
            Console.WriteLine(c.Seconds/3.0);

        }

        public static long fib(int n)
        {
            if(n<3){
                return 1;
            }
            return fib(n-1) + fib(n-2);
        }
    }
}