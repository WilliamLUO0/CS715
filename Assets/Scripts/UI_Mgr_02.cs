using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Mgr_02 : MonoBehaviour
{

    public Text Tx_BallNum;
    //储存显示精灵球数量的 Text组件
    public Text Tx_FoodNum;
    //储存显示食物数量的 Text组件
    public GameObject Im_Catch;

    public static UI_Mgr_02 Instance;
    //申请静态公有脚本类变量

    void Awake()
    {
        Instance = this;
    }

    //增加精灵球数量显示
    public void AddBallNum()
    {
        int _num = Int32.Parse(Tx_BallNum.text);
        //将从Text组件中获取的字符串转化为数字储存在局部变量_num中
        _num++;
        //在原有的数字基础上加1
        Tx_BallNum.text = _num.ToString();
        //把增加后的数字转化为字符串显示在Text组件上
    }

    //增加食物的显示数量
    public void AddFoodNum()
    {
        int _num = Int32.Parse(Tx_FoodNum.text);
        //将从Text组件中获取的字符串转化为数字储存在局部变量_num中
        _num++;
        //在原有的数字基础上加1
        Tx_FoodNum.text = _num.ToString();
        //把增加后的数字转化为字符串显示在Text组件上
    }

    public void SetIm_Catch(bool bl)
    {
        Im_Catch.SetActive(bl);
    }
}