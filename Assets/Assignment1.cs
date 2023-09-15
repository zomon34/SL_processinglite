using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment1 : ProcessingLite.GP21
{
    [Header("Name")]
    public Vector2 startPosK; // 4,3
    public Vector2 startPosI; // 8,3
    public Vector2 startPosM; // 10,3

    [Header("Scan Lines")]
    public float spaceBetweenLines = 0.5f;
    float incrementCurrent = 0;
    public float incrementValue = 0.001f;

    [Header("Parabolic Lines")]
    public float numberOfLines = 20;
    int modulus = 0;

    void Start()
    {
        Application.targetFrameRate = 10;
    }

    // Update is called once per frame
    void Update()
    {
        Background(50, 166, 240);

        Stroke(224, 128);
        StrokeWeight(0.5f);

        for (int i = 0; i < (Height + incrementCurrent) / spaceBetweenLines; i++)
        {
            float y = i * spaceBetweenLines - incrementCurrent;

            Line(0, y, Width, y);
        }
        incrementCurrent += incrementValue;
        if (incrementCurrent >= spaceBetweenLines)
        {
            incrementCurrent = 0;
        }

        Stroke(51, 51, 255, 255);
        StrokeWeight(1);
        letterK(startPosK);
        letterI(startPosI);
        letterM(startPosM);

        StrokeWeight(0.5f);

        float distanceBetweenLinesY = Height / numberOfLines;
        float distanceBetweenLinesX = Width / numberOfLines;

        for (int i = 0; i < numberOfLines; i++)
        {
            if (i % 3 == modulus)
            {
                Stroke(128);
            }
            else
            {
                Stroke(255);
            }

            Line(0, Height - i * distanceBetweenLinesY, i * distanceBetweenLinesX, 0);
        }

        modulus++;
        modulus = modulus % 3;

        //for (float i = 0; i < Height; i += 0.5f)
        //{
        //    if (i % 1.5f == 0)
        //    {
        //        Stroke(255, 102, 255);
        //    }
        //    else
        //    {
        //        Stroke(127, 0, 255);
        //    }
        //    Line(0 + i, 0, 0, Height - i);
        //    Line(Width - i, base.Height, Width, 0 + i);
        //    Line(Width - i, 0, Width, Height - i);
        //    Line(0 + i, base.Height, 0, 0 + i);
        //}
        //for (float i = 0; i < Height; i += 0.5f)
        //{
        //    if (i % 1.5f == 0)
        //    {
        //        Stroke(255, 102, 255);
        //    }
        //    else
        //    {
        //        Stroke(51, 51, 255);
        //    }
        //    Line(0 + i, base.Height, 0, 0 + i);
        //}
        //for (float i = 0; i < Height; i += 0.5f)
        //{
        //    if (i % 1.5f == 0)
        //    {
        //        Stroke(255, 102, 255);
        //    }
        //    else
        //    {
        //        Stroke(51, 51, 255);
        //    }
        //    Line(Width - i, 0, Width, Height - i);
        //}
        //for (float i = 0; i < Height; i += 0.5f)
        //{
        //    if (i % 1.5f == 0)
        //    {
        //        Stroke(255, 102, 255);
        //    }
        //    else
        //    {
        //        Stroke(51, 51, 255);
        //    }
        //    Line(Width - i, base.Height, Width, 0 + i);
        //}
        
    }

    public void letterK(Vector2 start)
    {
        Line(start.x, start.y, start.x, start.y + 4);
        Line(start.x, start.y + 2, start.x + 2, start.y + 4);
        Line(start.x, start.y + 2, start.x + 2, start.y);
    }

    public void letterI(Vector2 start)
    {
        Line(start.x, start.y, start.x, start.y + 2.5f);
        Line(start.x, start.y + 4, start.x, start.y + 3.8f);
    }

    public void letterM(Vector2 start)
    {
        Line(start.x, start.y, start.x, start.y + 4);
        Line(start.x, start.y + 4, start.x + 1, start.y + 1);
        Line(start.x + 1, start.y + 1, start.x + 2, start.y + 4);
        Line(start.x + 2, start.y + 4, start.x + 2, start.y);
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