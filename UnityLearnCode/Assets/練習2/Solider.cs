using UnityEngine;

public class Solider
{
    public int exp;  //經驗值
    public int lv;   //等級
    /// <summary>
    /// 設定經驗值,計算經驗值=等級x10
    /// </summary>
    /// <returns>回傳計算後經驗值</returns>
    public int GetExp()
    {
        exp = lv * 10;
        return exp;
    }
    /// <summary>
    /// 設定經驗值
    /// </summary>
    /// <param name="getExp">取得經驗值</param>
    public void SetExp(int  getExp)
    {
        exp = getExp;
    }
}
