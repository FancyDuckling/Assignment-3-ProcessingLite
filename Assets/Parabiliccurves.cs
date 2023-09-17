using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class Parabiliccurves : ProcessingLite.GP21
{   
    // Start is called before the first frame update
    void Start()
    {
        StrokeWeight(0.5f);

          for (int i = 0; i < 20; i++) {
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
        

        /* Line(0, 10, 0, 0); //hjälplinje vertical
         Line(0, 0, 10, 0); //hjälplinje horizontal

         Line(0, 10, 1, 0); 
         Line(0, 9, 2, 0); 
         Line(0, 8, 3, 0); 
         Line(0, 6, 5, 0); 
         Line(0, 5, 6, 0); 
         Line(0, 4, 7, 0); 
         Line(0, 3, 8, 0); 
         Line(0, 2, 9, 0); 
         Line(0, 1, 10, 0); */

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
