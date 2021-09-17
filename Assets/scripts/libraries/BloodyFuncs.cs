using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodyFuncs
{
    public Vector2 AngleMagnitudeToVector2(float angleInDegrees, float magnitude)
    {
        float x = Mathf.Sin(angleInDegrees) * magnitude;
        float y = Mathf.Cos(angleInDegrees) * magnitude;
        return new Vector2(x, y);
    }
}
