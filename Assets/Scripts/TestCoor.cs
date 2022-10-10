using GoShared;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCoor : MonoBehaviour
{
    public GameObject[] B1s;

    void Awake()
    {
        B1s = Resources.LoadAll<GameObject>("B1s");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Test Coordinate Transformation
    public void CheckPosition()
    {
        GameObject _avatar = GameObject.FindGameObjectWithTag("Avatar");
        Vector3 _avatarV3 = _avatar.transform.position;
        Coordinates _coordinates = Coordinates.convertVectorToCoordinates(_avatarV3);
        Debug.Log("Avatar Latitude:" + _coordinates.latitude + "Avatar Longtitude" + _coordinates.longitude);
    }

    public void SetB1s()
    {
        int _ballIndex = Random.Range(0, B1s.Length);
        GameObject _food = Instantiate(B1s[_ballIndex], transform.position + new Vector3(0, 5f, 0), transform.rotation);
        _food.AddComponent<BoxCollider>();
        _food.GetComponent<BoxCollider>().isTrigger = true;
        _food.GetComponent<BoxCollider>().center = new Vector3(0, 0, 0);
        _food.GetComponent<BoxCollider>().size = new Vector3(5.6f, 8.4f, 5.6f);
        _food.AddComponent<Rigidbody>();
        _food.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        _food.AddComponent<B1_Find>();

        Coordinates _coordinates = new Coordinates(39.9169425, 116.390777, 0);

        Vector3 _v3 = _coordinates.convertCoordinateToVector(0);


        _food.transform.position = _v3;
    }
}
