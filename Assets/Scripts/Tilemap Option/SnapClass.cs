using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapClass
{
    public static Vector3 Snap(Vector3 pos, int v)
    {
        float x = pos.x;
        float y = pos.y;
        float z = pos.z;
        x = Mathf.FloorToInt(x / v) * v;
        y = Mathf.FloorToInt(y / v) * v;
        z = Mathf.FloorToInt(z / v) * v;
        return new Vector3(x, y, z);
    }

    public static int Snap(int pos, int v)
    {
        float x = pos;
        return Mathf.FloorToInt(x / v) * v;
    }

    public static float Snap(float pos, float v)
    {
        float x = pos;
        return Mathf.FloorToInt(x / v) * v;
    }
}
