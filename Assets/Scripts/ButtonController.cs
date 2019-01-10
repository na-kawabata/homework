using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public void SceneChangeButton(int changeSceneId)
    {
        SceneManager.Instance.ChangeScene(changeSceneId);
    }

    public void BackButton()
    {
        SceneManager.Instance.BackScene();
    }



}
