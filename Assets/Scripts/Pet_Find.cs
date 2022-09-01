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

    //碰撞触发器检测函数 
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Avatar") //如果进入的物体标签为“Avatar” 则
        {
            UI_Mgr_02.Instance.SetIm_Catch(true);
            Destroy(gameObject);
        }
    }
}
