using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GamerTimer : MonoBehaviour
{
    public float startTime = 20f;
    [SerializeField] TextMeshProUGUI timerText;
    public float timeElapsed;
    private bool isTimerRunning = true;

    int seconds;

    void Start()
    {
        timeElapsed = startTime;
    }

    void Update()
    {
        if (isTimerRunning)
        {
            timeElapsed -= Time.deltaTime;

            if (timeElapsed <= 0f)
            {
                timeElapsed = 0f;
                isTimerRunning = false;
            }

            int minutes = Mathf.FloorToInt(timeElapsed / 60F);
            int seconds = Mathf.FloorToInt(timeElapsed % 60F);

            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
    }
    public void TimeMinus()
    {
        timeElapsed -= 10;
    }
}
