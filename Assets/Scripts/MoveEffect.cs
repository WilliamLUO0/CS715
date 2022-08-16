using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEffect : MonoBehaviour
{

	private float radian = 0;
	//��ʼ�Ļ���

	private float perRad = 0.03f;
	//���ȵı仯ֵ
	private float add = 0f;
	//����λ�Ƶ�ƫ����
	private Vector3 posOri;
	//������������ʱ����ʵ����


	// Use this for initialization
	void Start()
	{
		posOri = transform.position;
		//�����������ʱ��������¼����
	}

	// Update is called once per frame
	void Update()
	{
		radian += perRad;
		//���Ȳ��ϵ�����
		add = Mathf.Sin(radian);
		//�ó�ƫ��ֵ
		transform.position = posOri + new Vector3(0, add, 0);
		//�����帡������


		transform.Rotate(0, Time.deltaTime * 25f, 0, Space.World);
		//����������Ϊ��ת���� ��Y���Ͻ�����ת
	}
}