using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _ : MonoBehaviour {
    public static void log(float m)
    {
        Debug.Log(m);
    }
    public static void log(string m)
    {
        Debug.Log(m);
    }
    public static bool i(string character)
    {
        if (Input.GetKeyDown(character))
            return true;
        return false;
    }
}
