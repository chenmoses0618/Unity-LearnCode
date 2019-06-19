
using UnityEngine;
[System.Serializable]//類別序列化:顯示屬性面板
public class Card
{
    #region 封裝所隱藏之私有變數
    private int _cardNum;//私有卡牌數字
    private float _hposition;//私有水平位置
    private Sprite _cardPic;//私有卡面圖片
    #endregion
    #region 封裝卡牌之讀寫屬性
    public int CardNum { get => _cardNum; }
    public float CardHposition { get => _hposition; set => _hposition = value; }
    public Sprite CardPic { get => _cardPic; }
    #endregion
    #region 自訂建構子寫入參數(卡牌數字,牌之水平位置,牌面圖片),並建立卡片物件載入初始玩家與電腦牌面
    public Card(int card_num,float card_hpostion,Sprite card_pic,string player)
    {
        #region 傳入建構子讀取變數寫入私有變數
        _cardNum = card_num;
        _hposition = card_hpostion;
        _cardPic= card_pic;
        #endregion
        #region 建立Unity之遊戲物件,物件名稱名為"卡片",將現有之圖片放入遊戲物件病毒取圖片之花紋與位置
        GameObject Card = new GameObject(player);//Unity Api遊戲物件名稱
        Card.AddComponent<SpriteRenderer>();//泛型必須透過<類型>添加元件;在Unity顯示兩張卡片物件,用以顯示卡片物件
        Card.GetComponent<SpriteRenderer>().sprite=CardPic;//卡片取得圖片元件cardpic之屬性
        Card.GetComponent<Transform>().position = new Vector2(CardHposition, 0);//卡片物件添加位置
        #endregion
    }
    #endregion



}
