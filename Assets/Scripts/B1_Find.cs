using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B1_Find : MonoBehaviour
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
            UI_Mgr_02.Instance.AddB1Num();
            //����UI�������еĺ�������С����ʾ������
            InsPoint.Instance.deletePoint();
            Destroy(gameObject);
            
        }
    }
}
