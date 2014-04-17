
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


-----------------------------------------------------------
Lesson 02: Read and Write
-----------------------------------------------------------

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

-----------------------------------------------------------------------
lesson 03: Condition Code
------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditional_code
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please introduce yourself: ");
            string interviewer01 = Console.ReadLine();

            Console.WriteLine("nice to meet you {0}", interviewer01);

            if (interviewer01 == "mehdi")
            {
                Console.WriteLine("you have to be our new Environment Artist");
            }
            else if (interviewer01 == "mohammad")
            {
                Console.WriteLine("you have to be our new programmer");

            }
            else
                Console.WriteLine("get out");

            Console.ReadLine();


        }
    }
}
-------------------------------------------------------------------------------------
lesson 04: Switch-case
-----------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condition_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please tell me your name: ");
            string Artist = Console.ReadLine();

            switch (Artist)
            {
                case ("mehdi"):
                    Console.WriteLine("Hello mehdi, nice to meet you");
                    break;

                case ("mohammad"):
                    Console.WriteLine("Hello mohammad, nice to meet you");
                    break;

                default:

                    Console.WriteLine("get out");
                    break;
            }
               
            Console.ReadLine();

            
        }
    }
}

---------------------------------------------------------------------------------------
lesson 05   : constant and enum 
-------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constant_enum
{
    class Program
    {
        enum Metal
        {
            Gold = 2000,
            Silver= 3000,
            Uranium = 5000,
        }

        static void Main(string[] args)
        {
            /* const int gold = 2000;
            const int uranium = 5000;

            string metalname = "nothing" ;
            int metalprice = 6000;           

            Console.WriteLine("Please enter your metal name = ");
            metalname = Console.ReadLine();

            Console.WriteLine("your metal price is {0}" , metalprice );

            if ((metalprice < gold) && (metalprice < uranium))
            {
                Console.WriteLine("your metal is cheap");
            }
            else if ((metalprice > gold) && (metalprice < uranium))
                Console.WriteLine("your metal is worth to buy");
            else
                Console.WriteLine("your metal is excellent");  */

            Console.WriteLine("please enter your metal name = ");
            string metalname = Console.ReadLine();
            int metalprice = 3000;

            Console.WriteLine("your metal price is {0}", metalprice);

            if (( metalprice < (int)Metal.Gold) && (metalprice < (int)Metal.Uranium))
                Console.WriteLine("your metal is cheap");

            else if ((metalprice > (int)Metal.Gold) && (metalprice < (int)Metal.Uranium))
                Console.WriteLine("your metal is worth to buy");
            else
                Console.WriteLine("your metal is EXELLENT to buy");

            
            Console.ReadLine();
        }
        
    }
}
