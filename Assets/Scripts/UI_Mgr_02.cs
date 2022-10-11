using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Mgr_02 : MonoBehaviour
{

    public Text Tx_B1Num_Gem;
    public Text Tx_B2Num_DragonBaby;
    public Text Tx_B3Num_Dragon;
    public Text Tx_B4Num;
    public Text Tx_B5Num;
    public GameObject Im_Catch;

    // static script
    public static UI_Mgr_02 Instance;

    void Awake()
    {
        Instance = this;
    }

    // Increase the number of B1s on the panel
    public void AddB1Num()
    {
        int _num = Int32.Parse(Tx_B1Num_Gem.text);
        _num++;
        Tx_B1Num_Gem.text = _num.ToString();
    }

    // Increase the number of B2s on the panel
    public void AddB2Num()
    {
        int _num = Int32.Parse(Tx_B2Num_DragonBaby.text);
        _num++;
        Tx_B2Num_DragonBaby.text = _num.ToString();
    }

    // Increase the number of B3s on the panel
    public void AddB3Num()
    {
        int _num = Int32.Parse(Tx_B3Num_Dragon.text);
        _num++;
        Tx_B3Num_Dragon.text = _num.ToString();
    }

    // Increase the number of B4s on the panel
    public void AddB4Num()
    {
        int _num = Int32.Parse(Tx_B4Num.text);
        _num++;
        Tx_B4Num.text = _num.ToString();
    }

    // Increase the number of B5s on the panel
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
