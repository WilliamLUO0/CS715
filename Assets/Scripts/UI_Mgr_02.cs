using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Mgr_02 : MonoBehaviour
{

    public Text Tx_B1Num_Dragon;
    public Text Tx_B2Num_DragonBaby;
    public Text Tx_B3Num_Gem;
    public Text Tx_B4Num;
    public Text Tx_B5Num;
    public GameObject Im_Catch;


    public static UI_Mgr_02 Instance;
    //���뾲̬���нű������

    void Awake()
    {
        Instance = this;
    }

    public void AddB1Num()
    {
        int _num = Int32.Parse(Tx_B1Num_Dragon.text);
        //����Text����л�ȡ���ַ���ת��Ϊ���ִ����ھֲ�����_num��
        _num++;
        //��ԭ�е����ֻ����ϼ�1
        Tx_B1Num_Dragon.text = _num.ToString();
        //�����Ӻ������ת��Ϊ�ַ�����ʾ��Text�����
    }

    public void AddB2Num()
    {
        int _num = Int32.Parse(Tx_B2Num_DragonBaby.text);
        //����Text����л�ȡ���ַ���ת��Ϊ���ִ����ھֲ�����_num��
        _num++;
        //��ԭ�е����ֻ����ϼ�1
        Tx_B2Num_DragonBaby.text = _num.ToString();
        //�����Ӻ������ת��Ϊ�ַ�����ʾ��Text�����
    }

    public void AddB3Num()
    {
        int _num = Int32.Parse(Tx_B3Num_Gem.text);
        _num++;
        Tx_B3Num_Gem.text = _num.ToString();
    }

    public void AddB4Num()
    {
        int _num = Int32.Parse(Tx_B4Num.text);
        _num++;
        Tx_B4Num.text = _num.ToString();
    }

    public void AddB5Num()
    {
        int _num = Int32.Parse(Tx_B5Num.text);
        _num++;
        Tx_B5Num.text = _num.ToString();
    }

    public void SetIm_Catch(bool bl)
    {
        Im_Catch.SetActive(bl);
    }
}