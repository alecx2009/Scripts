using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;


public class NewBehaviourScript : MonoBehaviour
{
    public string sceneName;
    private void OnTriggerEnter(Collider other)
    {
        EditorSceneManager.LoadScene(sceneName);

    }


}
