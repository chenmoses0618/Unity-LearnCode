
using UnityEngine;

public class Card
{
    #region 封裝所隱藏之私有變數
    private int _cardNum;
    private float _hposition;
    private Sprite _cardPic;
    #endregion
    #region 封裝卡牌之讀寫屬性
    public int CardNum { get => _cardNum; }
    public float CardHposition { get => _hposition; set => _hposition = value; }
    public Sprite CardPic { get => _cardPic; }
    #endregion
    #region 自訂建構子寫入參數(卡牌數字,牌之水平位置,牌面圖片)
    public Card(int card_num,float card_hpostion,Sprite card_pic)
    {
        _cardNum = card_num;
        CardHposition = card_hpostion;
        _cardPic= card_pic;

    }
    #endregion
    #region 多載空白建構子-無參數
    public Card()
    {
    }
    #endregion

}
