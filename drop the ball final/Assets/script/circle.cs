using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circle : MonoBehaviour
{
    // Start is called before the first frame update
    public LineRenderer circleren;
    void Start()
    {
        DrawCircle(100, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void DrawCircle(int steps, float radius)
    {
        circleren.positionCount = steps;
        for(int curentStep = 0; curentStep < steps; curentStep++)
        {
            float cirumferenceProgress = (float)curentStep / steps;
            float currentRaian = cirumferenceProgress * 2 * Mathf.PI;
            float xSacled = Mathf.Cos(currentRaian);
            float ySacled = Mathf.Sin(currentRaian);
            float x = xSacled * radius;
            float y = ySacled * radius;

            Vector3 currentPosition = new Vector3(0, x, y);
            circleren.SetPosition(curentStep, currentPosition);
        }
    }
}
