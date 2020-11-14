using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Int", menuName = "Create int")]
public class IntSO : ScriptableObject
{
    public int value;

    public void Increment(int value)
    {
        this.value += value;
    }

    public void SetValue(int value)
    {
        this.value = value;
    }
}
