using GoShared;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject InsCube;
    //������̬���ý���ͼ��3D����

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckPositon()
    {

        GameObject _avatar = GameObject.FindGameObjectWithTag("Avatar");
        //ͨ����ǩ���ҵ���ɫ����Ϸ���� �����ھֲ����� _avatar��

        Vector3 _avatarV3 = _avatar.transform.position;
        //��ȡ��ɫ��ǰλ�õ�Vector3����

        Coordinates _coordinates = Coordinates.convertVectorToCoordinates(_avatarV3);
        //ͨ��Vector3���͵����� ת���ɾ�γ������

        Debug.Log("Avatar Latitude:" + _coordinates.latitude + "Avatar Longitude:" + _coordinates.longitude);
        //��ת���õľ�γ����ʾ�ڿ���̨��

    }

    public void SetCube()
    {

        Coordinates _coordinates = new Coordinates(39.9169425, 116.390777, 0);
        //���þ�γ��

        Vector3 _v3 = _coordinates.convertCoordinateToVector(0);
        //�Ѿ�γ��ת��Ϊ��Ϸ�е�����

        GameObject _cube = Instantiate(InsCube);
        //����Ԥ�ƺ���

        _cube.transform.position = _v3;
        //���ú��ӵ�λ��
    }
}
