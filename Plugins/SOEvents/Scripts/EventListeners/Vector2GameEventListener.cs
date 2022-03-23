using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[AddComponentMenu("Listeners/Vector2 Listener")]
public class Vector2GameEventListener : BaseGameEventListener<Vector2, Vector2GameEvent, UnityEvent<Vector2>> {}