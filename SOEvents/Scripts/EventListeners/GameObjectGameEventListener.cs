using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[AddComponentMenu("Listeners/GameObject Listener")]
public class GameObjectGameEventListener : BaseGameEventListener<GameObject, GameObjectGameEvent, UnityEvent<GameObject>> {}