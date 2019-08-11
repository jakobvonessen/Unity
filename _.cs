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

    public static Vector3 v(float x, float y, float z)
    {
        return new Vector3(x, y, z);
    }

    public static void toggleRenderers(int mode = -1, params GameObject[] gos)
    {
        foreach (GameObject go in gos)
            toggleRenderer(go, mode);
    }

    public static void toggleRenderer(GameObject go, int mode = -1)
    {
        Renderer[] rs = go.GetComponentsInChildren<Renderer>();
        if(rs.Length > 0)
        {
            foreach(Renderer r in rs)
                r.enabled = (mode == 1) ? true : (mode == 0) ? false : !r.enabled;
        } else
        {
            Renderer r = go.GetComponent<Renderer>();
            r.enabled = (mode == 1) ? true : (mode == 0) ? false : !r.enabled;
        }
    }

    public static Vector3 dPos(float i, float steps, Vector3 oPos, Vector3 diffPos, bool reverse = false)
    {
        if (reverse)
            i = steps - i;
        return oPos + diffPos * dSine(i, steps);
    }

    public static float dSine(float i, float steps)
    {
        return ((1 - (Mathf.Cos(i / steps * Mathf.PI))) / 2);
    }
}
