using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointEvent : MonoBehaviour
{
    //private GameObject[] Pets;
    public GameObject[] B1s;
    public GameObject[] B2s;
    public GameObject[] B3s;
    //public GameObject[] B4s;
    //public GameObject[] B5s;
    private char itemlevel;

    void Awake()
    {
        B1s = Resources.LoadAll<GameObject>("B1s");
        B2s = Resources.LoadAll<GameObject>("B2s");
        B3s = Resources.LoadAll<GameObject>("B3s");
        //B4s = Resources.LoadAll<GameObject>("B4s");
        //B5s = Resources.LoadAll<GameObject>("B5s");
        //Pets = Resources.LoadAll<GameObject>("Pets");
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

    //void Start()
    //{
    //    int _randomEvent = Random.Range(0, 6);
    //    if (_randomEvent == 0)
    //    {
    //        InsPet();
    //    }
    //    else if (_randomEvent == 1)
    //    {
    //        InsB1s();
    //    }
    //    else if (_randomEvent == 2)
    //    {
    //        InsB2s();
    //    }
    //    else if (_randomEvent == 3)
    //    {
    //        InsB3s();
    //    }
    //    else if (_randomEvent == 4)
    //    {
    //        InsB4s();
    //    }
    //    else if (_randomEvent == 5)
    //    {
    //        InsB5s();
    //    }
    //}

    void Start()
    {
        itemlevel = LevelMechanism.Instance.getCurrentItemLevel();
        int _randomEvent = Random.Range(0, 10);
        if ('C'.CompareTo(itemlevel) == 0)
        {
            InsB1s();
        }
        if ('B'.CompareTo(itemlevel) == 0)
        {
            if (_randomEvent < 3)
            {
                InsB1s();
            }
            else
            {
                InsB2s();
            }
        }
        if ('A'.CompareTo(itemlevel) == 0)
        {
            if (_randomEvent < 2)
            {
                InsB1s();
            }
            else if (_randomEvent < 5)
            {
                InsB2s();
            }
            else
            {
                InsB3s();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    ////生成小精灵
    //private void InsPet()
    //{
    //    int _petIndex = Random.Range(0, Pets.Length);
    //    //随机一个小精灵序号  序号从0到 所有小精灵预制体数量中随机选择
    //    Instantiate(Pets[_petIndex], transform.position, transform.rotation);
    //    //生成小精灵
    //}

    private void InsB1s()
    {
        int _ballIndex = Random.Range(0, B1s.Length);
        GameObject _food = Instantiate(B1s[_ballIndex], transform.position + new Vector3(0, 5f, 0), transform.rotation);
        //根据随机序号在数组中取对应的预制体进行生成
        //_ball.transform.localEulerAngles = new Vector3(-30f, 0, 0);
        //设置角度
        _food.AddComponent<BoxCollider>();
        //增加碰撞器组件
        _food.GetComponent<BoxCollider>().isTrigger = true;
        //勾选isTrigger
        _food.GetComponent<BoxCollider>().center = new Vector3(0, 0, 0);
        //设置碰撞器的位置
        _food.GetComponent<BoxCollider>().size = new Vector3(5.6f, 8.4f, 5.6f);
        //设置碰撞器的大小
        _food.AddComponent<Rigidbody>();
        //增加刚体组件
        _food.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        //冻结刚体上的所有物理变换效果
        //_ball.AddComponent<MoveEffect>();
        _food.AddComponent<B1_Find>();


    }

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
        _food.GetComponent<BoxCollider>().size = new Vector3(5.6f, 8.4f, 5.6f);
        //设置碰撞器的大小
        _food.AddComponent<Rigidbody>();
        //增加刚体组件
        _food.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        //_food.AddComponent<MoveEffect>();
        _food.AddComponent<B2_Find>();

    }

    private void InsB3s()
    {
        int _foodIndex = Random.Range(0, B3s.Length);
        GameObject _food = Instantiate(B3s[_foodIndex], transform.position + new Vector3(0, 5f, 0), transform.rotation);
        _food.AddComponent<BoxCollider>();
        //增加碰撞器组件
        _food.GetComponent<BoxCollider>().isTrigger = true;
        //勾选isTrigger
        _food.GetComponent<BoxCollider>().center = new Vector3(0, 0, 0);
        //设置碰撞器的位置
        _food.GetComponent<BoxCollider>().size = new Vector3(5.6f, 8.4f, 5.6f);
        //设置碰撞器的大小
        _food.AddComponent<Rigidbody>();
        //增加刚体组件
        _food.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        //_food.AddComponent<MoveEffect>();
        _food.AddComponent<B3_Find>();

    }

    //private void InsB4s()
    //{
    //    int _foodIndex = Random.Range(0, B4s.Length);
    //    GameObject _food = Instantiate(B4s[_foodIndex], transform.position + new Vector3(0, 5f, 0), transform.rotation);
    //    _food.AddComponent<BoxCollider>();
    //    //增加碰撞器组件
    //    _food.GetComponent<BoxCollider>().isTrigger = true;
    //    //勾选isTrigger
    //    _food.GetComponent<BoxCollider>().center = new Vector3(0, 0, 0);
    //    //设置碰撞器的位置
    //    _food.GetComponent<BoxCollider>().size = new Vector3(5.6f, 8.4f, 5.6f);
    //    //设置碰撞器的大小
    //    _food.AddComponent<Rigidbody>();
    //    //增加刚体组件
    //    _food.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
    //    //_food.AddComponent<MoveEffect>();
    //    _food.AddComponent<B4_Find>();

    //}

    //private void InsB5s()
    //{
    //    int _foodIndex = Random.Range(0, B5s.Length);
    //    GameObject _food = Instantiate(B5s[_foodIndex], transform.position + new Vector3(0, 5f, 0), transform.rotation);
    //    _food.AddComponent<BoxCollider>();
    //    //增加碰撞器组件
    //    _food.GetComponent<BoxCollider>().isTrigger = true;
    //    //勾选isTrigger
    //    _food.GetComponent<BoxCollider>().center = new Vector3(0, 0, 0);
    //    //设置碰撞器的位置
    //    _food.GetComponent<BoxCollider>().size = new Vector3(5.6f, 8.4f, 5.6f);
    //    //设置碰撞器的大小
    //    _food.AddComponent<Rigidbody>();
    //    //增加刚体组件
    //    _food.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
    //    //_food.AddComponent<MoveEffect>();
    //    _food.AddComponent<B5_Find>();

    //}
}
