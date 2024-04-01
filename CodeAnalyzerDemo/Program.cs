// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

/// <summary>
/// This is main header.
/// </summary>
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hi!");
    }

    private string MakeGreeting(string name)
    {
        if (name == null)
        {
            throw new ArgumentNullException(nameof(name));
        }

        return "Hello, " + name;
    }
}
