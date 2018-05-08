using System;


namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic myVar = 100;
            Console.WriteLine(myVar);

            myVar = "Change to string!";
            Console.WriteLine(myVar);
        }

        
    }
}
