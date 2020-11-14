using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class Health : MonoBehaviour
{
    [SerializeField] UnityEvent onDeath;

    public void takeDamage()
    {
        onDeath.Invoke();
    }
}
