using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDeckController : MonoBehaviour {

    [SerializeField] GameObject deckCardPre;//deckCardPrefab


    //カード生成
    public void DeckCardList()
    {
        for (int i = 0; i < 10; i++)
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
        popup = Instantiate(popupPre, this.


}
