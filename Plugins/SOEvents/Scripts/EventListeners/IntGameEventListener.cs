using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[AddComponentMenu("Listeners/Integer Listener")]
public class IntGameEventListener : BaseGameEventListener<int, IntGameEvent, UnityEvent<int>> {}