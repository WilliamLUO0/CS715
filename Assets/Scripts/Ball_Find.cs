using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Find : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //��ײ��������⺯�� 
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Avatar") //�������������ǩΪ��Avatar�� ��
        {
            UI_Mgr_02.Instance.AddBallNum();
            //����UI�������еĺ�������С����ʾ������
            Destroy(gameObject);
        }
    }
}
