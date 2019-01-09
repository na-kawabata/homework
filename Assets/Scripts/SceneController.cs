using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour {

    public GameObject[] scenes;
    [SerializeField] Canvas canvas; //仮で参照で持つ→SceneManagerで生成すれば参照もFindもなしでアクセスできる？
    //private string[] sceneName = {"Toppage", "Mypage", "CardList", "Deck", "Gacha","Stage","Game","Result" };

    public void ChangeScene(int id)
    {
        //子要素をすべて削除
        foreach (Transform transform in canvas.transform)
        {
            // Transformからゲームオブジェクト取得・削除
            var obj = transform.gameObject;
            Destroy(obj);
        }
        //読み込むシーンを生成
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
            case 3:
                pageName = "Deck";
                break;
            case 4:
                pageName = "Gacha";
                break;
            case 5:
                pageName = "Stage";
                break;
            case 10:
                pageName = "Game";
                break;
            case 11:
                pageName = "Result";
                break;
            default:
                break;
        }

        // シーンプレハブを取得
        GameObject scenePre = (GameObject)Resources.Load("Scenes/"+pageName);
        // プレハブからインスタンスを生成
        Instantiate(scenePre,canvas.transform);

    }



}
