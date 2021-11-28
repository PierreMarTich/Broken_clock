using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayTime : MonoBehaviour
{
    public Text text;
    public string hourDisplay;
    public string minuteDisplay;
    public string secondDisplay;

    // Update is called once per frame
    void Update()
    {
        // Real time checker
        if (System.DateTime.UtcNow.Hour < 10)
        {
            hourDisplay = '0' + System.DateTime.UtcNow.Hour.ToString();
        }
        else
        {
            hourDisplay = System.DateTime.UtcNow.Hour.ToString();
        }
        if (System.DateTime.UtcNow.Minute < 10)
        {
            minuteDisplay = '0' + System.DateTime.UtcNow.Minute.ToString();
        }
        else
        {
            minuteDisplay = System.DateTime.UtcNow.Minute.ToString();
        }
        if (System.DateTime.UtcNow.Second < 10)
        {
            secondDisplay = '0' + System.DateTime.UtcNow.Second.ToString();
        }
        else
        {
            secondDisplay = System.DateTime.UtcNow.Second.ToString();
        }
        text.text = hourDisplay + ':' + minuteDisplay + ':' + secondDisplay;
    }
}
