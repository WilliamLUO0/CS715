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

    //碰撞触发器检测函数 
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Avatar") //如果进入的物体标签为“Avatar” 则
        {
            UI_Mgr_02.Instance.AddB2Num();
            //调用UI管理其中的函数增加小球显示的数量
            Destroy(gameObject);
        }
    }
}
