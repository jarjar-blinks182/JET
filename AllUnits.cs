using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllUnits<T> : ScriptableObject
{
    public List<T> Armies = new List<T>();

    public void Add(T thing)
    {
        if (!Armies.Contains(thing))
            Armies.Add(thing);
    }

    public void Remove(T thing)
    {
        if (Armies.Contains(thing))
            Armies.Remove(thing);
    }
    void OnEnable()
    {
        if (this.Armies.Count > 0)
        {
            Debug.Log("Enable: Starting with " + this.Armies.Count + " Armies. Clearing . . .");
            for (int i = this.Armies.Count-1; i >= 0; i--)
            {
                Remove(this.Armies[0]);
            }
        }
    }
}
