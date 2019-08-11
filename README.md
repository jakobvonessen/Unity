# Unity
Scripts I found useful for Unity 3D.
## _.cs
Contains commonly used, time-saving functions, easily accessible anywhere in a project through _.func(). ***Put anywhere in the project hierarchy to make it work.***
* **`_.log(message)`** provides a faster way to print to the console than `Debug.Log()`.
* **`_.i(keycode)`** allows a user to quickly check whether most keys are pressed (such as _.i("a") for the **a** key or _.i("left") for the left key, find all keycodes [here](https://docs.unity3d.com/ScriptReference/KeyCode.html)).
* **`_.v(x,y,z)`** is shorthand for `new Vector3(x,y,z)`.
* **`_.toggleRenderer(gameObject, mode)`** toggles either the *GameObject* *Renderer* itself, or (if it's a parent *GameObject* with children *Renderer*s) the children *Renderer*s. Depending on *mode*, the renderer is either toggled from its previous state (-1), disabled (0), or enabled (1). 
* **`_.toggleRenderers(mode, gameObjects[])`** uses `_.toggleRenderer()` for several *GameObjects* at once.
* **`_.dSine(i, steps)`** returns a sine curve (starting at 0, going up to 1 then returning to 0), having gone *i/steps* of the way along the x axis, giving a nice smooth curve.
* **`_.dPos(i, steps, origPos, diffPos)`** uses _.dSine() to return a Vector3 representing a point in space between (*origPos*) and (*origPos + diffPos*), that is `_.dSine(i, steps)` of the way along the two. Used for moving a *gameObject* from its original point (*origPos*) to another point (*origPos + diffPos*) during *steps* frames in a smooth fashion, like so:
    ```
	// The object to be moved is gameObject
    Vector3 origPos = gameObject.transform.position;
    Vector3 diffPos = Vector3.up * 10;
    float steps = 40;
    for(var i = 0; i < steps; i++){
        gameObject.transform.position = _.dPos(i,steps,origPos,diffPos);
        yield return new WaitForEndOfFrame();
    }
    ```
## f5.cs
Allows easy access to the `Play` button in Unity by mapping the **F5** key to it. ***Put anywhere in the project hierarchy to make it work.***

## camScript.cs
Lets a user with a 3DConnexion CAD mouse and 


<!--stackedit_data:
eyJoaXN0b3J5IjpbLTM5NjUyNzU5OCwtMjEzMDUxMTc0LC04ND
gxMzk3NzUsMTE0MjU5OTQ4NSwtMTgxMzYwODMsLTEwNTcwMTM4
ODZdfQ==
-->