using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[AddComponentMenu("Listeners/Transform Listener")]
public class TransformGameEventListener : BaseGameEventListener<Transform, TransformGameEvent, UnityEvent<Transform>> {}