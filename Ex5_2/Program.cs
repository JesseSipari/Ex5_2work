using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Copy your solutions to tasks 4 - 6 here inside this Main method code range
            //DO NOT COPY THE MAIN METHOD DECLARATION, ONLY THE CODE LINES

            //Task 4: Celsius degrees to Fahrenheit degrees 
            //Enter code here, save and run the test 
            double fahrenheit;
            double celsius = Convert.ToDouble(Console.ReadLine());
            fahrenheit = celsius * 9 / 5 + 32;
            Console.WriteLine("{0,0} {1,12}", "Fahrenheit", "Celsius");
            Console.WriteLine("{1,0:0.0} {0,16:0.00}", fahrenheit, celsius);
            //Task 5: unary (increment/decrement) and value change operators 
            //Enter code here, save and run the test
            //Read integer values to variables i, j, and k from keyboard
            int i = Convert.ToInt32(Console.ReadLine());
            int k = Convert.ToInt32(Console.ReadLine());
            int j = Convert.ToInt32(Console.ReadLine());

            // increment i by one
            i++;
            // increase i by one, then change value of j by adding the new value of i to it
            j = ++i + j;
            // change value of k by adding the value of i*j, after that increase k by one
            k = k + i * j + 1;
            // j decreased by one and then i added by sum of(new value of) j and k
            j = j - 1 - i + j + k;
            // j increased by one and then k changed(subtract) by new value of j
            j =+ 1 + k-j;
            //output i, j and k, each on separate rows
            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.WriteLine(k);

            //Task 6:6	Format codes of the strings are strings themselves 
            //Enter code here, save and run the test

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            c = c + 1;
            b = b + 1 + 1 + c + c;
            a = a - 1 + b;
            a = 1 + a;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}