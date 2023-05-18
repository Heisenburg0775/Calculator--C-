using System;

public class Calculator
{
    //Definations
#pragma warning disable
    static string op;
    public static double first_number;
    public static double second_number;
    public static double result;
    public static double result_add;
    public static double result_sub;
    public static double result_multi;
    public static double result_rem;
    public static double result_quo;
    public static double result_power;
    public static double result_sq_;
    public static double result_sq__;
    //Functions 
    static double add(double number1, double number2)
    {
        return number1 + number2;
    }
    static double sub(double number1, double number2)
    {
        return number1 - number2;
    }
    static double mult(double number1, double number2)
    {
        return number1 * number2;
    }
    static double rem(double number1, double number2)
    {
        return number1 % number2;
    }
    static double quo(double number1, double number2)
    {
        return number1 / number2;
    }
    static double power(double base_number, double exponent)
    {
        return Math.Pow(base_number, exponent);
    }
    static double SquareRut(double number)
    {
        return Math.Sqrt(number);
    }

    //Main Script
    static void Main(String[] args)
    {
#pragma warning disable
        Console.WriteLine("Enter your operaton method(+,-,/,*,s,p,a): ");
        op = Console.ReadLine();
        switch (op)
        {
            case "+":
                try
                {
#pragma warning disable
                    Console.WriteLine("Enter your first number: ");
                    first_number = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter your second number: ");
                    second_number = Double.Parse(Console.ReadLine());
                    result = add(first_number, second_number);
                    Console.WriteLine($"{first_number} + {second_number} gives {result}");

                }
                catch (Exception err)
                {
                    Console.WriteLine($"The input provided was invalid.");
                }
                break;
            case "-":
                try
                {
#pragma warning disable
                    Console.WriteLine("Enter your first number: ");
                    first_number = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter your second number: ");
                    second_number = Double.Parse(Console.ReadLine());
                    result = sub(first_number, second_number);
                    Console.WriteLine($"{first_number} - {second_number} gives {result}");
                }
                catch (Exception err)
                {
                    Console.WriteLine($"The input provided was invalid.");
                }
                break;
            case "/":
                try
                {
#pragma warning disable
                    Console.WriteLine("Enter your first number: ");
                    first_number = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter your second number: ");
                    second_number = Double.Parse(Console.ReadLine());
                    result_quo = quo(first_number, second_number);
                    result_rem = rem(first_number, second_number);
                    Console.WriteLine($"{first_number} / {second_number} gives {result_quo} as quotient and {result_rem} as reminader");
                }
                catch (Exception err)
                {
                    Console.WriteLine($"The input provided was invalid.");
                }
                break;
            case "*":
                try
                {
#pragma warning disable
                    Console.WriteLine("Enter your first number: ");
                    first_number = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter your second number: ");
                    second_number = Double.Parse(Console.ReadLine());
                    result = mult(first_number, second_number);
                    Console.WriteLine($"{first_number} * {second_number} gives {result}");
                }
                catch (Exception err)
                {
                    Console.WriteLine($"The input provided was invalid.");
                }
                break;
            case "s":
                try
                {
#pragma warning disable
                    Console.WriteLine("Enter your number: ");
                    first_number = Double.Parse(Console.ReadLine());
                    result = SquareRut(first_number);
                    Console.WriteLine($"{first_number} gives {result}");
                }
                catch (Exception err)
                {
                    Console.WriteLine($"The input provided was invalid.");
                }
                break;
            case "p":
                try
                {
#pragma warning disable
                    Console.WriteLine("Enter your base number: ");
                    first_number = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter your exponent number: ");
                    second_number = Double.Parse(Console.ReadLine());
                    result = power(first_number, second_number);
                    Console.WriteLine($"{first_number} ^ {second_number} gives {result}");
                }
                catch (Exception err)
                {
                    Console.WriteLine($"The input provided was invalid.");
                }
                break;
            case "a":
                try
                {
#pragma warning disable
                    Console.WriteLine("Enter your base number: ");
                    first_number = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter your exponent number: ");
                    second_number = Double.Parse(Console.ReadLine());
                    result_add = add(first_number, second_number);
                    result_sub = sub(first_number, second_number);
                    result_multi = mult(first_number, second_number);
                    result_power = power(first_number, second_number);
                    result_sq_ = SquareRut(first_number);
                    result_sq__ = SquareRut(second_number);
                    result_quo = quo(first_number, second_number);
                    result_rem = rem(first_number, second_number);
                    Console.WriteLine($"{first_number} + {second_number} = {result_add}");
                    Console.WriteLine($"{first_number} - {second_number} = {result_sub}");
                    Console.WriteLine($"{first_number} * {second_number} = {result_multi}");
                    Console.WriteLine($"{first_number} / {second_number} = {result_quo} as quotient {result_rem} as remainder");
                    Console.WriteLine($"Square root of {first_number} is {result_sq_}");
                    Console.WriteLine($"Square root of {second_number} is {result_sq__}");

                }
                catch (Exception err)
                {
                    Console.WriteLine("Invalid input was provided");
                }
                break;
            default:
                Console.WriteLine("Please provide a valid operation method!");
                break;

        }
    }
}