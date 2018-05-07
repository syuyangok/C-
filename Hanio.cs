using System;


namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator x = new Calculator();
            x.Hanoi(3, 'A', 'B', 'C');
        }

        class Calculator
        {

            public void Hanoi(int n, char x, char y, char z)
            {
                if (n==1)
                {
                    Console.WriteLine("Move from " + x + " to " + z);
                }
                else
                {
                    Hanoi(n - 1, x, z, y);
                    Hanoi(1, x, y, z);
                    Hanoi(n - 1, y, x, z);
                }
            }

        }
    }
}
