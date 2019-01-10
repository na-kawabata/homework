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
        //User所持カードJson
        string userCardsjson = Resources.Load<TextAsset>("Data/userCards").ToString();
        var cardlist = (CardMaster[])JsonHelper.FromJson<CardMaster>(userCardsjson);

        //カードマスタJson
        string json = Resources.Load<TextAsset>("Data/card").ToString();
        var masterList = (CardMaster[])JsonHelper.FromJson<CardMaster>(json);

        //var jsont = " {\"id\":\"1\",\"cardname\":\"aaa\",\"rarity\":\"2\"}";
        //CardMaster list = JsonUtility.FromJson<CardMaster>(jsont);
        //CardMaster list1 = (CardMaster)JsonHelper.FromJson<CardMaster>(jsont);
        //Debug.Log("jsont:"+list1);


        //カード生成
        //所持リストとマスターでidが一致するものをインスタンス化
        GameObject listCardPre = (GameObject)Resources.Load("listCard");
        for (int i = 0; i < cardlist.Length; i++)
        {
            for (int j = 0; j < masterList.Length; j++)
            {
                if (cardlist[i].id == masterList[j].id)
                {
                    GameObject obj = Instantiate(listCardPre, cardPanel.transform);
                    obj.GetComponent<ListCard>().Create(masterList[j].id,masterList[j].cardname);
                }
            }
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