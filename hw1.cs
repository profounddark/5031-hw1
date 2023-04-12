using System;

public class Fibonacci
{

    /// <summary>
    /// Test values for testing the various Fibonacci functions.
    /// </summary>
    public static int[] testValues = { 3, 10, 20 };


    /// <summary>
    /// FibClassic calculates the nth Fibonacci number using a recursive
    /// algorithm.
    /// </summary>
    /// <param name="number">the number (in sequence) to return</param>
    /// <param name="addCount">a counter for tracking additions</param>
    /// <returns>the value of the nth fibonacci number</returns>
    public static int FibClassic(int number, ref int addCount)
    {
        if (number < 2)
        {
            return number;
        }
        else
        {
            addCount++;
            return FibClassic(number - 2, ref addCount)
                + FibClassic(number - 1, ref addCount);
        }

    }

    /// <summary>
    /// FibIterative calculates the nth Fibonacci number using an iterative
    /// algorithm.
    /// </summary>
    /// <param name="number">the number (in sequence) to return</param>
    /// <param name="addCount">a counter for tracking additions</param>
    /// <returns>the value of the nth fibonacci number</returns>
    public static int FibIterative(int number, ref int addCount)
    {
        if (number < 2)
        {
            return number;
        }
        else
        {
            int first = 0;
            int second = 1;
            for (int i = 2; i < number; i++)
            {
                addCount++;
                int third = first + second;
                first = second;
                second = third;
            }
            addCount++;
            return first + second;

        }
    }

    /// <summary>
    /// FibRecursiveAccum calculates the nth Fibonacci number using a recursive
    /// algorithm with acumulator variables.
    /// </summary>
    /// <param name="number">the number (in sequence) to return</param>
    /// <param name="addCount">a counter for tracking additions</param>
    /// <param name="a">the nth - 2 accumulator</param>
    /// <param name="b">the nth - 1 accumulator</param>
    /// <returns>the value of the nth fibonacci number</returns>
    public static int FibRecursiveAccum(int number, ref int addCount, int a = 0, int b = 1)
    {
        if (number <= 0)
        {
            return a;
        }
        else
        {
            addCount++;
            return FibRecursiveAccum(number - 1, ref addCount, b, a + b);

        }
    }

    /// <summary>
    /// Main is the main entry point for the Fibonacci program. Runs tests on
    /// three different Fibonacci algorithms and counts the number of additions
    /// performed by each.
    /// </summary>
    /// <param name="args">command line arguments; not used here</param>
    public static void Main(string[] args)
    {
        // int[] testValues = { 3, 10, 20 };

        Console.WriteLine("Fibonacci Classic:");
        for (int i = 0; i < testValues.Length; i++)
        {
            int counter = 0;

            Console.WriteLine("FibClassic for n = " + testValues[i] + ": "
                + FibClassic(testValues[i], ref counter) + ", " + counter + " adds.");
        }

        // put some whitespace
        Console.Write("\n");

        Console.WriteLine("Fibonacci Iterative:");
        for (int i = 0; i < testValues.Length; i++)
        {
            int counter = 0;
            Console.WriteLine("FibIterative for n = " + testValues[i] + ": "
                + FibIterative(testValues[i], ref counter) + ", " + counter + " adds.");
        }

        // put some whitespace!
        Console.Write("\n");

        Console.WriteLine("Fibonacci Recursive with Accumulator:");
        for (int i = 0; i < testValues.Length; i++)
        {
            int counter = 0;
            Console.WriteLine("FibRecursiveAccum for n = " + testValues[i] + ": "
                + FibRecursiveAccum(testValues[i], ref counter) + ", " + counter + " adds.");
        }

    }
}