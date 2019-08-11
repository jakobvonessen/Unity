using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SpaceNavigatorDriver;

public class camScript : MonoBehaviour
{
    // Update is called once per frame

    Text debugText;
    public bool debug;
    public static bool active = true;

    void Update()
    {
        debugText = GameObject.Find("Canvas").GetComponentInChildren<Text>();
        if(active)
            navigateInSpace();
    }

    void navigateInSpace()
    {
        float moveSpeed = (debug) ? 1f : .4f;
        float rotSpeed = 2f;
        transform.Translate(moveSpeed * SpaceNavigator.Translation, Space.Self);
        transform.Rotate(Vector3.up, rotSpeed * SpaceNavigator.Rotation.Yaw() * Mathf.Rad2Deg, Space.World);
        transform.Rotate(Vector3.right, rotSpeed * SpaceNavigator.Rotation.Pitch() * Mathf.Rad2Deg, Space.Self);
        transform.Rotate(Vector3.forward, rotSpeed * SpaceNavigator.Rotation.Roll() * Mathf.Rad2Deg, Space.Self);
        if (debug)
            debugText.text = "Pos: " + transform.position.ToString() + "\nRot: " + transform.eulerAngles.ToString();
        else
            debugText.text = "";
    }
}
