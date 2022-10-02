using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointEvent : MonoBehaviour
{
    //private GameObject[] Pets;
    public GameObject[] B1s;
    public GameObject[] B2s;
    public GameObject[] B3s;
    public bool lossAversion = false;
    //public GameObject[] B4s;
    //public GameObject[] B5s;
    private char itemlevel;
    private int levelBSpawnProbability;
    private int levelCSpawnProbability;

    void Awake()
    {
        B1s = Resources.LoadAll<GameObject>("B1s");
        B2s = Resources.LoadAll<GameObject>("B2s");
        B3s = Resources.LoadAll<GameObject>("B3s");
        //B4s = Resources.LoadAll<GameObject>("B4s");
        //B5s = Resources.LoadAll<GameObject>("B5s");
        //Pets = Resources.LoadAll<GameObject>("Pets");

        if (lossAversion) {
            // level A spawn probability = 7
            levelBSpawnProbability = 2;
            levelCSpawnProbability = 1;
        } else {
            // level A spawn probability = 5
            levelBSpawnProbability = 3;
            levelCSpawnProbability = 2;
        }
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
            if (_randomEvent < levelCSpawnProbability)
            {
                InsB1s();
            }
            else if (_randomEvent < levelBSpawnProbability)
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
    ////����С����
    //private void InsPet()
    //{
    //    int _petIndex = Random.Range(0, Pets.Length);
    //    //���һ��С�������  ��Ŵ�0�� ����С����Ԥ�������������ѡ��
    //    Instantiate(Pets[_petIndex], transform.position, transform.rotation);
    //    //����С����
    //}

    private void InsB1s()
    {
        int _ballIndex = Random.Range(0, B1s.Length);
        GameObject _food = Instantiate(B1s[_ballIndex], transform.position + new Vector3(0, 5f, 0), transform.rotation);
        //������������������ȡ��Ӧ��Ԥ�����������
        //_ball.transform.localEulerAngles = new Vector3(-30f, 0, 0);
        //���ýǶ�
        _food.AddComponent<BoxCollider>();
        //������ײ�����
        _food.GetComponent<BoxCollider>().isTrigger = true;
        //��ѡisTrigger
        _food.GetComponent<BoxCollider>().center = new Vector3(0, 0, 0);
        //������ײ����λ��
        _food.GetComponent<BoxCollider>().size = new Vector3(5.6f, 8.4f, 5.6f);
        //������ײ���Ĵ�С
        _food.AddComponent<Rigidbody>();
        //���Ӹ������
        _food.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        //��������ϵ����������任Ч��
        //_ball.AddComponent<MoveEffect>();
        _food.AddComponent<B1_Find>();


    }

    private void InsB2s()
    {
        int _foodIndex = Random.Range(0, B2s.Length);
        GameObject _food = Instantiate(B2s[_foodIndex], transform.position + new Vector3(0, 5f, 0), transform.rotation);
        _food.AddComponent<BoxCollider>();
        //������ײ�����
        _food.GetComponent<BoxCollider>().isTrigger = true;
        //��ѡisTrigger
        _food.GetComponent<BoxCollider>().center = new Vector3(0, 0, 0);
        //������ײ����λ��
        _food.GetComponent<BoxCollider>().size = new Vector3(5.6f, 8.4f, 5.6f);
        //������ײ���Ĵ�С
        _food.AddComponent<Rigidbody>();
        //���Ӹ������
        _food.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        //_food.AddComponent<MoveEffect>();
        _food.AddComponent<B2_Find>();

    }

    private void InsB3s()
    {
        int _foodIndex = Random.Range(0, B3s.Length);
        GameObject _food = Instantiate(B3s[_foodIndex], transform.position + new Vector3(0, 5f, 0), transform.rotation);
        _food.AddComponent<BoxCollider>();
        //������ײ�����
        _food.GetComponent<BoxCollider>().isTrigger = true;
        //��ѡisTrigger
        _food.GetComponent<BoxCollider>().center = new Vector3(0, 0, 0);
        //������ײ����λ��
        _food.GetComponent<BoxCollider>().size = new Vector3(5.6f, 8.4f, 5.6f);
        //������ײ���Ĵ�С
        _food.AddComponent<Rigidbody>();
        //���Ӹ������
        _food.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        //_food.AddComponent<MoveEffect>();
        _food.AddComponent<B3_Find>();

    }

    //private void InsB4s()
    //{
    //    int _foodIndex = Random.Range(0, B4s.Length);
    //    GameObject _food = Instantiate(B4s[_foodIndex], transform.position + new Vector3(0, 5f, 0), transform.rotation);
    //    _food.AddComponent<BoxCollider>();
    //    //������ײ�����
    //    _food.GetComponent<BoxCollider>().isTrigger = true;
    //    //��ѡisTrigger
    //    _food.GetComponent<BoxCollider>().center = new Vector3(0, 0, 0);
    //    //������ײ����λ��
    //    _food.GetComponent<BoxCollider>().size = new Vector3(5.6f, 8.4f, 5.6f);
    //    //������ײ���Ĵ�С
    //    _food.AddComponent<Rigidbody>();
    //    //���Ӹ������
    //    _food.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
    //    //_food.AddComponent<MoveEffect>();
    //    _food.AddComponent<B4_Find>();

    //}

    //private void InsB5s()
    //{
    //    int _foodIndex = Random.Range(0, B5s.Length);
    //    GameObject _food = Instantiate(B5s[_foodIndex], transform.position + new Vector3(0, 5f, 0), transform.rotation);
    //    _food.AddComponent<BoxCollider>();
    //    //������ײ�����
    //    _food.GetComponent<BoxCollider>().isTrigger = true;
    //    //��ѡisTrigger
    //    _food.GetComponent<BoxCollider>().center = new Vector3(0, 0, 0);
    //    //������ײ����λ��
    //    _food.GetComponent<BoxCollider>().size = new Vector3(5.6f, 8.4f, 5.6f);
    //    //������ײ���Ĵ�С
    //    _food.AddComponent<Rigidbody>();
    //    //���Ӹ������
    //    _food.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
    //    //_food.AddComponent<MoveEffect>();
    //    _food.AddComponent<B5_Find>();

    //}
}
