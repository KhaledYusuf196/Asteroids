using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Event", menuName ="Create Event")]
public class EventSystem_SO : ScriptableObject
{
    List<EventListener> listeners;
    [TextArea] public string Description;

    public void AddListener(EventListener listener)
    {
        listeners.Add(listener);
    }

    public void RemoveListener(EventListener listener)
    {
        listeners.Remove(listener);
    }

    public void Fire()
    {
        foreach(var listener in listeners)
        {
            listener.Invoke();
        }
    }
}
