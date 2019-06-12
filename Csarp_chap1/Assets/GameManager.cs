
using UnityEngine;

public class GameManager : MonoBehaviour //必須繼承monobehaviour才能被unity物件使用
{
    public Ship ship = new Ship();  //產生ship物件
    public Ship Bigship = new Ship(90.3f, 10.7f, 7.2f,10.5f);
    void Start()//遊戲起始事件
    {
        ship.Speed = 20.5f;//寫入ship物件屬性值
        Debug.Log("第一艘船艦的速度:" + ship.Speed);//讀取物件屬性值並且列印出來
        ship.Length = 50.7f;
        Debug.Log("第一艘船艦的長度:" + ship.Length);//讀取物件屬性值並且列印出來
        ship.Width = 111.2f;// 唯讀屬性 無法寫入值
        Debug.Log("第一艘船艦的寬度:" + ship.Width);//讀取物件屬性值並且列印出來
        //Debug.Log("船艦的密碼:" + ship.PassWord); 唯寫屬性無法讀出
        Debug.Log("第一艘船艦的體積:" + ship.volume);//讀取物件屬性值並且列印出來
        Debug.Log("第一艘船艦的重量:" + ship.Weight+"公噸");//讀取物件屬性值並且列印出來
        Debug.Log("===============================" );
        //自動使用建構方式產生初始值,不須先設定資料
        Debug.Log("第二艘船艦的速度:" + Bigship.Speed);//讀取物件屬性值並且列印出來
        Debug.Log("第二艘船艦的長度:" + Bigship.Length);//讀取物件屬性值並且列印出來
        Debug.Log("第二艘船艦的寬度:" + Bigship.Width);//讀取物件屬性值並且列印出來
        Debug.Log("第二艘船艦的體積:" + Bigship.volume);//讀取物件屬性值並且列印出來
        Debug.Log("第二艘船艦的重量:" + Bigship.Weight + "公噸");//讀取物件屬性值並且列印出來
    }
}
