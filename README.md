# ScriptableObject Event System 
Primitive ScriptableObject event system for handling events in easy way with UnityEvents.

## Install
Add this line to your manifest.json at `Packages/` folder in your project. 

    "com.batuberksahin.soevents": "https://github.com/batuberksahin/so_events.git"

## How to use
SO_events package contains several types of events. For example, Integer Event takes an integer as a parameter.

These are
- String
 - Float
 - Integer
 - GameObject
 - Transform
 - Vector2
 - Vector3

You can add events from create tab in **Assets** window.

![Event Types](https://i.ibb.co/4gqW23C/assets-so.png)

![Example Events](https://i.ibb.co/ZTzNDY7/events.png)

----------
Also there are equivalent event listeners in the package, so you can add UnityEvents to your custom events.
You can add Event Listeners to an object from **Add Component/Listeners** tab.

![Event Listener Components](https://i.ibb.co/s19TgjL/integer-listener.png)

----------
**Example Usage of Custom Events**

![enter image description here](https://i.ibb.co/BzQsc6G/example-usage.png)

Trigger this event;

```csharp
public class GameManager : MonoBehaviour {
	public IntGameEvent onGameOpen;  
  
	private void Start()  
	{  
		onGameOpen.Raise(0);  
	}
}
```

## LICENSE
MIT
