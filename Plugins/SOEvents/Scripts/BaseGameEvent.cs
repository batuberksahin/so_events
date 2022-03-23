using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public abstract class BaseGameEvent<TType> : ScriptableObject
{
    private List<IEventListener<TType>> m_Listeners = new List<IEventListener<TType>>();
    
    public void RegisterListener(IEventListener<TType> listener)
    {
        m_Listeners.Add(listener);
    }
 
    public void UnregisterListener(IEventListener<TType> listener)
    {
        m_Listeners.Remove(listener);
    }
 
    public void Raise(TType t)
    {
        for (int i = m_Listeners.Count - 1; i >= 0; --i)
        {
            m_Listeners[i].RaiseEvent(t);
        }
    }
}