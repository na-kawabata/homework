using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDeckController : MonoBehaviour {

    [SerializeField] GameObject deckCardPre;//deckCardPrefab
    GameObject popup;

    //カード生成
    public void DeckCardList()
    {
        for (int i = 0; i < 10; i++)
        {
            //GameObject obj = Instantiate(deckCardPre, cardPanel.transform);
        }

    }

    //カードタップ時カード一覧ポップアップ表示
    public void TapDeckCard()
    {
        if (popup)
        {
            Destroy(popup);
        }
        //中央にカード一覧popupを表示
        //

    }
}
