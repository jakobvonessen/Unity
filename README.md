# Unity
Scripts I found useful for Unity 3D.
## _.cs
Contains commonly-used, time-saving functions, easily accessible anywhere in a project through _.func().
* `_.log(string/float)` provides a faster way to print to the console than `Debug.Log()`.
* `_.i(string)` allows a user to quickly check whether most keys are pressed (such as _.i("a") for the **a** key or _.i("left") for the left key, find all keycodes [here](https://docs.unity3d.com/ScriptReference/KeyCode.html)).
* `_.v(float, float, float)` is shorthand for `new Vector3(float, float, float)``
* `_.toggleRenderer(GameObject, int)` 
* `_.toggleRenderers(int, GameObject[])` uses `_.toggleRenderer()` for several *GameObjects* at once.
* `_.dPos(float, float, Vector3, Vector3, [bool])`
* `_.dSine(float, float)`
<!--stackedit_data:
eyJoaXN0b3J5IjpbLTE1Nzk0NzY5NjUsLTE4MTM2MDgzLC0xMD
U3MDEzODg2XX0=
-->