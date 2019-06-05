#region  引用unity API
using UnityEngine;

#endregion
//5-29 c#練習	
public class praticle_6_5
{
   
    
    //宣告狗類別
    public class Dog
    {
        #region  宣告屬性欄位
        public string name;
        public float weight;
        public string kind;
        public string sex;
        public string color;
        public int age;
        #endregion
        #region  宣告方法-動物叫聲(無回傳值)
        public void voice()
        {
            Debug.Log(name + ":汪汪");
          
        }
        #endregion

        
    }
}