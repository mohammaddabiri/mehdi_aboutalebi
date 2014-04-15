
Lesson 01: HelloWorld
---------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HelloWorld");

            Console.ReadLine();
        }
    }
}


----------------------------------------------------------
Lesson 02: Read and Write
----------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleReadAndWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("helloWorld");
            
            string myname= Console.ReadLine();

            Console.WriteLine("What a beautiful name " + myname);
            */
            Console.WriteLine("Please import the width:");
            string width = Console.ReadLine();
            Console.WriteLine("Please import the Length:");
            string length = Console.ReadLine();
            Console.WriteLine("Please import the height:");
            string height = Console.ReadLine();

            Console.WriteLine("the Width, Length and Heigth of the box is {0},{1},{2}" , width, length, height);


                 Console.ReadLine();
        }
    }
}
