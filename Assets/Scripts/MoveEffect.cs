using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEffect : MonoBehaviour
{

	private float radian = 0;
	//起始的弧度

	private float perRad = 0.03f;
	//弧度的变化值
	private float add = 0f;
	//储存位移的偏移量
	private Vector3 posOri;
	//储存物体生成时的其实坐标


	// Use this for initialization
	void Start()
	{
		posOri = transform.position;
		//把物体刚生成时候的坐标记录下来
	}

	// Update is called once per frame
	void Update()
	{
		radian += perRad;
		//弧度不断的增加
		add = Mathf.Sin(radian);
		//得出偏移值
		transform.position = posOri + new Vector3(0, add, 0);
		//让物体浮动起来


		transform.Rotate(0, Time.deltaTime * 25f, 0, Space.World);
		//以世界坐标为旋转依据 在Y轴上进行旋转
	}
}