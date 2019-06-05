﻿#region  引用UnityEngine API
using UnityEngine;

#endregion
//6-5 c#練習	
public class praticle_6_5
{
   
    
    //宣告狗類別
    public class Dog
    {
        #region  宣告狗屬性欄位
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
            Debug.Log(name + ":汪汪!!!");
          
        }
        #endregion
        #region  宣告方法-動物年齡轉換
        /// <summary>
        ///轉換狗狗年齡方法
        /// </summary>
        /// <returns>狗狗年齡*7</returns>
        public int ConvertAge()
        {
            return age * 7;
        }
        #endregion
        #region  宣告方法-動物飲食速度
        /// <summary>
        /// 狗吃東西的方法
        /// </summary>
        /// <param name="food">食物</param>
        /// <param name="speed">速度</param>
        public void Eat(string food,string speed="慢")
            {
               Debug.Log(name+":"+food+";速度:"+speed);
            }
        #endregion
        #region  宣告方法-動物飲食份量
        /// <summary>
        /// 狗吃東西的方法
        /// </summary>
        /// <param name="food">食物</param>
        /// <param name="speed">份量</param>
        public void Eat(string food, int count)
        {
            Debug.Log(name + ":" + food + ";份量:" + count);
        }
        #endregion
    }
}