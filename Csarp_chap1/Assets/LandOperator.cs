
using UnityEngine;

public class LandOperator : MonoBehaviour //必須繼承monobehaviour才能被unity物件使用
{
    public float a = 10f;
    public float b = 3f;
    public float c=7,d=99;
    public int E = 5;
    void Start()
    {
        #region 練習運算子
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
        #endregion
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
    }


}
