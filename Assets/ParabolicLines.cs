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
    public class Axis
    {
        public Vector2 start;
        public Vector2 end;

        public Axis(Vector2 start, Vector2 end)
        {
            this.start = start;
            this.end = end;
        }
    }

    public class ParabolicLine
    {
        public int numberOfLines;
        public Axis axis1;
        public Axis axis2;

        public ParabolicLine(Axis axis1, Axis axis2, int numberOfLines)
        {
            this.numberOfLines = numberOfLines;
            this.axis1 = axis1;
            this.axis2 = axis2;
        }
    }

    public void DrawLine(ParabolicLine parabolicLine)
    {
        //for (int i = 0; i < parabolicLine.numberOfLines; i++)
        //{

        //}
    }

}