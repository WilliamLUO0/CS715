using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Mgr_02 : MonoBehaviour
{

    public Text Tx_BallNum;
    //������ʾ������������ Text���
    public Text Tx_FoodNum;
    //������ʾʳ�������� Text���
    public GameObject Im_Catch;

    public static UI_Mgr_02 Instance;
    //���뾲̬���нű������

    void Awake()
    {
        Instance = this;
    }

    //���Ӿ�����������ʾ
    public void AddBallNum()
    {
        int _num = Int32.Parse(Tx_BallNum.text);
        //����Text����л�ȡ���ַ���ת��Ϊ���ִ����ھֲ�����_num��
        _num++;
        //��ԭ�е����ֻ����ϼ�1
        Tx_BallNum.text = _num.ToString();
        //�����Ӻ������ת��Ϊ�ַ�����ʾ��Text�����
    }

    //����ʳ�����ʾ����
    public void AddFoodNum()
    {
        int _num = Int32.Parse(Tx_FoodNum.text);
        //����Text����л�ȡ���ַ���ת��Ϊ���ִ����ھֲ�����_num��
        _num++;
        //��ԭ�е����ֻ����ϼ�1
        Tx_FoodNum.text = _num.ToString();
        //�����Ӻ������ת��Ϊ�ַ�����ʾ��Text�����
    }

    public void SetIm_Catch(bool bl)
    {
        Im_Catch.SetActive(bl);
    }
}