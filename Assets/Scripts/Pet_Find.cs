using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pet_Find : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.LookAt(GameObject.FindGameObjectWithTag("Avatar").transform);
        
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
            UI_Mgr_02.Instance.SetIm_Catch(true);
            Destroy(gameObject);
        }
    }
}
