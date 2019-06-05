
using UnityEngine;
[System.Serializable]
public class Warrior 
{
    public int exp;
    public int lv;
    //設定成屬性方法,透過get與set預設方法設定屬性
    public int Exp
    {
        get
        {
            return lv * 10;
        }
        set
        {
            lv= value/10;
        }
    }
}
