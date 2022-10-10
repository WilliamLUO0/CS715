using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsPoint : MonoBehaviour
{
    public GameObject Ava;
    public GameObject PrePoint;
    public float MinDis = 3f;
    public float MaxDis = 50f;
    public static int x = 0;

    private Vector3 v3Ava;

    public static InsPoint Instance;

    void Awake()
    {
        Instance = this;
    }


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("InsPointFuc1");
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    // auto-generated function
    IEnumerator InsPointFuc1()
    {
        while (true)
        {
            if (x <= 16)
            {
                InsPointFuc();
                x++;
                InsPointFuc();
                x++;
                InsPointFuc();
                x++;
                InsPointFuc();
                x++;
            }
            print("DoSomething Loop");

            yield return new WaitForSeconds(1);
            Debug.Log("existing objects" + x);
        }
    }
    
    // generate objects
    public void InsPointFuc()
    {
        v3Ava = Ava.transform.position;
        float _dis = Random.Range(MinDis, MaxDis);
        Vector2 _pOri = Random.insideUnitCircle;
        Vector2 _pNor = _pOri.normalized;
        Vector3 _v3Point = new Vector3(v3Ava.x + _pNor.x * _dis, 0, v3Ava.z + _pNor.y * _dis);
        GameObject _poiMark = Instantiate(PrePoint, _v3Point, transform.rotation);

    }

    public void deletePoint()
    {
        x--;
    }
}
