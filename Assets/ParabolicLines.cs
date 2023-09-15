using ProcessingLite;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParabolicLines : ProcessingLite.GP21
{
    public int startX;
    public int startY;
    // Start is called before the first frame update
    void Start()
    {
        
        for (float i = 0; i < Height; i += 0.5f)
        {
            if (i % 1.5f == 0)
            {
                Stroke(255, 102, 255);
            }
            else
            {
                Stroke(51, 51, 255);
            }
            Line(startX + i, startY, startX, Height - i);
        }
        for (float i = 0; i < Height; i += 0.5f)
        {
            if (i % 1.5f == 0)
            {
                Stroke(255, 102, 255);
            }
            else
            {
                Stroke(51, 51, 255);
            }
            Line(startX + i, base.Height, startX, startY + i);
        }
        for (float i = 0; i < Height; i += 0.5f)
        {
            if (i % 1.5f == 0)
            {
                Stroke(255, 102, 255);
            }
            else
            {
                Stroke(51, 51, 255);
            }
            Line(Width - i, startY, Width, Height - i);
        }
        for (float i = 0; i < Height; i += 0.5f)
        {
            if (i % 1.5f == 0)
            {
                Stroke(255, 102, 255);
            }
            else
            {
                Stroke(51, 51, 255);
            }
            Line(Width - i, base.Height, Width, startY + i);
        }
    }
    public class axis
    {
        public Vector2 start;
        public Vector2 end;

        public axis(Vector2 _start, Vector2 _end)
        {
            start = _start;
            end = _end;
        }
    }

    public class parabolicLine
    {
        public int numberOfLines;
        public axis axis1;
        public axis axis2;

        public parabolicLine(axis _axis1, axis _axis2, int _numberOfLines)
        {
            numberOfLines = _numberOfLines;
            axis1 = _axis1;
            axis2 = _axis2;
        }
    }

    public void drawLine(parabolicLine parabolicLine)
    {
        //for (int i = 0; i < parabolicLine.numberOfLines; i++)
        //{

        //}
    }

}