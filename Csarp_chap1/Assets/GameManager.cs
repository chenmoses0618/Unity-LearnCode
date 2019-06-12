
using UnityEngine;

public class GameManager : MonoBehaviour //必須繼承monobehaviour才能被unity物件使用
{
    public Ship ship = new Ship();  //產生ship物件
    void Start()//遊戲起始事件
    {
        ship.speed = 10.5f;//寫入ship物件屬性值
        Debug.Log("船艦的速度:" + ship.speed);//讀取物件屬性值並且列印出來
        ship.Length = 30.7f;
        Debug.Log("船艦的長度:" + ship.Length);//讀取物件屬性值並且列印出來
        //ship.Width = 111.2f; 唯讀屬性 無法寫入值
        Debug.Log("船艦的寬度:" + ship.Width);//讀取物件屬性值並且列印出來
        //Debug.Log("船艦的密碼:" + ship.PassWord); 唯寫屬性無法讀出
        Debug.Log("船艦的體積:" + ship.volume);//讀取物件屬性值並且列印出來
        Debug.Log("船艦的重量:" + ship.Weight+"公噸");//讀取物件屬性值並且列印出來
    }
}
