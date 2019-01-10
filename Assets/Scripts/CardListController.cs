using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardListController : MonoBehaviour 
{
    [SerializeField] GameObject cardPanel;
    GameObject popup;

    //カードリスト生成
    public void Start()
    {
        //テスト　json取得
        //Jsonファイル読み込み
        string json = Resources.Load<TextAsset>("Data/card").ToString();

        Debug.Log(json);//ok

       //var jsont = " {\"id\":\"1\",\"cardname\":\"aaa\",\"rarity\":\"2\"}";
        //CardMaster list = JsonUtility.FromJson<CardMaster>(jsont);
        //CardMaster list1 = (CardMaster)JsonHelper.FromJson<CardMaster>(jsont);
        //Debug.Log("jsont:"+list1);

        var list = (CardMaster[])JsonHelper.FromJson<CardMaster>(json);



        //Debug.Log(list);
        //取得テスト
        for (int i = 0; i < list.Length; i++)
        {
            Debug.Log(list[i].id);
        }



        //カード生成
        GameObject listCardPre = (GameObject)Resources.Load("listCard");
        for (int i = 0; i<10; i++) 
        {
            GameObject obj = Instantiate(listCardPre, cardPanel.transform);
        }

    }

    //popup生成
    public void CardStatusView()
    {

        //すでに開いているポップアップを消す
        if (popup)
        {
            Destroy(popup);
        }

        //idを元にカード情報取得
        //カードマスタクラス生成


        //ポップアップ表示
        GameObject popupPre = (GameObject)Resources.Load("Scenes/Popup");
        //表示位置
        Transform popupPosition = this.transform;
        //中央にカード詳細popupを表示
        popup = Instantiate(popupPre, popupPosition);
       //UI要素にカード情報をセット
    }


}

[System.Serializable]
class CardMaster
{
    public int id;
    public string cardname;
    public string rarity;
}
