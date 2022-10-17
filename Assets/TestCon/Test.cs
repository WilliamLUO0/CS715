using GoShared;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject InsCube;
    //用来动态放置进地图的3D盒子

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
        //通过标签查找到角色的游戏物体 保存在局部变量 _avatar中

        Vector3 _avatarV3 = _avatar.transform.position;
        //获取角色当前位置的Vector3坐标

        Coordinates _coordinates = Coordinates.convertVectorToCoordinates(_avatarV3);
        //通过Vector3类型的坐标 转化成经纬度坐标

        Debug.Log("Avatar Latitude:" + _coordinates.latitude + "Avatar Longitude:" + _coordinates.longitude);
        //把转化好的经纬度显示在控制台上

    }

    public void SetCube()
    {

        Coordinates _coordinates = new Coordinates(39.9169425, 116.390777, 0);
        //设置经纬度

        Vector3 _v3 = _coordinates.convertCoordinateToVector(0);
        //把经纬度转化为游戏中的坐标

        GameObject _cube = Instantiate(InsCube);
        //生成预制盒子

        _cube.transform.position = _v3;
        //设置盒子的位置
    }
}
