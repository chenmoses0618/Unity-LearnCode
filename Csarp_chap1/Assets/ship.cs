
using UnityEngine;

public class Ship
{
    //屬性欄位  修飾詞為public就可供給外部任意讀寫
    public float speed;
    //prop點兩下按Tab快速產生屬性
    //成員名稱物能重複:欄位屬性方法
    public float Length { get; set; }//包含讀寫屬性get&set
                                     //public float Width { get; }    //僅有讀取屬性get
                                     //因為預設不能僅有唯寫屬性,所以一般使用上不存在
                                     // public int PassWord {set; }    //僅有唯寫set屬性
    //設定私有屬性
    private float _Width = 6.18f;
    //回傳封裝後私有屬性
    public float Width{get { return _Width; }}

}
