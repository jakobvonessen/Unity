# Unity
Scripts I found useful for Unity 3D.
## _.cs
Contains commonly-used, time-saving functions, easily accessible anywhere in a project through _.func().
* `_.log(message)` provides a faster way to print to the console than `Debug.Log()`.
* `_.i(keycode)` allows a user to quickly check whether most keys are pressed (such as _.i("a") for the **a** key or _.i("left") for the left key, find all keycodes [here](https://docs.unity3d.com/ScriptReference/KeyCode.html)).
* `_.v(x,y,z)` is shorthand for `new Vector3(x,y,z)``
* `_.toggleRenderer(gameObject, mode)` toggles either the *GameObject* *Renderer* itself, or (if it's a parent *GameObject* with children *Renderer*s) the children *Renderer*s. Depending on *mode*, the renderer is either toggled from its previous state (-1), disabled (0), or enabled (1).
* `_.toggleRenderers(mode, gameObjects[])` uses `_.toggleRenderer()` for several *GameObjects* at once.
* `_.dSine(i, steps)`returns a sine curve (going between 0 and 1), having gone **i/steps**
* `_.dPos(i, steps, origPos, diffPos)`

<!--stackedit_data:
eyJoaXN0b3J5IjpbMTk2MTgzMzI2NCwxMTQyNTk5NDg1LC0xOD
EzNjA4MywtMTA1NzAxMzg4Nl19
-->