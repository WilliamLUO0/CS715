using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Mgr_02 : MonoBehaviour
{

    public Text Tx_B1Num;
    public Text Tx_B2Num;
    public Text Tx_B3Num;
    public Text Tx_B4Num;
    public Text Tx_B5Num;
    public GameObject Im_Catch;

    public static UI_Mgr_02 Instance;
    //申请静态公有脚本类变量

    void Awake()
    {
        Instance = this;
    }

    public void AddB1Num()
    {
        int _num = Int32.Parse(Tx_B1Num.text);
        //将从Text组件中获取的字符串转化为数字储存在局部变量_num中
        _num++;
        //在原有的数字基础上加1
        Tx_B1Num.text = _num.ToString();
        //把增加后的数字转化为字符串显示在Text组件上
    }

    public void AddB2Num()
    {
        int _num = Int32.Parse(Tx_B2Num.text);
        //将从Text组件中获取的字符串转化为数字储存在局部变量_num中
        _num++;
        //在原有的数字基础上加1
        Tx_B2Num.text = _num.ToString();
        //把增加后的数字转化为字符串显示在Text组件上
    }

    public void AddB3Num()
    {
        int _num = Int32.Parse(Tx_B3Num.text);
        _num++;
        Tx_B3Num.text = _num.ToString();
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