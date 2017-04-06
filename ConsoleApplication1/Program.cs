using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        //varibles
        private static int birthMonth;
        private static int HELP;
        int age;
        int siblings = 0;
        int moreThanOne = 1;
        int moreThanTwo = 2;
        int moreThanThree = 3;
        public static string numberOfSiblings { get; private set; }

        static void Main(string[] args)
        {
            //ask the user his or her first name
            Console.WriteLine("what is your name ");
            Console.ReadLine();

            //what is the users last name 
            Console.WriteLine("what is your last name");
            Console.ReadLine();

            Console.WriteLine("what is your age");
            Console.ReadLine();

            //ask the users birthMonth 
            int birthMonth; Console.WriteLine("what is your birthMonth");
            Console.ReadLine();

            // ask the users favorite ROYGBIV color
            Console.WriteLine("What is your favorite ROYGBIV color? /b if you dont know what ROYGBIV stands for, type HELP");
            string userColor = Console.ReadLine();

            if (userColor.ToUpper() == "HELP")
            {
                Console.WriteLine("you can choose from red, orange, yellow,  green, \b blue, indigo, or violet.So what do you choose?");
                userColor = Console.ReadLine();

            }
            switch (userColor)
            {
                case "red": break;

                case "orange": break;

                case "yellow": break;

                case "green": break;

                case "blue": break;

                case "indigo": break;

                case "violet": break;
            }
            // ask the user for the number of siblings
            Console.WriteLine("number of siblings");
            Console.ReadLine();

            bool evenNumber = true;
            bool oddNumber = false;
            //if the users age is an odd number , then they will retire in ? or ? if there age is an even number
            if (oddNumber)
            {
                Console.WriteLine("then you wil retire in 25 years");
            }
            else if (evenNumber)
            {
                Console.WriteLine("then you will retire in 10 years");
            }
            // if the users number of siblings is 0, then they will have a vacation home in (location) 
            //or 1 then the will have a vacation home in (location)
            //or 3 then they will have a vacation home in (location?). 
            //if the user eneters anything other than the number greater than or equal to 0 
            //they should get a bad vacation home!
           
           
           
                    
         
                
               
                
                

                    


               

                
               
                
            
               
            
        }
    }
}
