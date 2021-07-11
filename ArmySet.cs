using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ArmySet<T> : ScriptableObject
{
    public List<T> Units = new List<T>();

    public void AddUnit(T thing)
    {
        if (!Units.Contains(thing))
            Units.Add(thing);
    }

    public void RemoveUnit(T thing)
    {
        if (Units.Contains(thing))
            Units.Remove(thing);
    }

    
}
