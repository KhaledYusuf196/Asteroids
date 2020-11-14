using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchUserInput : MonoBehaviour
{
    public static float Horizontal { get; set; }
    public static float Vertical { get; set; }

    private static bool fire;

    public static bool Fire
    {
        get {
            bool oldValue = fire;
            fire = false;
            return oldValue; 
        }
        set { fire = value; }
    }


    public void SetHorizontal(float value)
    {
        Horizontal = value;
    }
    public void SetVertical(float value)
    {
        Vertical = value;
    }

    public void SetFire(bool value)
    {
        Fire = value;
    }
}
