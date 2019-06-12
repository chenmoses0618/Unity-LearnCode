
using UnityEngine;

public class Ship
{
    //屬性欄位  修飾詞為public就可供給外部任意讀寫
    //prop點兩下按Tab快速產生屬性
    //成員名稱物能重複:欄位屬性方法
    public float Length { get; set; }//包含讀寫屬性get&set
                                     //public float Width { get; }    //僅有讀取屬性get
                                     //因為預設不能僅有唯寫屬性,所以一般使用上不存在
                                     // public int PassWord {set; }    //僅有唯寫set屬性
    //設定私有屬性
    //快速移動屬性 Alt+上下鍵
    private float _speed=99.5f;
    private float _Width = 6.18f;
    private float _Height = 2.5f;
    private float _volume;//可以不需要初始值
   
    //回傳封裝後私有屬性
    //封裝意義就是限制外部使用
    //public float Width{get { return _Width;  }  }
    //黏巴達運算子  [=>] 可以幫你指定運算子
    //封裝欄位 選屬性名稱 滑鼠右鍵 選[快速動作與重構]
    public float Height { get => _Height; set => _Height = value; }
    //屬性運算
    //利用封裝屬性計算屬性結果,再將結果回傳
    //如果不使用黏巴達符號,必須要在get屬性前後加上大括號
    public float volume
    {
        get {
            _volume = Length * Width * Height;
            return _volume;
        }
    }

    private float _weight;
    public float Weight
    {
        get
        {
            _weight=volume * 9.5f/1000;
            return _weight;
        }
        set => _weight = value;
    }
    //多載參數width
    public float Width { get => _Width; set => _Width = value; }
    public float Speed { get => _speed; set => _speed = value; }

    public Ship()
    {
    }
    /// <summary>
    /// 建構子:物件初始化產生之初始資料
    /// </summary>
    /// <param name="len">長度</param>
    /// <param name="wid">寬度</param>
    /// <param name="hei">高度</param>
    public Ship(float len,float wid,float hei,float spd)
    {
        Length = len;
        Width = wid;
        Height = hei;
        Speed = spd;
    }

}
