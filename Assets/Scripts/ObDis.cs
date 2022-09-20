using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObDis : MonoBehaviour
{
    private float t1 = 0, t2 = 0;
    // Start is called before the first frame update
    void Start()
    {
        t1 = Time.fixedTime;
    }

    // Update is called once per frame
    void Update()
    {
        t2 = Time.fixedTime;
        if (t2 - t1 >= 120)
        {
            
            InsPoint.Instance.deletePoint();
            Destroy(this.gameObject);
        }
    }
}
