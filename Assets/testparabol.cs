using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testparabol : ProcessingLite.GP21


{
    // Start is called before the first frame update
    void Start()
    {
        StrokeWeight(0.5f);

        for (int i = 0; i < 20; i++)
        {
            Line(0, 20 - i, i, 0);

            if (i % 3 == 0) //byt färg på var tredje linje
            {
                Stroke(236, 66, 245, 64);
            }
            else
            {
                Stroke(3, 90, 252, 64);
            }
            
        }
       

        for (int i = 0; i < 40; i++)
        {
            Line(0, 40 - i, i, 7);

            if (i % 3 == 0) //byt färg på var tredje linje
            {
                Stroke(3, 90, 252, 64);
            }
            else
            {
                Stroke(252, 28, 3, 64);
            }
            
        }
    }
}