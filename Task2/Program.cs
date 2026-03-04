using System;

class Program
{
    static void Main()
    {
        // Exercise 1
        Console.WriteLine("Exercise 1:");
        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        if (num1 == num2)
            Console.WriteLine("Numbers are equal");
        else if (num1 > num2)
            Console.WriteLine("First number is greater than second");
        else
            Console.WriteLine("First number is less than second");


        // Exercise 2
        Console.WriteLine("\nExercise 2:");
        Console.Write("Enter number: ");
        double number = Convert.ToDouble(Console.ReadLine());

        if (number > 5 && number < 10)
            Console.WriteLine("The number is greater than 5 and less than 10");
        else
            Console.WriteLine("Unknow number");


        // Exercise 3
        Console.WriteLine("\nExercise 3:");
        Console.Write("Enter number: ");
        number = Convert.ToDouble(Console.ReadLine());

        if (number == 5 || number == 10)
            Console.WriteLine("The number is either 5 or 10");
        else
            Console.WriteLine("Unknow number");


        // Exercise 4
        Console.WriteLine("\nExercise 4:");
        Console.Write("Enter deposit amount: ");
        double deposit = Convert.ToDouble(Console.ReadLine());
        double percent = 0;

        if (deposit < 100)
            percent = 0.05;
        else if (deposit >= 100 && deposit <= 200)
            percent = 0.07;
        else
            percent = 0.10;

        double result = deposit + deposit * percent;
        Console.WriteLine("Amount with interest: " + result);


        // Exercise 5
        Console.WriteLine("\nExercise 5:");
        Console.Write("Enter deposit amount: ");
        deposit = Convert.ToDouble(Console.ReadLine());

        if (deposit < 100)
            percent = 0.05;
        else if (deposit >= 100 && deposit <= 200)
            percent = 0.07;
        else
            percent = 0.10;

        result = deposit + deposit * percent + 15;
        Console.WriteLine("Amount with interest and bonus: " + result);


        // Exercise 6
        Console.WriteLine("\nExercise 6:");
        Console.WriteLine("Enter operation number:");
        Console.WriteLine("1.Addition");
        Console.WriteLine("2.Subtraction");
        Console.WriteLine("3.Multiplication");

        int operation = Convert.ToInt32(Console.ReadLine());

        switch (operation)
        {
            case 1:
                Console.WriteLine("Addition");
                break;
            case 2:
                Console.WriteLine("Subtraction");
                break;
            case 3:
                Console.WriteLine("Multiplication");
                break;
            default:
                Console.WriteLine("Operation is undefined");
                break;
        }


        // Exercise 7
        Console.WriteLine("\nExercise 7:");
        Console.WriteLine("Enter operation number:");
        Console.WriteLine("1.Addition");
        Console.WriteLine("2.Subtraction");
        Console.WriteLine("3.Multiplication");

        operation = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter first number: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter second number: ");
        double b = Convert.ToDouble(Console.ReadLine());

        switch (operation)
        {
            case 1:
                Console.WriteLine("Result: " + (a + b));
                break;
            case 2:
                Console.WriteLine("Result: " + (a - b));
                break;
            case 3:
                Console.WriteLine("Result: " + (a * b));
                break;
            default:
                Console.WriteLine("Operation is undefined");
                break;
        }
    }
}
