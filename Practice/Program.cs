using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace HelloWorld
{   
    class Program
    {
        static void Main(string[] arg)
        {
            //this is a comment
            /*this is a multiline 
             \comment*/
            Console.WriteLine("first program in curemd");
            Console.WriteLine("this is my first program that i am running in curemd");
            //variables
            //they are containers for storing data
            string name = "zohaib ali";
            Console.WriteLine(name);
            //different variables
            int var = 10;
            double num = 10.34D; ;
            string str = "this is a string";
            bool flag = true;

            //the const keyword so the current value of the variable cant be overwritten 
            const int i = 0;
            Console.WriteLine("Hello "+name);
            string firstName = "Zohaib ";
            string secondName = "Ali";
            string fullName = firstName+ secondName;
            Console.WriteLine(fullName);
            int minutesPerHour = 10;
            Console.WriteLine(minutesPerHour);
            //a variable must be identifies with unique names
            //only digits,letters and underscore
            //cannot begin with a digit


            //Type Casting

            //implicit casting
            int num1 = 10;
            double newnum = num1;
            Console.WriteLine(newnum);

            //explicit casting is converting a smaller datatype into larger datatype
            //double d = 10.34D;
            //int i2 = (int)d;//this is called explicit casting
            ////type conversion methods
            //string username = Console.ReadLine();
            //Console.WriteLine(username);
            ////console.readline() methods read string from the user
            //int number=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(number);  

            int x = 10;
            int y = 15;
            Console.WriteLine(x<y);
            Console.WriteLine(Math.Max(5,10));
            //Math.Min
            //Math.Max
            //Math.Sqrt
            //Math.Round
            //Abs

            //string 

            string str2="zohaib ali";
            Console.WriteLine("Length of the my name is : "+str2.Length);
            //other methods
            Console.WriteLine(str2.ToLower());
            Console.WriteLine(str2.ToUpper());

            //Concat
            Console.WriteLine(string.Concat(fullName, str2));

            //string interpolation



        }
    }
}