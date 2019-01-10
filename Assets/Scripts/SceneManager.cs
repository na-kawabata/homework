using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//現在どのページを表示しているか
//ページの履歴保持
public class SceneManager : MonoBehaviour
{

    private static SceneManager mInstance;
    private int sceneId = 0; //現在のシーンID


    //BackHistry 
    Stack<int> historyStack = new Stack<int>();
    //SceneController
    SceneController sceneController;


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
        historyStack.Push(getSceneId());
        setSceneId(id);
        this.GetComponent<SceneController>().ChangeScene(id);
       
    }


    //シーンバック
    public void BackScene()
    {
       
        if (historyStack.Peek() != null)
        {
            int backSceneId = historyStack.Pop();
            setSceneId(backSceneId);
            sceneController.ChangeScene(backSceneId);
        }
        else return;
       
    }

}

//シングルトンクラスのインスタンスの唯一性確保について、
//ひとまずコンストラクタをプライベート化＋インスタンス格納変数をスタティックにして
//起動直後にのみインスタンス生成されるようにすればok