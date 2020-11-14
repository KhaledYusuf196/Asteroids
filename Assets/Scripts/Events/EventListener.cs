using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventListener : MonoBehaviour
{
    [SerializeField] EventSystem_SO eventSO;
    [SerializeField] UnityEvent unityEvent;

    private void OnEnable()
    {
        eventSO.AddListener(this);
    }

    private void OnDisable()
    {
        eventSO.RemoveListener(this);
    }

    public void Invoke()
    {
        unityEvent.Invoke();
    }
}
