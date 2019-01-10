using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListCard : MonoBehaviour
{
    [SerializeField] Text idText;
    [SerializeField] Text cardnameText;

    //カードid保持
    GameObject popup;

    //生成時の値設定
    public void Create(int id,string cardname)
    {
        this.idText.text = id.ToString();
        this.cardnameText.text = cardname;

    }



    //カードタップ時情報ポップアップ表示
    public void TapCard()
    {

        //すでに開いているポップアップを消す
        if (popup)
        {
            Destroy(popup);
        }

        //idを元に情報取得


        //ポップアップ表示
        GameObject popupPre = (GameObject)Resources.Load("Scenes/Popup");
        //表示位置
        Transform popupPosition = transform.parent.parent.transform;
        //中央にカード詳細popupを表示
        popup = Instantiate(popupPre, popupPosition);
    }
}

