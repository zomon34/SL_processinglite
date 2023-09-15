using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorAssignment : ProcessingLite.GP21
{
    Vector2 circleVector = new(2,2);
    public float diameter = 1;
    
    Vector2 velocityVector;
    public float maxSpeed = 1;

    // Update is called once per frame
    // This comment is to test Git
    void Update()
    {
        Background(50, 166, 240);

        if (Input.GetMouseButtonUp(0))
        {
            Vector2 mousePos = new Vector2(MouseX, MouseY);
            velocityVector = mousePos - circleVector;
            float speed = velocityVector.magnitude;

            if (speed > maxSpeed)
            {
                speed = maxSpeed;
            }
            velocityVector = Vector2.ClampMagnitude(velocityVector.normalized, speed * Time.deltaTime);
        }

        if (Input.GetMouseButton(0))
        {
            Line(circleVector.x, circleVector.y, MouseX, MouseY);
            velocityVector *= 1 - 4 * Time.deltaTime;
        }


        if (circleVector.x - diameter/2 < 0 || circleVector.x + diameter/2 > Width)
        {
            velocityVector.x *= -1;
        }
        if (circleVector.y - diameter/2 < 0 || circleVector.y + diameter/2 > Height)
        {
            velocityVector.y *= -1;
        }
        circleVector += velocityVector;

        Circle(circleVector.x, circleVector.y, diameter);
    }
}
