using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTimer : MonoBehaviour
{
    public Transform barFull;
    public Transform barEmpty;
    public float maxTimerValue = 20;



    public void adjust(float a)
    {
        float b = ((a * 100) / maxTimerValue) * 0.01f;
        SetFillBar(b);
    }

    //Scales white part of the timer accordingly to the time passed
    public void SetFillBar(float fillAmount)
    {
        fillAmount = Mathf.Clamp01(fillAmount);
        var newScale = barFull.localScale;
        newScale.x = barEmpty.localScale.x * fillAmount;
        barFull.localScale = newScale;
    }



}
