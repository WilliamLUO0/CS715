using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B2_Find : MonoBehaviour
{
    // Start is called before the first frame update
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
            UI_Mgr_02.Instance.AddB2Num();
            //����UI�������еĺ�������С����ʾ������
            Destroy(gameObject);
        }
    }
}
