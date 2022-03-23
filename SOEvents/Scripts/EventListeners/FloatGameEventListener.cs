using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[AddComponentMenu("Listeners/Float Listener")]
public class FloatGameEventListener : BaseGameEventListener<float, FloatGameEvent, UnityEvent<float>> {}