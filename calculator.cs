/* There are at least seven logic errors in this code and many bad design choices. 
    Feel free to comment or directly edit your changes but do not merge your branch with main! */ 

using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Simple Calculator");

        try
        {
            Console.Write("Enter the first number: ");
            int num1 = Console.ReadLine(); // Readline returns a string, so you need to cast to int

            Console.Write("Enter the second number: ");
            int num2 = Console.ReadLine(); // Readline returns a string, so you need to cast to int

            Console.WriteLine("Select operation (+, -, *, /): ");
            char operation = Console.ReadLine()[0]; //Instead of readline, use readkey

            CalculatorLogic calculatorLogic = new CalculatorLogic();
            // Too many white spaces

            int result = calculatorLogic.PerformCalculation(num1, num2); // Needs the operator

            Console.WriteLine($"Result: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}"); // 
        }
    }
}

class CalculatorLogic
{
    public int PerformCalculation(int num1, int num2, char operation)
    {
        int result = 0;

        switch (operation)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                // A better variable name than num1 and num2 should be used
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Error: Division by zero");
                    // An exception should be generated
                }
                break;
            default:
                // * 
                Console.WriteLine("Error: Invalid operation selected.");
                //
                break;
        }

        return result;
    }
}

class CalculatorUtility
{
    // All classes should not be in one file
    public string ConvertToBinary(int decimalNumber)
    {
        return Convert.ToString(decimalNumber, 10);
    }
}
