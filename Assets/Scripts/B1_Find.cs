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

    // Collision trigger detection function
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Avatar") // Object tagged "Avatar"
        {
            UI_Mgr_02.Instance.AddB1Num();
            // Call the function in the UI management to increase the number of displays
            InsPoint.Instance.deletePoint();
            Destroy(gameObject);
            
        }
    }
}
