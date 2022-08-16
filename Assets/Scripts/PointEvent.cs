using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointEvent : MonoBehaviour
{

    public GameObject Pet;
    //����С����Ԥ����
    public GameObject Ball;
    //���澫����Ԥ����
    public GameObject Food;
    //����ʳ��Ԥ����


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
        Instantiate(Pet, transform.position, transform.rotation);
    }

    //���ɾ�����
    private void InsBall()
    {
        GameObject _ball = Instantiate(Ball, transform.position + new Vector3(0, 5f, 0), transform.rotation);
        _ball.transform.localEulerAngles = new Vector3(-30f, 0, 0);
        //���þ�����ĽǶ�

    }

    //����ʳ��
    private void InsFood()
    {
        Instantiate(Food, transform.position + new Vector3(0, 5f, 0), transform.rotation);
    }
}
