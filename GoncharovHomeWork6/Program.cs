using System;

namespace GoncharovHomeWork6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter operand1:");
            double o1 = double.Parse(Console.ReadLine());
            Console.WriteLine("enter operand2:");
            double o2 = double.Parse(Console.ReadLine());

            Console.WriteLine("choose operation(add- 1, dif - 2, mul - 3, div - 4):");
            int choose = int.Parse(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    {
                        Console.WriteLine($"result of addition {o1} and {o2} is {Clalculator.Add(o1, o2)}");
                        break; 
                    }
                case 2:
                    {
                        Console.WriteLine($"result of subtraction {o1} and {o2} is {Clalculator.Sub(o1, o2)}");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine($"result of multiplication {o1} and {o2} is {Clalculator.Mul(o1, o2)}");
                        break;
                    }
                case 4:
                    {
                        if (o2==0)
                            Console.WriteLine("bye");
                        else
                        Console.WriteLine($"result of division {o1} and {o2} is {Clalculator.Div(o1, o2)}");
                        break;
                    }
            }
        }
    }
}
