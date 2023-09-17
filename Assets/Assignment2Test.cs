using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using Unity.VisualScripting;
using UnityEngine;

public class Assignment2Test : ProcessingLite.GP21
{
    
    
    //function e få alla lines i en function
    void e()
    {
        List<Line> lines = new List<Line>();
        lines.AddRange(new Line[] { });


        //E
        Line(4, 7, 4, 3); //vänster vertical x,y,x,y
        Line(4, 7, 6, 7); //horizontal överst 
        Line(4, 5, 6, 5); //horizontal mitten
        Line(4, 3, 6, 3); //horizontal nedest
    }

    // Start is called before the first frame update
    void Start()
    {
        
        //E
        Line(4, 7, 4, 3); //vänster vertical x,y,x,y
        Line(4, 7, 6, 7); //horizontal överst 
        Line(4, 5, 6, 5); //horizontal mitten
        Line(4, 3, 6, 3); //horizontal nedest

        //l
        Line(8, 7, 8, 3);

        //i
        Line(10, 5.5f, 10, 3);
        Line(10, 7, 10, 6.8f); //pricken

        //n
        Line(12, 5.5f, 12, 3); //vänster vertical
        Line(12, 5, 14, 5); //horizontal mitten
        Line(14, 5, 14, 3); //höger vertical 

        Circle(15, 5, 5);
        Square(1, 4, 2);
        




    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
//test
class Line
{
    
    
    
    public int X1 { get; set; }
    public int Y1 { get; set; }
    public int X2 { get; set; }
    public int Y2 { get; set; }

    public Line(int x1, int y1, int x2, int y2)
    {
        X1 = x1;
        Y1 = y1;
        X2 = x2;
        Y2 = y2;
    }
}

class LinesCollection
{
    
    
    public List<Line> lines = new List<Line>();

    public void AddLine(int x1, int y1, int x2, int y2)
    {
        lines.Add(new Line(x1, y1, x2, y2));
    }

    public void DrawLines()
    {
        foreach (var line in lines)
        {
            Console.WriteLine($"Line: ({line.X1}, {line.Y1}) to ({line.X2}, {line.Y2})");
            // You can add drawing code here if needed
        }
    }
}

class Program2
{

    //Make each letter of your name into a function and give it parameters so that you can change its position.

    public int E;
    public int L;
    public int I;
    public int N;

    static void Main()
    {
        
        
        
        LinesCollection linesCollection = new LinesCollection();

        // Add lines to the collection
        linesCollection.AddLine(4, 7, 4, 3);
        linesCollection.AddLine(4, 7, 6, 7);
        linesCollection.AddLine(4, 5, 6, 5);
        linesCollection.AddLine(4, 3, 6, 3);

        // Draw all lines in the collection
        linesCollection.DrawLines();
    }
}
