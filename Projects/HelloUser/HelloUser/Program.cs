using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloUser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the users name ");//This propts the usr to enter their name.
            string input = Console.ReadLine();//This is how the computer reads your input.
            Console.Write("Hello ");//This is where the computer displays
            Console.Write(input);//This is where the computer displays the results of your input.

            Console.ReadKey();
            }     
        }
    }
