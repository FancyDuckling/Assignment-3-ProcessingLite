using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : ProcessingLite.GP21
{ }
class LineStorage
{
    public List<Tuple<int, int, int, int>> E { get; } = new List<Tuple<int, int, int, int>>();

    public void AddLine(int x1, int y1, int x2, int y2)
    {
        E.Add(Tuple.Create(x1, y1, x2, y2));
    }
}

class Program
{
    static void Main()
    {
        LineStorage lineStorage = new LineStorage();

        // Add lines to the E field
        lineStorage.AddLine(4, 7, 4, 3);
        lineStorage.AddLine(4, 7, 6, 7);
        lineStorage.AddLine(4, 5, 6, 5);
        lineStorage.AddLine(4, 3, 6, 3);

        // Access and use the lines in E
        foreach (var line in lineStorage.E)
        {
            Console.WriteLine($"Line({line.Item1}, {line.Item2}, {line.Item3}, {line.Item4})");
        }
    }
}