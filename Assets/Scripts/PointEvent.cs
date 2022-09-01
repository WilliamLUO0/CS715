using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointEvent : MonoBehaviour
{
    private GameObject[] Pets;
    //申请数组变量 储存小精灵预制体
    public GameObject[] B1s;
    //储存精灵球预制体
    public GameObject[] B2s;
    //储存食物预制体

    void Awake()
    {
        B1s = Resources.LoadAll<GameObject>("B1s");
        //加载所有的精灵球预制体
        B2s = Resources.LoadAll<GameObject>("B2s");
        //加载所有的食物预制体
        Pets = Resources.LoadAll<GameObject>("Pets");
    }

    // Start is called before the first frame update
    //void Start()
    //{
    //    int _randomEvent = Random.Range(0, 100);  //0-99
    //    if (_randomEvent < 40)
    //    {
    //        InsB1();
    //    }
    //    else if (_randomEvent < 70)
    //    {
    //        InsB2();
    //    }
    //    else if (_randomEvent < 90)
    //    {
    //        InsPet();
    //    }
    //    else if (_randomEvent < 99)
    //    {
    //        InsB4();
    //    }
    //    else
    //    {
    //        InsB5();
    //    }
    //}

    void Start()
    {
        int _randomEvent = Random.Range(0, 3);
        if (_randomEvent == 0)
        {
            InsPet();
        }
        else if (_randomEvent == 1)
        {
            InsB1s();
        }
        else if (_randomEvent == 2)
        {
            InsB2s();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //生成小精灵
    private void InsPet()
    {
        int _petIndex = Random.Range(0, Pets.Length);
        //随机一个小精灵序号  序号从0到 所有小精灵预制体数量中随机选择
        Instantiate(Pets[_petIndex], transform.position, transform.rotation);
        //生成小精灵
    }

    //生成精灵球
    private void InsB1s()
    {
        int _ballIndex = Random.Range(0, B1s.Length);
        //从精灵球总数中获取一个随机的序号
        GameObject _ball = Instantiate(B1s[_ballIndex], transform.position + new Vector3(0, 5f, 0), transform.rotation);
        //根据随机序号在数组中取对应的预制体进行生成
        //_ball.transform.localEulerAngles = new Vector3(-30f, 0, 0);
        //设置精灵球的角度
        _ball.AddComponent<SphereCollider>();
        //增加碰撞器组件
        _ball.GetComponent<SphereCollider>().isTrigger = true;
        //勾选isTrigger
        _ball.GetComponent<SphereCollider>().radius = 0.011f;
        //设置碰撞器的大小
        _ball.AddComponent<Rigidbody>();
        //增加刚体组件
        _ball.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        //冻结刚体上的所有物理变换效果
        //_ball.AddComponent<MoveEffect>();
        _ball.AddComponent<Ball_Find>();


    }

    //生成食物
    private void InsB2s()
    {
        int _foodIndex = Random.Range(0, B2s.Length);
        GameObject _food = Instantiate(B2s[_foodIndex], transform.position + new Vector3(0, 5f, 0), transform.rotation);
        _food.AddComponent<BoxCollider>();
        //增加碰撞器组件
        _food.GetComponent<BoxCollider>().isTrigger = true;
        //勾选isTrigger
        _food.GetComponent<BoxCollider>().center = new Vector3(0, 0, 0);
        //设置碰撞器的位置
        _food.GetComponent<BoxCollider>().size = new Vector3(0.33f, 0.30f, 0.33f);
        //设置碰撞器的大小
        _food.AddComponent<Rigidbody>();
        //增加刚体组件
        _food.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        //_food.AddComponent<MoveEffect>();
        _food.AddComponent<Food_Find>();

    }
}
