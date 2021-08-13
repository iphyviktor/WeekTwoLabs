using System;
using System.Collections.Generic;


namespace awesomeapplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number : ");
            int number = int.Parse(Console.ReadLine());
            CheckPrime(number);

            Console.Write("*****************************");

            Console.WriteLine("Check if sum of two numbers is less than or greater than 100" + "\n");

            Console.Write("Enter a Number : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter another Number : ");
            int num2 = int.Parse(Console.ReadLine());
            
            
            LessThanHun(num1, num2);
            
            Console.WriteLine("Get the remainder of a division\n");
            Console.WriteLine("Enter value of x: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value of y: ");
            int y = int.Parse(Console.ReadLine());

            GetTheRemainder(x, y);

        }

        static void CheckPrime(int number){
                                    
            if(number % 2 == 1) {
                
                Console.WriteLine("Prime Number");
            }
            else{
                Console.WriteLine("Not Prime Number");
            }

        }

        

        static void LessThanHun(int num1, int num2){
            int sum = num1 + num2;
            string less = "true";
            string greater = "false";
            if(sum < 100){
                Console.WriteLine(less);
            }else{
                Console.WriteLine(greater);
            }

       }

        static void GetTheRemainder(int x, int y){
            int theRemainder = x % y;
            Console.WriteLine(theRemainder);
        }

   
    }
    
    
}
