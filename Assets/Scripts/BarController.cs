using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

[ExecuteInEditMode()]
public class BarController : MonoBehaviour
{
    public float maximum;
    public float current;
    public Image mask;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        getCurrentFill();
    }

    public void getCurrentFill()
    {
        float fillAmount = (float)current / (float)maximum;
        mask.fillAmount = fillAmount;
    }

    public void setBarValue(float energyValue)
    {
        current = energyValue;
    }
}
