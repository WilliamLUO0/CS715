using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsPoint : MonoBehaviour
{
    public GameObject Ava;
    public GameObject PrePoint;
    public float MinDis = 3f;
    public float MaxDis = 50f;

    private Vector3 v3Ava;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InsPointFuc()
    {
        v3Ava = Ava.transform.position;
        float _dis = Random.Range(MinDis, MaxDis);
        Vector2 _pOri = Random.insideUnitCircle;
        Vector2 _pNor = _pOri.normalized;
        Vector3 _v3Point = new Vector3(v3Ava.x + _pNor.x * _dis, 0, v3Ava.z + _pNor.y * _dis);
        GameObject _poiMark = Instantiate(PrePoint, _v3Point, transform.rotation);

    }
}
