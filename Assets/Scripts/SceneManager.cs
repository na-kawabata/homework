using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{

    private static SceneManager mInstance;
    private int sceneId = 0; //シーンID


    //BackHistry 
    Stack<int> historyStack = new Stack<int>();

    //SceneController
    public GameObject sceneController;

    //インスタンスが存在しなければ作る
    public static SceneManager Instance
    {
        get
        {
            if (mInstance == null)
            {
                GameObject obj = new GameObject("SceneManager");
                mInstance = obj.AddComponent<SceneManager>();
            }
            return mInstance;
        }
        set
        {

        }
    }

    public void setSceneId(int n)
    {
        this.sceneId = n;
    }

    public int getSceneId()
    {
        return this.sceneId;
    }





    ///ここから個別の機能


    //シーン遷移処理
    public void ChangeScene(int id)
    {
        sceneController.GetComponent<SceneController>().ChangeScene(id);

    }


    //シーンバック
    public void BackScene()
    {
        //historyから取得して削除
        //Console.WriteLine(stack.Pop());
    }

}

//シングルトンクラスのインスタンスの唯一性確保について、
//ひとまずコンストラクタをプライベート化＋インスタンス格納変数をスタティックにして
//起動直後にのみインスタンス生成されるようにすればok