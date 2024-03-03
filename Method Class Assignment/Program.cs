using System;

// Creating the class Maths
public class Maths
{
    // Void method taking two integers as parameters
    public void PerformMathOperation(int firstNumber, int secondNumber)
    {
        // Maths operation on the first integer
        int result = firstNumber + 1;

        // Display the second integer
        Console.WriteLine($"Result: {result}, Second Number: {secondNumber}");
    }
}

class Program
{
    static void Main()
    {
        // Instantiate Maths class
        Maths mathsObject = new Maths();

        // Calling the method and passing numbers
        mathsObject.PerformMathOperation(50, 100);

        // Calling the method and parameters
        mathsObject.PerformMathOperation(firstNumber: 20, secondNumber: 75);
    }
}