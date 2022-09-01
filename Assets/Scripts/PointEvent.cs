using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointEvent : MonoBehaviour
{
    private GameObject[] Pets;
    //����������� ����С����Ԥ����
    public GameObject[] B1s;
    //���澫����Ԥ����
    public GameObject[] B2s;
    //����ʳ��Ԥ����

    void Awake()
    {
        B1s = Resources.LoadAll<GameObject>("B1s");
        //�������еľ�����Ԥ����
        B2s = Resources.LoadAll<GameObject>("B2s");
        //�������е�ʳ��Ԥ����
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
    //����С����
    private void InsPet()
    {
        int _petIndex = Random.Range(0, Pets.Length);
        //���һ��С�������  ��Ŵ�0�� ����С����Ԥ�������������ѡ��
        Instantiate(Pets[_petIndex], transform.position, transform.rotation);
        //����С����
    }

    //���ɾ�����
    private void InsB1s()
    {
        int _ballIndex = Random.Range(0, B1s.Length);
        //�Ӿ����������л�ȡһ����������
        GameObject _ball = Instantiate(B1s[_ballIndex], transform.position + new Vector3(0, 5f, 0), transform.rotation);
        //������������������ȡ��Ӧ��Ԥ�����������
        //_ball.transform.localEulerAngles = new Vector3(-30f, 0, 0);
        //���þ�����ĽǶ�
        _ball.AddComponent<SphereCollider>();
        //������ײ�����
        _ball.GetComponent<SphereCollider>().isTrigger = true;
        //��ѡisTrigger
        _ball.GetComponent<SphereCollider>().radius = 0.011f;
        //������ײ���Ĵ�С
        _ball.AddComponent<Rigidbody>();
        //���Ӹ������
        _ball.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        //��������ϵ���������任Ч��
        //_ball.AddComponent<MoveEffect>();
        _ball.AddComponent<Ball_Find>();


    }

    //����ʳ��
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
        _food.GetComponent<BoxCollider>().size = new Vector3(0.33f, 0.30f, 0.33f);
        //������ײ���Ĵ�С
        _food.AddComponent<Rigidbody>();
        //���Ӹ������
        _food.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        //_food.AddComponent<MoveEffect>();
        _food.AddComponent<Food_Find>();

    }
}
