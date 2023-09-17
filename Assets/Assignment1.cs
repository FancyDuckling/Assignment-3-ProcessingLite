using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Assignment1 : ProcessingLite.GP21 //vi ärver fr denna class
{
    [Range(1f, 255)] public int redColorValue; //detta gör att man får en slider i unity och kan ej gå över värdet 255
    [Range(1f, 255)] public int greenColorValue;
    [Range(1f, 255)] public int blueColorValue;
    public float spaceBetweenLines = 0.2f; //local variabel

    // Start is called before the first frame update
    void Start()
    {
        //Line(4, 7, 4, 3);
        //Line(4, 5, 6, 5);
        //Line(6, 7, 6, 3);

        //Line(8, 5.5f, 8, 3);
        //Line(8, 7, 8, 6.8f);

       

    }

    // Update is called once per frame
    void Update()
    {
        //Clear background
        Background(redColorValue, greenColorValue, blueColorValue); //istället för att skriva rgbvärden som tex: Background(50, 166, 240) kan man använda slider

        //Draw our art/stuff, or in this case a rectangle
        Rect(1, 1, 3, 3);

        //Prepare our stroke settings
        Stroke(128, 128, 128, 64); //färger RGB alpha/opacity
        StrokeWeight(0.5f);

        //Draw our scan lines
        for (int i = 0; i < Height / spaceBetweenLines; i++)
        {
            //Increase y-cord each time loop run
            float y = i * spaceBetweenLines;

            //Draw a line from left side of screen to the right
            Line(0, y, Width, y);
        }
    }
        
    }
