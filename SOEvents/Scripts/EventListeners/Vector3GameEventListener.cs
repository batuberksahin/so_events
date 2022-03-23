using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[AddComponentMenu("Listeners/Vector3 Listener")]
public class Vector3GameEventListener : BaseGameEventListener<Vector3, Vector3GameEvent, UnityEvent<Vector3>> {}