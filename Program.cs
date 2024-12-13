using System;
using System.Collections.Generic;


// Task1
// If the entered number is greater than 7, then print "Hello"

class Program1
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        if (number > 7)
        {
            Console.WriteLine("Hello");
        }
    }
}

// Task2
// If the entered name matches "John", then output "Hello, John", if not, then output "There is no such name"

class Program2
{
    static void Main()
    {
        Console.Write("Enter a name: ");
        string name = Console.ReadLine();
        if (name == "John")
        {
            Console.WriteLine("Hello, John");
        }
        else
        {
            Console.WriteLine("There is no such name");
        }
    }
}

// Task3
// There is a numeric array at the input, it is necessary to output array elements that are multiples of 3

class Program3
{
    static void Main()
    {
        int[] arr = new int[7];
        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < 7; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Elements that are multiples of 3:");
        foreach (int num in arr)
        {
            if (num % 3 == 0)
            {
                Console.Write(num + " ");
            }
        }
        Console.WriteLine();
    }
}

// Task4
class Program4
{
    static bool IsBalanced(string sequence)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char ch in sequence)
        {
            if (ch == '(' || ch == ']')
            {
                if (stack.Count == 0)
                {
                    return false;
                }

                char top = stack.Pop();

                if ((ch == ')' && top != '(') || (ch == ']' && top != '['))
                {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }

    static void Main()
    {
        string sequence = "[((())()(())]]";

        if (IsBalanced(sequence))
        {
            Console.WriteLine("The bracket sequence is correct");
        }
        else
        {
            Console.WriteLine("The bracket sequence is incorrect");
        }
    }
}
