using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

// [ExecuteInEditMode()]
public class BarController : MonoBehaviour
{
    public Image mask;
    public bool lossAversion = false;
    private float current;

    private float maximum;
    private float coeff = 15.0f;
    private bool useExerciseIntensity;

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
        float fillAmount;
        if (lossAversion) {
            fillAmount = (float)current / (float)maximum;
        } else {
            fillAmount = (((float)current * 7.0f) - coeff) / (float)maximum;
        }
        mask.fillAmount = fillAmount;
    }

    public void setBarValue(float exerciseIntensityValue, float averageSteps, bool useExerciseIntensity)
    {
        if (useExerciseIntensity) {
            current = exerciseIntensityValue;
            maximum = 11.5f;
            coeff = 15.0f;
        } else {
            current = averageSteps;
            maximum = 20.5f;
            coeff = 0f;
        }
    }

    public void setBarValue(float value)
    {
        current = value;
    }
}
