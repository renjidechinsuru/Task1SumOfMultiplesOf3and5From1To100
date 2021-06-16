using System;

namespace Task1SumOfMultiplesOf3and5From1To100
{
    /*
     Using C# Console Application, 
    write a program that will perform the following tasks:
    a.Calculate and display the sum of all multiples of3and5 from 1 to 100(both inclusive)
    b.Also include a pseudocode of the program.
    For example,if we list all the numbers between 1 and 10that are multiples of 3 or 5, 
    we get 3, 5, 6,9and 10. The sum of these multiples is33.
    */
    class Program
    {
        static void Main(string[] args)
           
            
        {
            int max =100; //the sum of all multiples of3and5 from 1 to 100 so max = 100
            int sum = 0;
            int num;



            for (num = 3; num <= max; num++) // minimum number(starting point) is 3

            {
                if ((num % 3 == 0) || (num % 5 == 0)) ; // the number has to be able to devided by 3 and 5
                sum = sum + num;


            }
            Console.WriteLine("Sum of Multiplies of 3 and 5 from 1 to 100 is " + sum);


                
        }
    }
}
