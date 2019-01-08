using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{

    SceneManager sceneManager;

    public void SceneChangeButton(int changeSceneId)
    {
        sceneManager = GameObject.Find("SceneManager").GetComponent<SceneManager>();
        sceneManager.ChangeScene(changeSceneId);
    }

    public void BackButton()
    {
        sceneManager.BackScene();
    }
}
