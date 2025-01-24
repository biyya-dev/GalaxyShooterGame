using System;
using System.Collections.Generic;
using System.IO;

public class DSLParser
{
    public static Dictionary<string, object> Parse(string filePath)
    {
        var content = File.ReadAllText(filePath);
        var result = new Dictionary<string, object>();

        foreach (var line in content.Split('\n'))
        {
            var trimmed = line.Trim();
            if (trimmed.Contains(":"))
            {
                var parts = trimmed.Split(':');
                result[parts[0].Trim()] = parts[1].Trim().Trim('"');
            }
        }

        return result;
    }
}
