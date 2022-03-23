using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[AddComponentMenu("Listeners/String Listener")]
public class StringGameEventListener : BaseGameEventListener<string, StringGameEvent, UnityEvent<string>> {}