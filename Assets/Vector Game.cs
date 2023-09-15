using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorGame : ProcessingLite.GP21
{
    Vector2 goal;
    float angleAccuracy = 100;
    float distanceAccuracy = 100;
    int points;
    // Start is called before the first frame update
    void Start()
    {
        points = 0;
        goal = CreateGoal();
    }

    // Update is called once per frame
    void Update()
    {
        Background(50, 166, 240);

        Stroke(0, 255, 0);
        Line(0, 0, goal.x, goal.y);

        if (Input.GetMouseButton(0))
        {
            Stroke(255, 180);
            Line(0, 0, MouseX, MouseY);
        }
        if (Input.GetMouseButtonUp(0))
        {
            Vector2 mousePos = new Vector2(MouseX, MouseY);
            float angle = Vector2.Angle(mousePos, goal);
            angleAccuracy = 100 - (angle / 180) * 100;
            angleAccuracy = Mathf.Round(angleAccuracy * 10.0f) * 0.1f;

            distanceAccuracy = Vector2.Distance(mousePos, goal);
            distanceAccuracy = Mathf.Round(distanceAccuracy * 100.0f) * 0.01f;
            distanceAccuracy = Mathf.Clamp(distanceAccuracy, 0, 1);

            float score = (angleAccuracy / 2) + (1 - distanceAccuracy) * 50;
            score = Mathf.Round(score * 10.0f) * 0.1f;
            Debug.Log(score);

            if (score > 85)
            {
                goal = CreateGoal();
                points++;
            }
        }
    }

    public Vector2 CreateGoal()
    {
        int maxX = (int)Mathf.Floor(Width);
        int randomX = Random.Range(2, maxX);

        int maxY = (int)Mathf.Floor(Height);
        int randomY = Random.Range(2, maxY);

        return new Vector2(randomX, randomY);
    }
}
