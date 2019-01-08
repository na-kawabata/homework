using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardListController : MonoBehaviour 
{
    [SerializeField] GameObject popupPre;//POPUPprefab
    [SerializeField] GameObject cardPre;//cardPrefab
    [SerializeField] GameObject cardPanel;
    GameObject popup;


    //カード生成
    public void CardList()
    {
        for (int i = 0; i<10; i++) 
        {
            GameObject obj = Instantiate(cardPre, cardPanel.transform);
        }

    }

    //カードタップ時情報ポップアップ表示
    public void TapCard()
    {
        if (popup)
        {
            Destroy(popup);
        }
        //中央にカード詳細popupを表示
        popup = Instantiate(popupPre,this.transform);
    }

}
