using UnityEngine;

public class gameManager : MonoBehaviour
{
    public Solider SoldierA = new Solider();
    //起始點
    void Start()
    { 

        SoldierA.lv = 30;
        Debug.Log("士兵經驗值-取得:" + SoldierA.GetExp());
        SoldierA.SetExp(100);
        Debug.Log("士兵經驗值-設定:" + SoldierA.exp);
    }
 
}
