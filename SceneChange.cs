using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
public class SceneChange : MonoBehaviour
{
    public string SceneName;

    void OnTriggerEnter()
    {
        EditorSceneManager.LoadScene(sceneName);
    }

    
}
