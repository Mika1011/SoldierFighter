using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{   [Header("Component")]
    [SerializeField] TextMeshProUGUI timerText;

    [Header("Timer Settings")]
    [SerializeField] float currentTime;
    [SerializeField] bool countDown;
    [SerializeField] TextMeshProUGUI highScoreText;

    bool stopBool = false;

    void Update()
    {
        if (!stopBool)
        {
            currentTime = countDown ? currentTime -= Time.deltaTime : currentTime += Time.deltaTime;
            timerText.text = currentTime.ToString();
            setTimerText();
        }
    }

    private void setTimerText()
    {
        timerText.text = "Time: " + currentTime.ToString("0.0");
    }

    public void stop()
    {
        highScoreText.text = "Time: " + currentTime.ToString("0.0");
        stopBool = true;
    }
}
