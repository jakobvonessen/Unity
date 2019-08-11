# Unity
Scripts I found useful for Unity 3D.
## _.cs
Contains commonly-used, time-saving functions, easily accessible anywhere in a project through _.func().
* `_.log(message)` provides a faster way to print to the console than `Debug.Log()`.
* `_.i(keycode)` allows a user to quickly check whether most keys are pressed (such as _.i("a") for the **a** key or _.i("left") for the left key, find all keycodes [here](https://docs.unity3d.com/ScriptReference/KeyCode.html)).
* `_.v(x,y,z)` is shorthand for `new Vector3(x,y,z)``
* `_.toggleRenderer(gameObject, mode)` toggles either the *GameObject* *Renderer* itself, or (if it's a parent GameObject with children Renderers) the children *Renderers*. Depending on mode
* `_.toggleRenderers(mode, gameObjects[])` uses `_.toggleRenderer()` for several *GameObjects* at once.
* `_.dPos(i)`
* `_.dSine(float, float)`
<!--stackedit_data:
eyJoaXN0b3J5IjpbLTU3ODA5MzM0MCwtMTgxMzYwODMsLTEwNT
cwMTM4ODZdfQ==
-->