using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class EditorShortCutKeys : ScriptableObject
{

    [MenuItem("Edit/Run _F5")] // _Shortcut to play
    static void PlayGame()
    {
        if (!Application.isPlaying)
        {
            EditorSceneManager.SaveScene(SceneManager.GetActiveScene(), "", false);
            EditorApplication.ExecuteMenuItem("Edit/Play");
        }
    }

}