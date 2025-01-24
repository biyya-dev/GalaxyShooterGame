using System;
using System.Collections.Generic;

public class DSLInterpreter
{
    public static void GenerateGameElements(Dictionary<string, object> parsedData)
    {
        Console.WriteLine("Setting up game elements based on DSL...");
        foreach (var item in parsedData)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }
}
