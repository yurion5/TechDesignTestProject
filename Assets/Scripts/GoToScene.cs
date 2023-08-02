using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToScene : MonoBehaviour
{

    public void StartSceneTwo()
    {
        Application.LoadLevel("Scene_two");
    }

    public void StartSceneOne()
    {
        Application.LoadLevel("Scene_one");
    }
}
