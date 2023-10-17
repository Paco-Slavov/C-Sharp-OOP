﻿using CustomStack;

public class StartUp
{
    static void Main()
    {
        StackOfStrings stack = new();

        Console.WriteLine(stack.IsEmpty());

        stack.AddRange(new string[] { "1", "2", "3" });
        stack.AddRange(new string[] { "1", "2", "3" });

        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
    }
}