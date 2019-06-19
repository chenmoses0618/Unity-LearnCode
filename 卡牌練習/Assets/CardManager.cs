using UnityEngine;

public class CardManager : MonoBehaviour
{
    #region 宣告卡牌玩家 與卡牌主機
    public Card CardPlayer ,CardPC;
    #endregion
    #region 宣告卡牌花紋
    //public Sprite Image9, Image3;
    //public Sprite Image0, Image1, Image2, Image4, Image5, Image6, Image7, Image8;
    public Sprite[] images;
    #endregion
    #region 宣告文字提示文字
    public TextMesh tip;
    public TextMesh start;
    #endregion 
    
    void Start()  //unity C#主程式入口
    {
        int rplayer = Random.Range(0, 10);
        int rpc = Random.Range(0, 10);
        // Debug.Log("玩家隨機值:" + rplayer);
        #region 初始玩家在左位置-5 電腦在右位置5 玩家牌面9  電腦牌面3,牌面花紋套用圖片
        CardPlayer = new Card(rplayer, -5, images[rplayer],"玩家卡片");
        CardPC = new Card(rpc, 5, images[rpc],"電腦卡片");
        #endregion
        # region 顯示提示比較勝負文字內容
        if (CardPlayer.CardNum > CardPC.CardNum)
        {
           tip.text = "玩家勝";
        }
        else if( CardPlayer.CardNum < CardPC.CardNum)
        {
            tip.text = "電腦勝";
        }
        else{
            tip.text = "平手";
        }

        tip.fontSize = 100;
        tip.color = Color.red;
        #endregion
    }

    void Update()
    {
        if (Input.anyKeyDown)
        {

            Start();
        }
    }

}

