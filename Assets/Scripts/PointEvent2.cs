using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointEvent2 : MonoBehaviour
{

    private GameObject[] Pets;
    //����������� ����С����Ԥ����
    public GameObject[] Balls;
    //���澫����Ԥ����
    public GameObject[] Foods;
    //����ʳ��Ԥ����

    void Awake()
    {
        Balls = Resources.LoadAll<GameObject>("Balls");
        //�������еľ�����Ԥ����
        Foods = Resources.LoadAll<GameObject>("Foods");
        //�������е�ʳ��Ԥ����
        Pets = Resources.LoadAll<GameObject>("Pets");
    }

    // Use this for initialization
    void Start()
    {
        int _randomEvent = Random.Range(0, 3);
        if (_randomEvent == 0)
        {
            InsPet();
        }
        else if (_randomEvent == 1)
        {
            InsBall();
        }
        else if (_randomEvent == 2)
        {
            InsFood();
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
    private void InsBall()
    {
        int _ballIndex = Random.Range(0, Balls.Length);
        //�Ӿ����������л�ȡһ����������
        GameObject _ball = Instantiate(Balls[_ballIndex], transform.position + new Vector3(0, 5f, 0), transform.rotation);
        //������������������ȡ��Ӧ��Ԥ�����������
        _ball.transform.localEulerAngles = new Vector3(-30f, 0, 0);
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
        _ball.AddComponent<MoveEffect>();
        _ball.AddComponent<Ball_Find>();


    }

    //����ʳ��
    private void InsFood()
    {
        int _foodIndex = Random.Range(0, Foods.Length);
        GameObject _food = Instantiate(Foods[_foodIndex], transform.position + new Vector3(0, 5f, 0), transform.rotation);
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
        _food.AddComponent<MoveEffect>();
        _food.AddComponent<Food_Find>();

    }
}
