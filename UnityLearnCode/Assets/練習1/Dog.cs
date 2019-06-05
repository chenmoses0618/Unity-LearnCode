#region  引用UnityEngine API
using UnityEngine;

#endregion
//6-5 c#練習	
public class Dog
{
    //序列化 使unity能夠在屬性面板顯示dog類別的公開屬性
    [System.Serializable]
    //宣告狗類別

        #region  宣告狗屬性欄位
        public string name;
        public float weight;
        public string kind;
        public string color;
        private int age;
        private string sex;
        #endregion
        //建構函式 與類別同名 無回傳值
        public Dog(string sex,int age=1)
        {
            this.sex = sex;
            this.age = age;
        }
        public Dog()
        {
        }
        #region  宣告方法-動物叫聲(無回傳值)
        public void Bark()
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
        public void Eat(string food, string speed = "慢")
        {
            Debug.Log(name + ":" + food + ";速度:" + speed);
        }
        #endregion
        #region  宣告方法-動物飲食份量
        /// <summary>
        /// 狗吃東西的方法
        /// </summary>
        /// <param name="food">食物</param>
        /// <param name="count">份量</param>
        public void Eat(string food, int count)
        {
            Debug.Log(name + ":" + food + ";份量:" + count);
        }
        #endregion
    
}