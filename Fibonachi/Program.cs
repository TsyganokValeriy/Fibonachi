using System;

namespace Fibonachi
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int a = 0, b = 1, c = 0;  
            Console.Write( a + " " + b);  
            for (int i = 2; i < 15; i++)  
            {  
                c= a + b;  
                System.Console.Write(" " + c );  
                a= b;  
                b= c;  
            }
        }
    }
}