
using UnityEngine;

public class LandOperator : MonoBehaviour //必須繼承monobehaviour才能被unity物件使用
{
    public float a = 10f;
    public float b = 3f;
    public float c=7,d=99;
    public int E = 5;

    public bool BoolA = true;//布林值 true是 false否
    public bool BoolB = true;//布林值 true是 false否
    public bool BoolC= false;//布林值 true是 false否
    void Start()
    {
        #region 運算子練習
        //加減乘除 練習
        Debug.Log("=====基本運算======================");
        //Debug.Log()
        Debug.Log(a + b);
        Debug.Log(a - b);
        Debug.Log(a * b);
        Debug.Log(a / b);
        Debug.Log(a % b);
        Debug.Log((1+2)*3);
        Debug.Log(9/3*(1+2));
        Debug.Log("=====遞增遞減======================");
        Debug.Log("原始值c值:"+c+" 執行當下c++的回傳的c值"+(c++));//原始c=7
        Debug.Log("原始值c值:" + (c-1) + " 執行完成c++後傳出c值" + c);//遞增後c=8
        c = c - 1;
        Debug.Log("原始值c值:" + (c) + " 執行++c的回傳的c值" + (++(c)));//遞增 c=8
        c = c - 1;
        Debug.Log("原始值c值:" + (c)+"運算後先輸出的--C值" + (--c));//遞減 c=6
        Debug.Log("=====複合指派======================");
        Debug.Log(--d);
        Debug.Log(E += 7);//結果12
        Debug.Log(E -= 1);//結果11
        Debug.Log(E *= 3);//結果33
        Debug.Log(E /= 10);//結果3
        Debug.Log(E % 2);//結果1
        #endregion 
        Debug.Log("=====布林值======================");
        #region 布林運算子
        Debug.Log(BoolA);//布林值 true
        Debug.Log(!BoolA);//反向 false
        #endregion
        Debug.Log("=====邏輯運算子======================");
        #region AND運算子& 兩者真方為為真
        Debug.Log("and運算子");
        //Debug.Log(BoolA & BoolC);//真 &假
        Debug.Log("true&true="+ (true & true));   
        Debug.Log("true & false="+ (true & false));
        Debug.Log("false & true="+ (false & true));
        Debug.Log("false & false="+ (false & false));
        #endregion
        #region OR運算子|  其一為真為真
        Debug.Log("OR運算子");
        //Debug.Log(BoolA | BoolC);//真 &假
        Debug.Log("true|true=" + (true | true));
        Debug.Log("true |false=" + (true | false));
        Debug.Log("false | true=" + (false | true));
        Debug.Log("false | false=" + (false | false));
        #endregion
        #region XOR 互斥運算子^  相同為false
        Debug.Log("XOR互斥運算子");
        //Debug.Log(BoolA | BoolC);//真 &假
        Debug.Log("true ^ true=" + (true ^ true));
        Debug.Log("true ^ false=" + (true ^ false));
        Debug.Log("false ^ true=" + (false ^ true));
        Debug.Log("false ^ false=" + (false ^ false));
        #endregion
        #region 條件運算子&& 兩者真方為為真/檢查第一項為false時直接回flase
        Debug.Log("條件運算子 &&,第一個值為false就回false");
        //Debug.Log(BoolA & BoolC);//真 &假
        Debug.Log("true&&true=" + (true && true));
        Debug.Log("true && false=" + (true && false));
        Debug.Log("false && true=" + (false && true));//第一個布林值為flase救回false
        Debug.Log("false && false=" + (false && false));//第一個布林值為flase救回false
        #endregion
        #region 條件運算子||  其一為真為真/檢查第一項為true時直接回true
        Debug.Log("條件運算子||,第一個值為true就回true");
        //Debug.Log(BoolA | BoolC);//真 &假
        Debug.Log("true||true=" + (true || true));//檢查第一項為true時直接回true
        Debug.Log("true||false=" + (true || false));//檢查第一項為true時直接回true
        Debug.Log("false||true=" + (false || true));
        Debug.Log("false||false=" + (false || false));
        #endregion
    }

}
