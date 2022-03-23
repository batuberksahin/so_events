using System;
using UnityEngine;
using UnityEngine.Events;

[Serializable]
public abstract class BaseGameEventListener<TType, TGameEvent, TUnityEvent> : MonoBehaviour, IEventListener<TType>
    where TGameEvent : BaseGameEvent<TType>
    where TUnityEvent : UnityEvent<TType>
{
    public TGameEvent gameEvent;
    public TUnityEvent response;
 
    private void OnEnable() => gameEvent.RegisterListener(this);
 
    private void OnDisable() => gameEvent.UnregisterListener(this);
 
    public void RaiseEvent(TType t)
    {
        response.Invoke(t);
    }
}