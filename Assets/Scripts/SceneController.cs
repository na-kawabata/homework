using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour {

    public GameObject[] scenes;
    GameObject globalCanvas;

    public void ChangeScene(int id)
    {
        globalCanvas = GameObject.Find("GlobalCanvas");
        //子要素をすべて非アクティブに
        foreach (Transform transform in globalCanvas.transform)
        {
            // Transformからゲームオブジェクト取得・非表示
            var obj = transform.gameObject;
            obj.SetActive(false);
        }
        //読み込むシーンをアクティブに
        //GameObject newScene = Instantiate(scenes[id], GameObject.Find("GlobalCanvas").transform);
        string pageName = null;
        switch (id)
        {
            case 0:
                pageName = "Toppage";
                break;
            case 1:
                pageName = "Mypage";
                break;
            case 2:
                pageName = "CardList";
                break;
            default:
                break;
        }
        globalCanvas.transform.Find(pageName).gameObject.SetActive(true);


    }



}
