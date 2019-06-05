using UnityEngine;


public class DogManger:MonoBehaviour
{
    public Dog DogA = new Dog("公",7);
    public Dog DogB = new Dog("母",3);
    public Dog DogC = new Dog("母");
    public Dog DogD= new Dog();
    #region  unity起始事件
    private void Start()
    {
        DogA.name = "小黃";
        DogA.weight = 20.5f;
        DogA.kind = "貴賓";
        //DogA.sex = "公";
        DogA.color = "咖啡";
        //DogA.age = 7;

        DogB.name = "小黑";
        DogB.weight = 15.5f;
        DogB.kind = "吉娃娃";
        //DogB.sex = "母";
        DogB.color = "白";
        //DogB.age = 3;
        Debug.Log(DogA.name + "品種:" + DogA.kind + "顏色:" + DogA.color);
        Debug.Log(DogB.name + "品種:" + DogB.kind + "顏色:" + DogB.color);
        DogA.Bark();
        DogB.Bark();
        Debug.Log(DogA.name + "的實際年齡:" + DogA.ConvertAge());
        Debug.Log(DogB.name + "的實際年齡:" + DogB.ConvertAge());
        DogA.Eat("熱狗");
        DogA.Eat("蛋糕",10);
    }
    #endregion
}
